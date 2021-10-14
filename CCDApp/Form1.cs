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

            PictureBox[] ps = { pictureBox1, pictureBox2 };

            CamInterface = new USBCamInterface(this.Handle, ps);
            CameraStartup();
            
        }
        private void CreateCameraSettingsList(Control parent, string name)
        {

            GroupBox gb = new GroupBox();
            gb.Text = name;
            gb.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gb.AutoSize = true;
            parent.Controls.Add(gb);


            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Text = name;
            flp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flp.AutoSize = true;
            flp.Location = new Point(20, 20);
            gb.Controls.Add(flp);


            Button b = new Button();
            b.Text = "button1";
            b.Size = new Size(200, 45);
            b.Visible = true;
            flp.Controls.Add(b);
            b.BringToFront();
        }

        private void init_Click(object sender, EventArgs e)
        {
            CameraStartup();
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
                CreateCameraSettingsList(this.captureSettingsFlowContainer, cameraList[i]);
            }
        }

        private void terminate_Click(object sender, EventArgs e)
        {
            if (CamInterface.Terminate())
            {
                terminate.Enabled = false;
                init.Enabled = true;
            }
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
        private void stopCaptureButton_Click(object sender, EventArgs e)
        {
            captureButton.Enabled = true;
            stopCaptureButton.Enabled = false;
            CamInterface.StopFrameGrab();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExposureTimeInput_Scroll(object sender, EventArgs e)
        {
            exposureTimeFineControl.Value = (decimal)ExposureTimeInput.Value;
        }

        private void exposureTimeFineControl_ValueChanged(object sender, EventArgs e)
        {
            ExposureTimeInput.Value = (int)exposureTimeFineControl.Value;
            UpdateExposureTime();
        }

        private void exposureTimeOoMControl_ValueChanged(object sender, EventArgs e)
        {
            exposureTimeFineControl.Value = 0;
            ExposureTimeInput.Value = 0;
            UpdateExposureTime();
        }

        private void gainControlInput_Scroll(object sender, EventArgs e)
        {
            gainControl.Value = (decimal)gainControlInput.Value;
        }
        private void gainControl_ValueChanged(object sender, EventArgs e)
        {
            gainControlInput.Value = (int)gainControl.Value;
            UpdateGain();
        }

        private void UpdateExposureTime()
        {
            double expTimeMs = (double)exposureTimeFineControl.Value * Math.Pow(10.0, (double)exposureTimeOoMControl.Value + 3);
            CamInterface.SetExposureTime(expTimeMs);
        }
        private void UpdateGain()
        {
            int gain = (int)gainControl.Value;
            CamInterface.SetGain(gain);
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
