using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CCDApp
{
    public class CCDCamera
    {
        private int idx; //1,2,...
        private int row = 1280;
        private int column = 960;
        private int bin = 0;
        private int xStart = 0;
        private int yStart = 0;
        private int exposureTime = 5000; //250ms
        private int redGain = 0;
        private int greenGain = 16;
        private int blueGain = 0;
        private int mode = 0; //Raw or BMP

        private bool active = false;
        private string modelNumber;
        private string serialNumber;
        /*****************/
        //Device Settings//
        /*****************/
        public CCDCamera(int cameraID)
        {
            idx = cameraID;
            //uint addDeviceToWorkingSet = BufAddDeviceToWorkingSet(i);
            StringBuilder moduleNoRtn = new StringBuilder();
            StringBuilder serialNoRtn = new StringBuilder();

            switch (BufGetModuleNoSerialNo(idx, moduleNoRtn, serialNoRtn))
            {
                case -1:
                    //function failed - invalid device id
                    Console.WriteLine(String.Format("Init Failed: Invalid Device ID. Device {0}. BufGetModuleNoSerialNo: -1", idx));
                    break;
                case -2:
                    //function failed - engine started already
                    Console.WriteLine(String.Format("Init Failed: Engine Started Already. Device {0}. BufGetModuleNoSerialNo: -2", idx));
                    break;
                case 1:
                    //success
                    modelNumber = moduleNoRtn.ToString();
                    serialNumber = serialNoRtn.ToString();
                    Console.WriteLine(String.Format("CCD{0} {1}{2} Initialized",idx,GetModelNumber(),GetSerialNumber()));
                    break;
                default:
                    break;
            }
        }

        public bool ActivateDevice()
        {
            if (!active)
            {
                if (BufAddDeviceToWorkingSet(idx) > 0)
                {
                    active = true;
                    return true;
                }
            }
            return false;
        }
        public bool DeactivateDevice()
        {
            if (active)
            {
                if (BufRemoveDeviceFromWorkingSet(idx) > 0)
                {
                    active = false;
                    return true;
                }
            }
            return false;
        }

        public void SetContinuousMode(bool continuous)
        {
            if (continuous)
            {
                mode = 0;
            }
            else
            {
                mode = 1;
            }
            UpdateMode();
        }
        public void SetResolution(int height, int width, int binMode)
        {
            //width = row size
            row = width;
            column = height;
            bin = binMode;

            UpdateResolution();
        }
        public void SetStartPosition(int x, int y)
        {
            xStart = x;
            yStart = y;
            UpdateStartPosition();
        }
        public void SetGain(int gain)
        {
            if (gain > 41)
                gain = 41;
            if (gain < 6)
                gain = 6;

            redGain = gain;
            greenGain = gain;
            blueGain = gain;

            UpdateGain();
        }
        public void SetExposureTime(double expTime)
        {

            //from 50us to 200,000ms mapped onto 1-4,000,000
            //increase of 1 = 50us
            int mappedExposureTime = (int)Math.Round(20.0 * expTime);
            exposureTime = mappedExposureTime;
            UpdateExposureTime();
        }

        public void UpdateMode()
        {
            BufSetCameraWorkMode(idx, mode);
        }
        public void UpdateResolution()
        {
            BufSetCustomizedResolution(idx, row, column, bin, 4);
        }
        public void UpdateStartPosition()
        {
            BufSetStartPosition(idx, xStart, yStart);
        }
        public void UpdateGain()
        {
            BufSetGains(idx, redGain, greenGain, blueGain);
        }
        public void UpdateExposureTime()
        {
            BufSetExposureTime(idx, exposureTime);
        }

        public int GetMode()
        {
            return mode;
        }
        public int GetHeight()
        {
            return column;
        }
        public int GetWidth()
        {
            return row;
        }
        public int GetXStart()
        {
            return xStart;
        }
        public int GetYStart()
        {
            return yStart;
        }
        public int GetGain()
        {
            return greenGain;
        }
        public double GetExposureTime()
        {
            return 0.05 * (double)exposureTime;
        }
        public string GetModelNumber()
        {
            return modelNumber;
        }
        public string GetSerialNumber()
        {
            return serialNumber;
        }

        public void UpdateCamera()
        {
            UpdateResolution();
            UpdateStartPosition();
            UpdateExposureTime();
            UpdateGain();
        }

        #region Camera Specific DLL

        //The module number and serial number are what appear if one calls the
        //SDK_HANDLE_API BUFCCDUSB_ShowOpenDeviceDialog() method.
        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_GetModuleNoSerialNo", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufGetModuleNoSerialNo(int deviceID, StringBuilder moduleNo, StringBuilder serialNo);


        //Add device to working set, deviceID is a one base index, so if InitDevice returns 2 for example, there devices at 1 and 2.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_AddDeviceToWorkingSet", CallingConvention = CallingConvention.StdCall)]
        private static extern uint BufAddDeviceToWorkingSet(int deviceID);

        //Remove device from working set. 
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_RemoveDeviceFromWorkingSet", CallingConvention = CallingConvention.StdCall)]
        private static extern uint BufRemoveDeviceFromWorkingSet(int deviceID);

        //Sets camera to either "video" mode - continuously deliver frames to PC or
        //"external trigger" mode - camera waits for external trigger to capture 1 frame
        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_SetCameraWorkMode", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufSetCameraWorkMode(int deviceID, int WorkMode);

        //Set the resolution (including capture and render)
        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        //Note: only three elements _resolution, _binMode and _imageRendorFitWindow are used by this function, all others are ignored.

        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        //Note: only three elements _resolution, _binMode and _imageRendorFitWindow are used by this function, all others are ignored.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_SetCustomizedResolution", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufSetCustomizedResolution(int deviceID, int rowSize, int columnSize, int bin, int bufferCnt);


        //Set the start position of ROI
        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        //Note: only two elements _xStart and _yStart are used by this function, all others are ignored.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_SetXYStart", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufSetStartPosition(int deviceID, int xStart, int yStart);

        //Set RGB Gains parameters
        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        //Note: only three elements _greenGain, _blueGain and _redGain are used by this function, all others are ignored.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_SetGains", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufSetGains(int deviceID, int redGain, int greenGain, int blueGain);

        //Set exposure parameters
        //returns:  -1 If the function fails (e.g. invalid device handle), 1 if the call succeeds.
        //Note: only two elements _maxExposureTimeIndex and _exposureTime are used by this function, all others are ignored.
        [DllImport("BUF_USBCCDCamera_SDK_Stdcall.dll", EntryPoint = "BUFCCDUSB_SetExposureTime", CallingConvention = CallingConvention.StdCall)]
        private static extern int BufSetExposureTime(int deviceID, int exposureTime);
        #endregion
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ImageProperty
    {
        [FieldOffset(0)] public int CameraID;
        [FieldOffset(4)] public int Row;
        [FieldOffset(8)] public int Column;
        [FieldOffset(12)] public int Bin;
        [FieldOffset(16)] public int XStart;
        [FieldOffset(20)] public int YStart;
        [FieldOffset(24)] public int ExposureTime;
        [FieldOffset(28)] public int RedGain;
        [FieldOffset(32)] public int GreenGain;
        [FieldOffset(36)] public int BlueGain;
        [FieldOffset(40)] public int TimeStamp;
        [FieldOffset(44)] public int TriggerOccurred;
        [FieldOffset(48)] public int TriggerEventCount;
        [FieldOffset(52)] public int UserMark;
        [FieldOffset(56)] public int FrameTime;
        [FieldOffset(60)] public int CCDFrequency;
        [FieldOffset(64)] public int ProcessFrameType;
        [FieldOffset(68)] public int tFilterAcceptForFile;
    }

    public delegate void FrameCallbackDelegate(ref ImageProperty frameProperty, IntPtr BufferPtr);

    public class USBCamInterface
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        private int numDevices = 0;

        private string[] moduleNumbers;
        private string[] serialNumbers;
        private bool engineRunning = false; //currently active engines

        private IntPtr windowHandle;
        private IntPtr imagePointer = new IntPtr();
        public FrameCallbackDelegate frameDelegate;

        public CCDCamera[] CCDCameras;
        private enum CAMERA_BIT { BIT_8_CAMERA = 8, BIT_12_CAMERA = 12 };
        PictureBox[] p;

        private ColorPalette palette;
        public USBCamInterface(IntPtr handle, PictureBox[] ps)
        {
            p = ps;
            windowHandle = handle;
            frameDelegate = new FrameCallbackDelegate(FrameCallback);
            palette = CalculateGreyscalePalette();
        }

        private ColorPalette CalculateGreyscalePalette() //from https://stackoverflow.com/questions/8603596/how-can-i-define-a-8-bit-grayscale-image-directly
        {
            Bitmap bmp = new Bitmap(1, 1, PixelFormat.Format8bppIndexed);
            ColorPalette p = bmp.Palette;

            Color[] entries = p.Entries;
            for (int i = 0; i < 256; i++)
            {
                entries[i] = Color.FromArgb(i, i, i);
            }
            return p;
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

            numDevices = BufInitDevice(); //1
            Console.WriteLine(String.Format("{0} Devices Detected", numDevices));

            serialNumbers = new string[numDevices];
            moduleNumbers = new string[numDevices];
            CCDCameras = new CCDCamera[numDevices];
            for (int i = 0; i < numDevices; i++)
            {
                CCDCameras[i] = new CCDCamera(i + 1);
                CCDCameras[i].ActivateDevice();
                moduleNumbers[i] = CCDCameras[i].GetModelNumber();
                serialNumbers[i] = CCDCameras[i].GetSerialNumber();
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
        
        public bool StartEngine()
        {
            if (!engineRunning)
            {
                if (BufStartCameraEngine(windowHandle, (uint)CAMERA_BIT.BIT_8_CAMERA) < 0)
                {
                    engineRunning = true;
                    Console.WriteLine("Camera Engine Started");
                    return true;
                }
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
            int fg = BufStartFrameGrab(totalFrames);
            Console.WriteLine(String.Format("Starting Frame Grab. {2} Frames. {0} {1}", fh, fh, totalFrames));
        }
        public void StopFrameGrab()
        {
            // Install frame call back.
            int fh = BufInstallFrameHooker(1, null); // BMP data
            Console.WriteLine(String.Format("Stopping Frame Grab {0}", fh));
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

        
          /*************************************/
         //Memory Mangment & Buffer Processing//
        /*************************************/
        public IntPtr AllocImageMem(int size)
        {
            return Marshal.AllocHGlobal(size);
        }
        public void FreeImageMem(IntPtr image)
        {
            if (imagePointer != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(image);
            }
        }
        public void FrameCallback( ref ImageProperty imgProperty, IntPtr bufferPtr)
        {
            int id = imgProperty.CameraID-1;
            int width = imgProperty.Column;
            int height = imgProperty.Row;
            Console.WriteLine("Image Device:{0} {1}x{2}",id, width, height);
            
            Bitmap bmp = new Bitmap(width, height, width,PixelFormat.Format8bppIndexed, bufferPtr);
            bmp.Palette = palette;
            drawFrame(id, bmp);
            //bmp.Dispose();
        }
        public void drawFrame(int id, Bitmap data)
        {
            IntPtr hBitmap = data.GetHbitmap();
            try
            {
                Bitmap image = Image.FromHbitmap(hBitmap);
                image.Palette = palette; //remap the colors to 0-255 greyscale

                //Find the largest size we can make our image to fit the box, then crop the box to that size
                Size newSize = FindCommonSize(image.Size, p[id].Size);

                p[id].Size = newSize;
                p[id].Image = new Bitmap(image, newSize);
                
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