namespace CCDApp
{
    partial class CCDAppMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.init = new System.Windows.Forms.Button();
            this.terminate = new System.Windows.Forms.Button();
            this.cameraActivationList = new System.Windows.Forms.CheckedListBox();
            this.ModeContainer = new System.Windows.Forms.GroupBox();
            this.ModeFlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.CameraModeContinuous = new System.Windows.Forms.RadioButton();
            this.CameraModeTrigger = new System.Windows.Forms.RadioButton();
            this.ResolutionContainer = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ExposureTimeContainer = new System.Windows.Forms.GroupBox();
            this.ExposureTimeInput = new System.Windows.Forms.TrackBar();
            this.ExposureTimeOoM = new System.Windows.Forms.ComboBox();
            this.ExposureTimeFlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.GainContainer = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stopCaptureButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ModeContainer.SuspendLayout();
            this.ModeFlowContainer.SuspendLayout();
            this.ResolutionContainer.SuspendLayout();
            this.ExposureTimeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExposureTimeInput)).BeginInit();
            this.GainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // init
            // 
            this.init.Location = new System.Drawing.Point(3, 3);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(75, 23);
            this.init.TabIndex = 0;
            this.init.Text = "Init";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // terminate
            // 
            this.terminate.Enabled = false;
            this.terminate.Location = new System.Drawing.Point(84, 3);
            this.terminate.Name = "terminate";
            this.terminate.Size = new System.Drawing.Size(75, 23);
            this.terminate.TabIndex = 1;
            this.terminate.Text = "Terminate";
            this.terminate.UseVisualStyleBackColor = true;
            this.terminate.Click += new System.EventHandler(this.terminate_Click);
            // 
            // cameraActivationList
            // 
            this.cameraActivationList.BackColor = System.Drawing.Color.White;
            this.cameraActivationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cameraActivationList.CheckOnClick = true;
            this.cameraActivationList.FormattingEnabled = true;
            this.cameraActivationList.Location = new System.Drawing.Point(3, 32);
            this.cameraActivationList.Name = "cameraActivationList";
            this.cameraActivationList.Size = new System.Drawing.Size(183, 15);
            this.cameraActivationList.TabIndex = 2;
            this.cameraActivationList.ThreeDCheckBoxes = true;
            this.cameraActivationList.SelectedIndexChanged += new System.EventHandler(this.cameraActivationList_SelectedIndexChanged);
            // 
            // ModeContainer
            // 
            this.ModeContainer.AutoSize = true;
            this.ModeContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModeContainer.Controls.Add(this.ModeFlowContainer);
            this.ModeContainer.Location = new System.Drawing.Point(6, 3);
            this.ModeContainer.Name = "ModeContainer";
            this.ModeContainer.Size = new System.Drawing.Size(160, 61);
            this.ModeContainer.TabIndex = 10;
            this.ModeContainer.TabStop = false;
            this.ModeContainer.Text = "Capture Mode";
            // 
            // ModeFlowContainer
            // 
            this.ModeFlowContainer.AutoSize = true;
            this.ModeFlowContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModeFlowContainer.Controls.Add(this.CameraModeContinuous);
            this.ModeFlowContainer.Controls.Add(this.CameraModeTrigger);
            this.ModeFlowContainer.Location = new System.Drawing.Point(6, 19);
            this.ModeFlowContainer.Name = "ModeFlowContainer";
            this.ModeFlowContainer.Size = new System.Drawing.Size(148, 23);
            this.ModeFlowContainer.TabIndex = 10;
            // 
            // CameraModeContinuous
            // 
            this.CameraModeContinuous.AutoSize = true;
            this.CameraModeContinuous.Checked = true;
            this.CameraModeContinuous.Location = new System.Drawing.Point(3, 3);
            this.CameraModeContinuous.Name = "CameraModeContinuous";
            this.CameraModeContinuous.Size = new System.Drawing.Size(78, 17);
            this.CameraModeContinuous.TabIndex = 9;
            this.CameraModeContinuous.TabStop = true;
            this.CameraModeContinuous.Text = "Continuous";
            this.CameraModeContinuous.UseVisualStyleBackColor = true;
            // 
            // CameraModeTrigger
            // 
            this.CameraModeTrigger.AutoSize = true;
            this.CameraModeTrigger.Enabled = false;
            this.CameraModeTrigger.Location = new System.Drawing.Point(87, 3);
            this.CameraModeTrigger.Name = "CameraModeTrigger";
            this.CameraModeTrigger.Size = new System.Drawing.Size(58, 17);
            this.CameraModeTrigger.TabIndex = 10;
            this.CameraModeTrigger.Text = "Trigger";
            this.CameraModeTrigger.UseVisualStyleBackColor = true;
            this.CameraModeTrigger.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ResolutionContainer
            // 
            this.ResolutionContainer.AutoSize = true;
            this.ResolutionContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResolutionContainer.Controls.Add(this.comboBox1);
            this.ResolutionContainer.Location = new System.Drawing.Point(206, 5);
            this.ResolutionContainer.Name = "ResolutionContainer";
            this.ResolutionContainer.Size = new System.Drawing.Size(133, 59);
            this.ResolutionContainer.TabIndex = 15;
            this.ResolutionContainer.TabStop = false;
            this.ResolutionContainer.Text = "Resolution";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "1280x960";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ExposureTimeContainer
            // 
            this.ExposureTimeContainer.AutoSize = true;
            this.ExposureTimeContainer.Controls.Add(this.ExposureTimeInput);
            this.ExposureTimeContainer.Controls.Add(this.ExposureTimeOoM);
            this.ExposureTimeContainer.Controls.Add(this.ExposureTimeFlowContainer);
            this.ExposureTimeContainer.Location = new System.Drawing.Point(6, 70);
            this.ExposureTimeContainer.Name = "ExposureTimeContainer";
            this.ExposureTimeContainer.Size = new System.Drawing.Size(333, 83);
            this.ExposureTimeContainer.TabIndex = 13;
            this.ExposureTimeContainer.TabStop = false;
            this.ExposureTimeContainer.Text = "Exposure Time";
            this.ExposureTimeContainer.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ExposureTimeInput
            // 
            this.ExposureTimeInput.BackColor = System.Drawing.Color.White;
            this.ExposureTimeInput.Location = new System.Drawing.Point(6, 19);
            this.ExposureTimeInput.Maximum = 50;
            this.ExposureTimeInput.Name = "ExposureTimeInput";
            this.ExposureTimeInput.Size = new System.Drawing.Size(263, 45);
            this.ExposureTimeInput.TabIndex = 8;
            this.ExposureTimeInput.Value = 15;
            // 
            // ExposureTimeOoM
            // 
            this.ExposureTimeOoM.FormattingEnabled = true;
            this.ExposureTimeOoM.Items.AddRange(new object[] {
            "10ms",
            "100ms",
            "500ms",
            "1s",
            "10s"});
            this.ExposureTimeOoM.Location = new System.Drawing.Point(275, 19);
            this.ExposureTimeOoM.Name = "ExposureTimeOoM";
            this.ExposureTimeOoM.Size = new System.Drawing.Size(52, 21);
            this.ExposureTimeOoM.TabIndex = 12;
            this.ExposureTimeOoM.Text = "100ms";
            // 
            // ExposureTimeFlowContainer
            // 
            this.ExposureTimeFlowContainer.AutoSize = true;
            this.ExposureTimeFlowContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExposureTimeFlowContainer.Location = new System.Drawing.Point(17, 19);
            this.ExposureTimeFlowContainer.Name = "ExposureTimeFlowContainer";
            this.ExposureTimeFlowContainer.Size = new System.Drawing.Size(0, 0);
            this.ExposureTimeFlowContainer.TabIndex = 11;
            // 
            // GainContainer
            // 
            this.GainContainer.Controls.Add(this.textBox1);
            this.GainContainer.Controls.Add(this.trackBar1);
            this.GainContainer.Controls.Add(this.flowLayoutPanel5);
            this.GainContainer.Location = new System.Drawing.Point(6, 165);
            this.GainContainer.Name = "GainContainer";
            this.GainContainer.Size = new System.Drawing.Size(333, 85);
            this.GainContainer.TabIndex = 14;
            this.GainContainer.TabStop = false;
            this.GainContainer.Text = "Gain";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "8dB";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(263, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 20;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(17, 19);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel5.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.cameraActivationList);
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 361);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.init);
            this.flowLayoutPanel2.Controls.Add(this.terminate);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 305);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stopCaptureButton);
            this.tabPage1.Controls.Add(this.captureButton);
            this.tabPage1.Controls.Add(this.ModeContainer);
            this.tabPage1.Controls.Add(this.ResolutionContainer);
            this.tabPage1.Controls.Add(this.GainContainer);
            this.tabPage1.Controls.Add(this.ExposureTimeContainer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Camera Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // stopCaptureButton
            // 
            this.stopCaptureButton.Location = new System.Drawing.Point(87, 256);
            this.stopCaptureButton.Name = "stopCaptureButton";
            this.stopCaptureButton.Size = new System.Drawing.Size(75, 23);
            this.stopCaptureButton.TabIndex = 17;
            this.stopCaptureButton.Text = "Stop Capture";
            this.stopCaptureButton.UseVisualStyleBackColor = true;
            this.stopCaptureButton.Click += new System.EventHandler(this.stopCaptureButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(6, 256);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 16;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Capture Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(894, 1028);
            this.flowLayoutPanel6.TabIndex = 6;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(3, 509);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 500);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel3.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(380, 8);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(506, 1012);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // CCDAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 767);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Name = "CCDAppMain";
            this.Text = "Multiple CCD Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExit);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ModeContainer.ResumeLayout(false);
            this.ModeContainer.PerformLayout();
            this.ModeFlowContainer.ResumeLayout(false);
            this.ModeFlowContainer.PerformLayout();
            this.ResolutionContainer.ResumeLayout(false);
            this.ExposureTimeContainer.ResumeLayout(false);
            this.ExposureTimeContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExposureTimeInput)).EndInit();
            this.GainContainer.ResumeLayout(false);
            this.GainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button init;
        private System.Windows.Forms.Button terminate;
        private System.Windows.Forms.CheckedListBox cameraActivationList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox ModeContainer;
        private System.Windows.Forms.RadioButton CameraModeContinuous;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox ExposureTimeContainer;
        private System.Windows.Forms.FlowLayoutPanel ExposureTimeFlowContainer;
        private System.Windows.Forms.TrackBar ExposureTimeInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.ComboBox ExposureTimeOoM;
        private System.Windows.Forms.GroupBox GainContainer;
        private System.Windows.Forms.FlowLayoutPanel ModeFlowContainer;
        private System.Windows.Forms.RadioButton CameraModeTrigger;
        private System.Windows.Forms.GroupBox ResolutionContainer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button stopCaptureButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

