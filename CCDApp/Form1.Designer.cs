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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cameraTabControl = new System.Windows.Forms.TabControl();
            this.cameraSettingsTemplate = new System.Windows.Forms.TabPage();
            this.stopCaptureButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.ModeContainer = new System.Windows.Forms.GroupBox();
            this.ModeFlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.CameraModeContinuous = new System.Windows.Forms.RadioButton();
            this.CameraModeTrigger = new System.Windows.Forms.RadioButton();
            this.ResolutionContainer = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GainContainer = new System.Windows.Forms.GroupBox();
            this.gainControl = new System.Windows.Forms.NumericUpDown();
            this.gainControlInput = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExposureTimeContainer = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exposureTimeOoMControl = new System.Windows.Forms.NumericUpDown();
            this.exposureTimeFineControl = new System.Windows.Forms.NumericUpDown();
            this.ExposureTimeInput = new System.Windows.Forms.TrackBar();
            this.ExposureTimeFlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cameraSettingsTemplate.SuspendLayout();
            this.ModeContainer.SuspendLayout();
            this.ModeFlowContainer.SuspendLayout();
            this.ResolutionContainer.SuspendLayout();
            this.GainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gainControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainControlInput)).BeginInit();
            this.ExposureTimeContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTimeOoMControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTimeFineControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExposureTimeInput)).BeginInit();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.cameraActivationList);
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Controls.Add(this.cameraTabControl);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 524);
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.cameraSettingsTemplate);
            this.tabControl1.Location = new System.Drawing.Point(3, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 305);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Processing Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.FileName = "$name$__$imageNumber$.bmp";
            this.saveFileDialog1.ValidateNames = false;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // cameraTabControl
            // 
            this.cameraTabControl.Location = new System.Drawing.Point(3, 364);
            this.cameraTabControl.MinimumSize = new System.Drawing.Size(360, 0);
            this.cameraTabControl.Name = "cameraTabControl";
            this.cameraTabControl.SelectedIndex = 0;
            this.cameraTabControl.Size = new System.Drawing.Size(360, 157);
            this.cameraTabControl.TabIndex = 8;
            // 
            // cameraSettingsTemplate
            // 
            this.cameraSettingsTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cameraSettingsTemplate.Controls.Add(this.stopCaptureButton);
            this.cameraSettingsTemplate.Controls.Add(this.captureButton);
            this.cameraSettingsTemplate.Controls.Add(this.ModeContainer);
            this.cameraSettingsTemplate.Controls.Add(this.ResolutionContainer);
            this.cameraSettingsTemplate.Controls.Add(this.GainContainer);
            this.cameraSettingsTemplate.Controls.Add(this.ExposureTimeContainer);
            this.cameraSettingsTemplate.Location = new System.Drawing.Point(4, 22);
            this.cameraSettingsTemplate.Name = "cameraSettingsTemplate";
            this.cameraSettingsTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.cameraSettingsTemplate.Size = new System.Drawing.Size(352, 279);
            this.cameraSettingsTemplate.TabIndex = 2;
            this.cameraSettingsTemplate.Text = "Camera Settings";
            this.cameraSettingsTemplate.UseVisualStyleBackColor = true;
            // 
            // stopCaptureButton
            // 
            this.stopCaptureButton.Enabled = false;
            this.stopCaptureButton.Location = new System.Drawing.Point(87, 256);
            this.stopCaptureButton.Name = "stopCaptureButton";
            this.stopCaptureButton.Size = new System.Drawing.Size(75, 23);
            this.stopCaptureButton.TabIndex = 17;
            this.stopCaptureButton.Text = "Stop Capture";
            this.stopCaptureButton.UseVisualStyleBackColor = true;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(6, 256);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 16;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
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
            // 
            // GainContainer
            // 
            this.GainContainer.Controls.Add(this.gainControl);
            this.GainContainer.Controls.Add(this.gainControlInput);
            this.GainContainer.Controls.Add(this.flowLayoutPanel5);
            this.GainContainer.Location = new System.Drawing.Point(6, 165);
            this.GainContainer.Name = "GainContainer";
            this.GainContainer.Size = new System.Drawing.Size(333, 85);
            this.GainContainer.TabIndex = 14;
            this.GainContainer.TabStop = false;
            this.GainContainer.Text = "Gain";
            // 
            // gainControl
            // 
            this.gainControl.Location = new System.Drawing.Point(244, 19);
            this.gainControl.Maximum = new decimal(new int[] {
            41,
            0,
            0,
            0});
            this.gainControl.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.gainControl.Name = "gainControl";
            this.gainControl.Size = new System.Drawing.Size(52, 20);
            this.gainControl.TabIndex = 13;
            this.gainControl.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // gainControlInput
            // 
            this.gainControlInput.BackColor = System.Drawing.Color.White;
            this.gainControlInput.Location = new System.Drawing.Point(6, 19);
            this.gainControlInput.Maximum = 41;
            this.gainControlInput.Minimum = 6;
            this.gainControlInput.Name = "gainControlInput";
            this.gainControlInput.Size = new System.Drawing.Size(232, 45);
            this.gainControlInput.TabIndex = 7;
            this.gainControlInput.Value = 15;
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
            // ExposureTimeContainer
            // 
            this.ExposureTimeContainer.AutoSize = true;
            this.ExposureTimeContainer.Controls.Add(this.label2);
            this.ExposureTimeContainer.Controls.Add(this.label1);
            this.ExposureTimeContainer.Controls.Add(this.exposureTimeOoMControl);
            this.ExposureTimeContainer.Controls.Add(this.exposureTimeFineControl);
            this.ExposureTimeContainer.Controls.Add(this.ExposureTimeInput);
            this.ExposureTimeContainer.Controls.Add(this.ExposureTimeFlowContainer);
            this.ExposureTimeContainer.Location = new System.Drawing.Point(6, 70);
            this.ExposureTimeContainer.Name = "ExposureTimeContainer";
            this.ExposureTimeContainer.Size = new System.Drawing.Size(333, 89);
            this.ExposureTimeContainer.TabIndex = 13;
            this.ExposureTimeContainer.TabStop = false;
            this.ExposureTimeContainer.Text = "Exposure Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "x 10^";
            // 
            // exposureTimeOoMControl
            // 
            this.exposureTimeOoMControl.BackColor = System.Drawing.SystemColors.Window;
            this.exposureTimeOoMControl.Location = new System.Drawing.Point(275, 25);
            this.exposureTimeOoMControl.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.exposureTimeOoMControl.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.exposureTimeOoMControl.Name = "exposureTimeOoMControl";
            this.exposureTimeOoMControl.Size = new System.Drawing.Size(35, 20);
            this.exposureTimeOoMControl.TabIndex = 13;
            this.exposureTimeOoMControl.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            // 
            // exposureTimeFineControl
            // 
            this.exposureTimeFineControl.Location = new System.Drawing.Point(199, 25);
            this.exposureTimeFineControl.Name = "exposureTimeFineControl";
            this.exposureTimeFineControl.Size = new System.Drawing.Size(39, 20);
            this.exposureTimeFineControl.TabIndex = 12;
            this.exposureTimeFineControl.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ExposureTimeInput
            // 
            this.ExposureTimeInput.BackColor = System.Drawing.Color.White;
            this.ExposureTimeInput.Location = new System.Drawing.Point(6, 25);
            this.ExposureTimeInput.Maximum = 100;
            this.ExposureTimeInput.Name = "ExposureTimeInput";
            this.ExposureTimeInput.Size = new System.Drawing.Size(187, 45);
            this.ExposureTimeInput.TabIndex = 8;
            this.ExposureTimeInput.TickFrequency = 5;
            this.ExposureTimeInput.Value = 50;
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cameraSettingsTemplate.ResumeLayout(false);
            this.cameraSettingsTemplate.PerformLayout();
            this.ModeContainer.ResumeLayout(false);
            this.ModeContainer.PerformLayout();
            this.ModeFlowContainer.ResumeLayout(false);
            this.ModeFlowContainer.PerformLayout();
            this.ResolutionContainer.ResumeLayout(false);
            this.GainContainer.ResumeLayout(false);
            this.GainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gainControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gainControlInput)).EndInit();
            this.ExposureTimeContainer.ResumeLayout(false);
            this.ExposureTimeContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTimeOoMControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTimeFineControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExposureTimeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button init;
        private System.Windows.Forms.Button terminate;
        private System.Windows.Forms.CheckedListBox cameraActivationList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl cameraTabControl;
        private System.Windows.Forms.TabPage cameraSettingsTemplate;
        private System.Windows.Forms.Button stopCaptureButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.GroupBox ModeContainer;
        private System.Windows.Forms.FlowLayoutPanel ModeFlowContainer;
        private System.Windows.Forms.RadioButton CameraModeContinuous;
        private System.Windows.Forms.RadioButton CameraModeTrigger;
        private System.Windows.Forms.GroupBox ResolutionContainer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox GainContainer;
        private System.Windows.Forms.NumericUpDown gainControl;
        private System.Windows.Forms.TrackBar gainControlInput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.GroupBox ExposureTimeContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown exposureTimeOoMControl;
        private System.Windows.Forms.NumericUpDown exposureTimeFineControl;
        private System.Windows.Forms.TrackBar ExposureTimeInput;
        private System.Windows.Forms.FlowLayoutPanel ExposureTimeFlowContainer;
    }
}

