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
            FlowLayoutPanel flp = new FlowLayoutPanel
            {
                Text = name,
                FlowDirection = FlowDirection.TopDown,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                AutoSize = true,
            };

            PictureBox pb = new PictureBox
            {
            };

            CamInterface.AssignPictureBox(id, pb);

            flp.Controls.Add(pb);
            parent.Controls.Add(flp);
        }

        private void CreateCameraSettingsList(Control parent,string name, int id)
        {

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

            GroupBox gbExposureTime = new GroupBox
            {
                Text = "Exposure Time",
                Size = groupboxSize,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowOnly,
            };
            GroupBox gbGain = new GroupBox
            {
                Text = "Gain",
                Size = groupboxSize,
            };
            GroupBox gbResolution = new GroupBox
            {
                Text = "Resolution",
                Size = groupboxSize,
            };

            TrackBar tbExposureTime = new TrackBar
            {
                Size = trackbarSize,
                Location = new Point(10, 30),
            };

            tp.Controls.Add(flp);

            flp.Controls.Add(gbExposureTime);
            flp.Controls.Add(gbGain);
            flp.Controls.Add(gbResolution);

            gbExposureTime.Controls.Add(tbExposureTime);
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
            //Application.ExitThread();
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
    }
}
