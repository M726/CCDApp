using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CCDApp
{

    public delegate void FrameCallbackDelegate(ref ImageProperty frameProperty, IntPtr BufferPtr);

    public class USBCamInterface
    {

        public enum ResolutionType
        {
            reolution1280x960,
            reolution640x480,
            reolution424x320,
            reolution320x240,
            reolution320x240bin2,
        };
        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        private int numDevices = 0;

        private string[] moduleNumbers;
        private string[] serialNumbers;
        private bool engineRunning = false; //currently active engines

        private PictureBox[] pictureBoxes;

        private IntPtr windowHandle;
        public FrameCallbackDelegate frameDelegate;
        public FrameCallbackDelegate frameSaveDelegate;

        public CCDCamera[] CCDCameras;

        public string path;
        
        private ColorPalette palette;
        public USBCamInterface(IntPtr handle)
        {
            //TODO: Add a 12bpp format
            palette = new GreyscaleFormat8bpp().GreyScale8bpp;
            windowHandle = handle;
            frameDelegate = new FrameCallbackDelegate(FrameCallback);
            frameSaveDelegate = new FrameCallbackDelegate(FrameSaveCallback);
        }


          /****************/
         //Overall Status//
        /****************/

        public void Init()
        {
            /*
             * Manual says:
             * InitDevice() 1 
             * AddCameraToWorkingSet 2 
             * StartCameraEngine 3 
             */
            if(numDevices > 0)
            {
                Terminate();
            }

            numDevices = BufInitDevice();
            Console.WriteLine(String.Format("{0} Devices Detected", numDevices));

            serialNumbers = new string[numDevices];
            moduleNumbers = new string[numDevices];
            CCDCameras = new CCDCamera[numDevices];
            pictureBoxes = new PictureBox[numDevices];
            for (int i = 0; i < numDevices; i++)
            {
                CCDCameras[i] = new CCDCamera(i + 1);
                CCDCameras[i].SetDebugMode(true);

                moduleNumbers[i] = CCDCameras[i].GetModelNumber();
                serialNumbers[i] = CCDCameras[i].GetSerialNumber();
                CCDCameras[i].ActivateDevice();
            }

            Console.WriteLine(String.Format("{0} Devices Initialized",numDevices));
            StartEngine();
            

            for(int i = 0; i < numDevices; i++)
            {
                CCDCameras[i].UpdateCamera();
            }

            
        }
        public bool Terminate()
        {

            /*
             * Manual Says:
             * StopCameraEngine()
             * UnInitDevice()
             */
            StopEngine();
            int unInitDevice = BufUnInitDevice();

            Console.WriteLine(String.Format("{0} Devices Uninitialized", numDevices));
            numDevices = 0;
            return true;
        }
        
        public void AssignPictureBox(int id, PictureBox pb)
        {
            pictureBoxes[id] = pb;
        }

        public bool StartEngine()
        {
            if (!engineRunning)
            {
                if (BufStartCameraEngine(windowHandle, (uint)8) == 1)
                {
                    engineRunning = true;
                    Console.WriteLine("Camera Engine Started");
                    return true;
                }
                engineRunning = false;
                Console.WriteLine("Camera Engine Failed");
                return false;
            }
            return true;
        }
        public void StopEngine()
        {
            if (engineRunning)
            {
                BufStopFrameGrab();
                if ((BufStopCameraEngine()) > 0)
                {
                    engineRunning = false;
                    Console.WriteLine("Camera Engine Stopped");
                }
            }
        }
        
        
        public void StartFrameGrab(int totalFrames)
        {
            //BufInstallFrameHooker( 0, frameDelegate); //Raw data.
            int fh = BufInstallFrameHooker(1, frameDelegate); // BMP data
            int fg = BufStartFrameGrab(30);// totalFrames);
            Console.WriteLine(String.Format("Starting Frame Grab. {2} Frames. {0} {1}", fh, fh, totalFrames));
        }

        public void StartFrameCapture(int totalFrames)
        {
            StopFrameGrab();
            int fh = BufInstallFrameHooker(1, frameSaveDelegate); // BMP data
            int fg = BufStartFrameGrab(totalFrames);
            Console.WriteLine(String.Format("Starting Frame Capture. {2} Frames. {0} {1}", fh, fh, totalFrames));
        }

        public void StopFrameGrab()
        {
            // Install frame call back.
            int fh = BufInstallFrameHooker(1, null); // BMP data
            Console.WriteLine(String.Format("Stopping Frame Grab {0}", fh));
        }
        
        public void SetResolution(ResolutionType resolution, int id)
        {
            switch (resolution)
            {
                case ResolutionType.reolution640x480:
                    CCDCameras[id].SetResolution(640, 480, 129);
                    break;
                case ResolutionType.reolution424x320:
                    CCDCameras[id].SetResolution(424, 320, 130);
                    break;
                case ResolutionType.reolution320x240:
                    CCDCameras[id].SetResolution(320, 240, 131);
                    break;
                case ResolutionType.reolution320x240bin2:
                    CCDCameras[id].SetResolution(320, 240, 3);
                    break;
                default:
                    CCDCameras[id].SetResolution(1280, 960, 0);
                    break;

            }
        }

        public void SetGammaValue(int gamma, int contrast, int brightness)
        {
            /*
             * gamma 1-20
             * contrast 0-100
             * bright 0-100
             * sharp 0-3
             */

            BufSetGamma(gamma, contrast, brightness, 0);
        }
        public void SetShowMode(bool horzMirror, bool vertFlip)
        {

            BufSetBWMode(1, horzMirror ? 1 : 0, vertFlip ? 1 : 0);
        }


        public double GetExposureTime(int id)
        {
            return CCDCameras[id].GetExposureTime();
        }

        public void SetExposureTime(UInt32 expTimeMs)
        {
            for (int i = 0; i < numDevices; i++)
            {
                SetExposureTime(expTimeMs, i);
            }
        }
        public void SetExposureTime(double expTimeMs, int id)
        {
            if (expTimeMs < 0) expTimeMs = 1;
            if (expTimeMs > 200000) expTimeMs = 200000;

            CCDCameras[id].SetExposureTime(expTimeMs);
        }

        public int GetGain(int id)
        {
            return CCDCameras[id].GetGain();
        }
        public void SetGain(int gain)
        {
            for (int i = 0; i < numDevices; i++)
            {
                SetGain(gain, i);
            }
        }
        public void SetGain(int gain, int id)
        {
            CCDCameras[id].SetGain(gain);
        }

        public void SetDisplayName(string name, int id)
        {
            CCDCameras[id].SetDisplayName(name);
        }

        /*************************************/
        //Memory Mangment & Buffer Processing//
        /*************************************/
        public void FrameCallback( ref ImageProperty imgProperty, IntPtr bufferPtr)
        {
            int id = imgProperty.CameraID-1;
            int width = imgProperty.Column;
            int height = imgProperty.Row;

            Bitmap bmp = new Bitmap(width, height, width, PixelFormat.Format8bppIndexed, bufferPtr)
            {
                Palette = palette
            };
            DrawFrame(id, bmp);
        }

        public void FrameSaveCallback( ref ImageProperty imgProperty, IntPtr bufferPtr)
        {
            int id = imgProperty.CameraID - 1;
            int width = imgProperty.Column;
            int height = imgProperty.Row;

            Bitmap bmp = new Bitmap(width, height, width, PixelFormat.Format8bppIndexed, bufferPtr)
            {
                Palette = palette
            };
            //SaveFrame(id, bmp);
        }

        public void SaveFrame(int id, Bitmap data, int frameNumber)
        {
            IntPtr hBitmap = data.GetHbitmap();
            try
            {
                Bitmap image = Image.FromHbitmap(hBitmap);

                
                //image.Save(String.Format("{0}\\{1}_{2}.bmp", path, CCDCameras[id].GetDisplayName(), frameNumber));

                image.Palette = palette; //remap the colors to 0-255 greyscale

                //Find the largest size we can make our image to fit the box, then crop the box to that size
                Size newSize = FindCommonSize(image.Size, new Size(400, 400)); //new Size(400, 400);

                //Set Image
                pictureBoxes[id].Size = newSize;
                pictureBoxes[id].Image = new Bitmap(image, newSize);

                image.Dispose();
                data.Dispose();

                GC.Collect();
            }
            finally
            {
                DeleteObject(hBitmap); //Very important otherwise massive memory leak
            }
        }


        public void DrawFrame(int id, Bitmap data)
        {
            IntPtr hBitmap = data.GetHbitmap();
            try
            {
                Bitmap image = Image.FromHbitmap(hBitmap);
                image.Palette = palette; //remap the colors to 0-255 greyscale

                //Find the largest size we can make our image to fit the box, then crop the box to that size
                Size newSize = FindCommonSize(image.Size, new Size(400,400)); //new Size(400, 400);

                //Set Image
                pictureBoxes[id].Size = newSize;
                pictureBoxes[id].Image = new Bitmap(image, newSize);
                
                image.Dispose();
                data.Dispose();

                GC.Collect();
            }
            finally
            {
                DeleteObject(hBitmap); //Very important otherwise massive memory leak
            }
        }

        private Size FindCommonSize(Size s1, Size s2)
        {

            //need to resize the image so it always fits in the frame, regardless of the frame aspect ratio
            //if frame AR > image AR then we are bound by height
            //if frame AR < image AR then we are bound by width

            double aspectRatio = (double)s1.Width / (double)s1.Height;

            double aspectRatioFrame = (double)s2.Width / (double)s2.Height;

            Size newSize = new Size();
            if (aspectRatioFrame > aspectRatio)
            {
                newSize.Height = s2.Height;
                newSize.Width = (int)Math.Round(s2.Height * aspectRatio);
            }
            else
            {
                newSize.Width = s2.Width;
                newSize.Height = (int)Math.Round((double)s2.Width / aspectRatio);
            }
            return newSize;

        }



        /******/
        //Info//
        /******/
        public int getNumCameras()
        {
            return numDevices;
        }
        public string[] getDevices()
        {
            string[] deviceList = new string[numDevices];
            for (int i = 0; i < numDevices; i++) {

                deviceList[i] = String.Format("{0}{1}", moduleNumbers[i], serialNumbers[i]);
            }
            return deviceList;
        }


        #region Mightex interop functions for accessing BUF_USBCCDCamera_SDK_Stdcall.dll and BufferCameraUsblib.dll files

        //Call this function first, this function communicates with device driver to reserve resources
        //When the system uses NTFS use WINNT, for FAT32 use WINDOWS
        //Add dlls to exe folder

        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_InitDevice", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufInitDevice();


        //Call this function before the app terminates, it releases all resources
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_UnInitDevice", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufUnInitDevice();

        //Camera has multithread engine internally, which is responsible for all the frame grabbing, raw data to RGB data conversion etc. functions. 
        //User MUST start this engine for all the following camera related operations
        //ParentHandle ?The window handle of the main form of user’s application, as the engine relies on
        //Windows Message Queue, it needs a parent window handle
        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_StartCameraEngine", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufStartCameraEngine(IntPtr parentHandle, uint cameraBitOption);

        //Stops the started camera engine.
        //returns:  -1 If the function fails (e.g. invalid device handle or if the engine is NOT started), 1 if the call succeeds.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_StopCameraEngine", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufStopCameraEngine();

        //Showes (makes visible) the factory control panel which will be displayed once the camera engine starts
        //returns:  -1 If the function fails (e.g. invalid device handle or if the engine is NOT started yet), 1 if the call succeeds.
        /*
         * JTZ: I add this API for user debug purpose. 
         */
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_ShowFactoryControlPanel", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufShowFactoryControlPanel(int deviceID, String password);

        //Hides (makes invisible) the control panel which will be displayed once the camera engine starts
        //returns:  -1 If the function fails (e.g. invalid device handle or if the engine is NOT started yet), 1 if the call succeeds.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_HideFactoryControlPanel", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufHideFrameControlPanel();

        //Starts frame grabbing after camera resources prepared.
        //After call, user should see images in video window
        //returns:  -1 If the function fails (e.g. invalid device handle or if the engine is NOT started yet), 1 if the call succeeds.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_StartFrameGrab", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufStartFrameGrab(int totalFrames);

        //Stops frame grabbing, call if totalFrames set to INFINITE_FRAMES
        //returns:  -1 If the function fails (e.g. invalid device handle or if the engine is NOT started yet), 1 if the call succeeds.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_StopFrameGrab", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufStopFrameGrab();

        //Set the Gamma, Contrast and Brightness parameters
        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        //Note: only four elements _gamma? _contrast? _bright and _sharpLevel are used by this function, all others are ignored.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_SetGamma", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufSetGamma(int gamma, int contrast, int brightness, int sharpLevel);

        //Automatically set white balance, set proper exposure time and put white paper in front of camera
        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_SetBWMode", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufSetBWMode(int bWMode, int hMirror, int vFlip);

        // JTZ: we allow user to install a callback for each grabbed frame.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_InstallFrameHooker", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufInstallFrameHooker(int FrameType, Delegate FrameCallBack);

        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_InstallUSBDeviceHooker", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufInstallUSBDeviceHooker(Delegate USBDeviceCallBack);

        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_SetGPIOConfig", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufSetGPIOConfig(int deviceID, byte configByte);

        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_SetGPIOInOut", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufSetGPIOInOut(int deviceID, byte outputByte, out byte InByte);

        #endregion
    }
}