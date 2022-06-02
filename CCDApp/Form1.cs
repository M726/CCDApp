using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCDApp
{
    public partial class CCDAppMain : Form
    {
        public USBCamInterface CamInterface;
        public CCDAppMain()
        {
            InitializeComponent();
            this.Shown += Setup;
        }

        private void Setup(Object o, EventArgs e)
        {
            //First time Setup 
            
            CamInterface = new USBCamInterface(this.Handle);
            CameraStartup();
            
        }

        private void init_Click(object sender, EventArgs e)
        {
            CameraStartup();
        }

        private void terminate_Click(object sender, EventArgs e)
        {
            if (CamInterface.Terminate())
            {
                terminate.Enabled = false;
                init.Enabled = true;

                this.cameraTabControl.Controls.Clear();
                this.cameraDisplayBox.Controls.Clear();
            }
        }
        private void CameraStartup() {
            CamInterface.Init();
            CamInterface.StartEngine();

            terminate.Enabled = true;
            init.Enabled = false;
            string[] cameraList = CamInterface.getDevices();

            cameraActivationList.Items.Clear();

            cameraActivationList.Items.AddRange(cameraList);
            cameraActivationList.Height = 15 * cameraList.Length;


            for (int i = 0; i < cameraList.Length; i++)
            {
                //TODO: need to remove these on termination so there arent duplicates
                //CreateCameraSettingsList(this.captureSettingsFlowContainer, cameraList[i]);
                CreateCameraSettingsList(this.cameraTabControl,cameraList[i], i);
                CreateCameraDisplay(this.cameraDisplayBox, cameraList[i], i);
            }
        }

        private void CreateCameraDisplay(Control parent, string name, int id)
        {
            GroupBox gb = new GroupBox
            {
                Text = name,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(10),
            };

            FlowLayoutPanel flp = new FlowLayoutPanel
            {
                Text = name,
                FlowDirection = FlowDirection.TopDown,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                AutoSize = true,
            };

            PictureBox pb = new PictureBox();

            CamInterface.AssignPictureBox(id, pb);

            flp.Controls.Add(pb);
            parent.Controls.Add(flp);
        }

        private void CreateCameraSettingsList(Control parent,string name, int id)
        {
            Point flpInternalLocation = new Point(2, 20);
            Size groupboxSize = new Size(250, 40);
            Size trackbarSize = new Size(250, 40);
            TabPage tp = new TabPage();
            tp.Text = name;
            tp.BackColor = Color.White;
            parent.Controls.Add(tp);
            
            FlowLayoutPanel flp = new FlowLayoutPanel
            {
                Text = name,
                FlowDirection = FlowDirection.TopDown,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                AutoSize = true,
                Location = new Point(0, 0)
            };

            GroupBox gbDisplayName = new GroupBox
            {
                Text = "Display Name",
                Size = groupboxSize,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowOnly,
            };
            FlowLayoutPanel flpDisplayName = new FlowLayoutPanel
            {
                Location = flpInternalLocation,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };
            TextBox tbDisplayName = new TextBox
            {
                
            };
            tbDisplayName.KeyPress += delegate
            {
                CamInterface.SetDisplayName(tbDisplayName.Text, id);
            };

            flpDisplayName.Controls.Add(tbDisplayName);
            gbDisplayName.Controls.Add(flpDisplayName);
            flp.Controls.Add(gbDisplayName);


            ///////
            //Exposure Time
            GroupBox gbExposureTime = new GroupBox
            {
                Text = "Exposure Time",
                Size = groupboxSize,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowOnly,
                
            };
            FlowLayoutPanel flpExposureTime = new FlowLayoutPanel
            {
                Location = flpInternalLocation,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };

            TrackBar tbExposureTime = new TrackBar
            {
                Size = trackbarSize,
                Maximum = 100,
                Minimum = 1,
            };

            //Add Exposure Time Event Listener
            tbExposureTime.ValueChanged += (s, e) => {
                CamInterface.SetExposureTime((UInt32)tbExposureTime.Value, id);
                //Console.WriteLine((UInt32)tbExposureTime.Value); //Debug Show Exposure time value on change
            };

            //Add Exposure Time Controls
            flpExposureTime.Controls.Add(tbExposureTime);
            gbExposureTime.Controls.Add(flpExposureTime);
            flp.Controls.Add(gbExposureTime);

            ///////
            //Gain
            GroupBox gbGain = new GroupBox
            {
                Text = "Gain",
                Size = groupboxSize,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowOnly,

            };
            FlowLayoutPanel flpGain = new FlowLayoutPanel
            {
                Location = flpInternalLocation,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };

            TrackBar tbGain = new TrackBar
            {
                Size = trackbarSize,
                Minimum = 6,
                Maximum = 41,
            };

            //Add Gain Event Listener
            tbGain.ValueChanged += (s, e) => {
                CamInterface.SetGain(tbGain.Value, id);
                //Console.WriteLine((UInt32)tbExposureTime.Value); //Debug Show Exposure time value on change
            };

            //Add Gain Controls
            flpGain.Controls.Add(tbGain);
            gbGain.Controls.Add(flpGain);
            flp.Controls.Add(gbGain);


            
            ///////
            //Resolution
            GroupBox gbResolution = new GroupBox
            {
                Text = "Resolution",
                Size = groupboxSize,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowOnly,
                
            };
            FlowLayoutPanel flpResolution = new FlowLayoutPanel
            {
                Location = flpInternalLocation,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };


            //Add Exposure Time Controls
            gbResolution.Controls.Add(flpResolution);
            flp.Controls.Add(gbResolution);


            tp.Controls.Add(flp);


        }

        //check boxes changed for camera selection
        private void cameraActivationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        

        private void FormExit(object sender, FormClosingEventArgs e)
        {
            CamInterface.Terminate();
            //Environment.Exit(Environment.ExitCode);

        }
        private void captureButton_Click(object sender, EventArgs e)
        {
            captureButton.Enabled = false;
            stopCaptureButton.Enabled = true;
            CamInterface.StartFrameGrab(0x8888);
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            captureButton.Enabled = true;
            stopCaptureButton.Enabled = false;
            CamInterface.StopFrameGrab();
        }

        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Console.WriteLine(saveFileDialog1.FileName);
        }

        private void gbImageCapture_Enter(object sender, EventArgs e)
        {

        }
    }
}
