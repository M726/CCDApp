using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CCDApp
{
    public class CCDCamera
    {
        private string displayName = "";

        private int idx; //1,2,...
        private int row = 1280;
        private int column = 960;
        private int bin = 0;
        private int xStart = 0;
        private int yStart = 0;
        private UInt32 exposureTime = 1000; //250ms
        private int redGain = 0;
        private int greenGain = 15;
        private int blueGain = 0;
        private int mode = 0; //Raw or BMP

        private bool active = false;
        private string modelNumber;
        private string serialNumber;
        private bool debugMode = false;

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
                    
                    Console.WriteLine(String.Format("CCD{0} {1}{2} Initialized", idx, GetModelNumber(), GetSerialNumber()));
                    break;
                default:
                    break;
            }
        }

        public void SetDebugMode(bool debug)
        {
            debugMode = debug;
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
        public void SetResolution(int width, int height, int binMode)
        {
            //width = row size
            row = width;
            column = height;
            bin = binMode;


            int ret = UpdateResolution();

            DebugOutput("Setting Resolution: {0}x{1}: {2}",width,height, ret);
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

            int ret = UpdateGain();

            DebugOutput("Setting Gain: {0}db: {1}", gain, ret);
        }
        public void SetExposureTime(double expTimeMs)
        {
            //from 50us to 200,000ms mapped onto 1-4,000,000
            //increase of 1 = 50us
            UInt32 mappedExposureTime = (UInt32)Math.Round(20.0 * expTimeMs);
            exposureTime = mappedExposureTime;
            int ret = UpdateExposureTime();

            DebugOutput("Setting Exposure Time: {0}ms: {1}", expTimeMs, ret);
        }

        public void SetDisplayName(string name)
        {
            displayName = name;
        }

        public int UpdateMode()
        {
            return BufSetCameraWorkMode(idx, mode);
        }
        public int UpdateResolution()
        {
            return BufSetCustomizedResolution(idx, row, column, bin, 4);
        }
        public int UpdateStartPosition()
        {
            return BufSetStartPosition(idx, xStart, yStart);
        }
        public int UpdateGain()
        {
            return BufSetGains(idx, redGain, greenGain, blueGain);
            
        }
        public int UpdateExposureTime()
        {
            return BufSetExposureTime(idx, (int)exposureTime);
        }

        public string GetDisplayName()
        {
            return displayName;
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
            DebugOutput("Updating Camera {0}", idx);
            UpdateResolution();
            UpdateStartPosition();
            UpdateExposureTime();
            UpdateGain();
        }

        private void DebugOutput(string s, params object[] a)
        {
            if (debugMode)
            {
                Console.WriteLine(String.Format(s, a));
            }
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
}
