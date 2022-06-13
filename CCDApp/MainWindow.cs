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

            RbCaptureModeTrigger.CheckedChanged += delegate
            {
                if (RbCaptureModeTrigger.Checked)
                    CamInterface.SetContinuousMode(false);
            };
            RbCaptureModeContinuous.CheckedChanged += delegate {
                if (RbCaptureModeContinuous.Checked)
                    CamInterface.SetContinuousMode(true);
            };

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
                cameraActivationList.SetItemChecked(i, true);
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
                Padding = new Padding(5),
            };

            FlowLayoutPanel flp = new FlowLayoutPanel
            {
                Location = new Point(70, 70),
                Text = name,
                FlowDirection = FlowDirection.TopDown,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                AutoSize = true,
            };

            PictureBox pb = new PictureBox
            {
                Margin = new Padding(5,5,5,0),
                Location = new Point(10,15),
            };

            CamInterface.AssignPictureBox(id, pb);

            gb.Controls.Add(pb);
            flp.Controls.Add(gb);
            parent.Controls.Add(flp);
        }

        private void CreateCameraSettingsList(TabControl parent,string name, int id)
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


            ///////
            //DisplayName

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
                Text = String.Format("Camera{0}", id+1),
            };

            tbDisplayName.KeyPress += delegate
            {
                CamInterface.SetDisplayName(tbDisplayName.Text, id);
            };

            flpDisplayName.Controls.Add(tbDisplayName);
            gbDisplayName.Controls.Add(flpDisplayName);
            flp.Controls.Add(gbDisplayName);

            CamInterface.SetDisplayName(tbDisplayName.Text, id);

            ///////
            //Resolution
            GroupBox gbResolution = new GroupBox
            {
                Text = "Resolution",
                Size = groupboxSize,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,

            };
            FlowLayoutPanel flpResolution = new FlowLayoutPanel
            {
                Location = flpInternalLocation,
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
            };

            RadioButton rbResolution1280x960 = new RadioButton
            {
                Text = "1280 x 960",
                AutoSize = true,
                Checked = true,
            };
            RadioButton rbResolution640x480 = new RadioButton
            {
                Text = "640 x 480 (1:2 Bin)",
                AutoSize = true,
            };
            RadioButton rbResolution424x320 = new RadioButton
            {
                Text = "424 x 320 (1:3 Bin)",
                AutoSize = true,
            };
            RadioButton rbResolution320x240 = new RadioButton
            {
                Text = "320 x 240 (1:4 Bin)",
                AutoSize = true,
            };
            RadioButton rbResolution320x240Bin2 = new RadioButton
            {
                Text = "320 x 240 (1:4 Bin2)",
                AutoSize = true,
            };
            rbResolution1280x960.CheckedChanged += new EventHandler((sender, e) => ResolutionChange(USBCamInterface.ResolutionType.reolution1280x960, id));
            rbResolution640x480.CheckedChanged += new EventHandler((sender, e) => ResolutionChange(USBCamInterface.ResolutionType.reolution640x480, id));
            rbResolution424x320.CheckedChanged += new EventHandler((sender, e) => ResolutionChange(USBCamInterface.ResolutionType.reolution424x320, id));
            rbResolution320x240.CheckedChanged += new EventHandler((sender, e) => ResolutionChange(USBCamInterface.ResolutionType.reolution320x240, id));
            rbResolution320x240Bin2.CheckedChanged += new EventHandler((sender, e) => ResolutionChange(USBCamInterface.ResolutionType.reolution320x240bin2, id));

            flpResolution.Controls.Add(rbResolution1280x960);
            flpResolution.Controls.Add(rbResolution640x480);
            flpResolution.Controls.Add(rbResolution424x320);
            flpResolution.Controls.Add(rbResolution320x240);
            flpResolution.Controls.Add(rbResolution320x240Bin2);

            gbResolution.Controls.Add(flpResolution);
            flp.Controls.Add(gbResolution);

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
                Margin = new Padding(0),
                Padding = new Padding(0),
            };
            TrackBar tbExposureTime = new TrackBar
            {
                Size = trackbarSize,
                Maximum = 100,
                Minimum = 1,
                Value = (int)CamInterface.GetExposureTime(id),
                Margin = new Padding(0),
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
                Value = CamInterface.GetGain(id),
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


            


            //Add Exposure Time Controls
            gbResolution.Controls.Add(flpResolution);
            flp.Controls.Add(gbResolution);


            tp.Controls.Add(flp);


        }

        private void ResolutionChange(USBCamInterface.ResolutionType resolution, int id)
        {
            CamInterface.SetResolution(resolution, id);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void FormExit(object sender, FormClosingEventArgs e)
        {
            CamInterface.Terminate();
            //Environment.Exit(Environment.ExitCode);

        }
        private void CaptureButton_Click(object sender, EventArgs e)
        {
            captureButton.Enabled = false;
            stopCaptureButton.Enabled = true;
            CamInterface.StartFrameGrab(0x8888);
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            captureButton.Enabled = true;
            stopCaptureButton.Enabled = false;
            CamInterface.StopFrameGrab();
        }

        private void GbImageCapture_Enter(object sender, EventArgs e)
        {

        }

        private void FolderBrowserOpen_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            Console.WriteLine(dr.ToString());
            if(dr == DialogResult.OK)
            {
                folderTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void SaveDirectoryChanged(object sender, EventArgs e)
        {
            CamInterface.path = folderTextBox.Text;
        }

        private void CaptureActivate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cameraActivationList.Items.Count; i++)
            {
                if (cameraActivationList.GetItemChecked(i))
                {
                    CamInterface.CaptureFrames(i, (int)Math.Round(frameCountSelector.Value), folderTextBox.Text);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TriggerConfigurationWindow tcw = new TriggerConfigurationWindow();
            tcw.Show();
        }
    }
}
