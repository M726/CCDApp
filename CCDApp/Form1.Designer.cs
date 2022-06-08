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
            this.cameraSettingsTabPage = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.captureButton = new System.Windows.Forms.Button();
            this.stopCaptureButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserOpen = new System.Windows.Forms.Button();
            this.gbCaptureButton = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frameCountSelector = new System.Windows.Forms.NumericUpDown();
            this.captureActivate = new System.Windows.Forms.Button();
            this.gbImageCapture = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cameraTabControl = new System.Windows.Forms.TabControl();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.cameraDisplayBox = new System.Windows.Forms.FlowLayoutPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.cameraSettingsTabPage.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCaptureButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameCountSelector)).BeginInit();
            this.gbImageCapture.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
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
            this.cameraActivationList.Location = new System.Drawing.Point(3, 3);
            this.cameraActivationList.Name = "cameraActivationList";
            this.cameraActivationList.Size = new System.Drawing.Size(186, 15);
            this.cameraActivationList.TabIndex = 2;
            this.cameraActivationList.ThreeDCheckBoxes = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.cameraSettingsTabPage);
            this.flowLayoutPanel1.Controls.Add(this.cameraTabControl);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 710);
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
            // cameraSettingsTabPage
            // 
            this.cameraSettingsTabPage.Controls.Add(this.tabPage3);
            this.cameraSettingsTabPage.Controls.Add(this.tabPage2);
            this.cameraSettingsTabPage.Location = new System.Drawing.Point(3, 32);
            this.cameraSettingsTabPage.Name = "cameraSettingsTabPage";
            this.cameraSettingsTabPage.SelectedIndex = 0;
            this.cameraSettingsTabPage.Size = new System.Drawing.Size(360, 240);
            this.cameraSettingsTabPage.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.gbCaptureButton);
            this.tabPage3.Controls.Add(this.gbImageCapture);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(352, 214);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Camera Startup";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 59);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.captureButton);
            this.flowLayoutPanel4.Controls.Add(this.stopCaptureButton);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(172, 19);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(3, 3);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 18;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // stopCaptureButton
            // 
            this.stopCaptureButton.Enabled = false;
            this.stopCaptureButton.Location = new System.Drawing.Point(84, 3);
            this.stopCaptureButton.Name = "stopCaptureButton";
            this.stopCaptureButton.Size = new System.Drawing.Size(75, 23);
            this.stopCaptureButton.TabIndex = 19;
            this.stopCaptureButton.Text = "Stop Capture";
            this.stopCaptureButton.UseVisualStyleBackColor = true;
            this.stopCaptureButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.folderTextBox);
            this.groupBox1.Controls.Add(this.folderBrowserOpen);
            this.groupBox1.Location = new System.Drawing.Point(6, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 52);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Directory";
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(9, 19);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(296, 20);
            this.folderTextBox.TabIndex = 4;
            this.folderTextBox.TextChanged += new System.EventHandler(this.saveDirectoryChanged);
            // 
            // folderBrowserOpen
            // 
            this.folderBrowserOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.folderBrowserOpen.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderBrowserOpen.Location = new System.Drawing.Point(311, 17);
            this.folderBrowserOpen.Name = "folderBrowserOpen";
            this.folderBrowserOpen.Size = new System.Drawing.Size(23, 23);
            this.folderBrowserOpen.TabIndex = 3;
            this.folderBrowserOpen.Text = "...";
            this.folderBrowserOpen.UseVisualStyleBackColor = true;
            this.folderBrowserOpen.Click += new System.EventHandler(this.folderBrowserOpen_Click);
            // 
            // gbCaptureButton
            // 
            this.gbCaptureButton.Controls.Add(this.label1);
            this.gbCaptureButton.Controls.Add(this.frameCountSelector);
            this.gbCaptureButton.Controls.Add(this.captureActivate);
            this.gbCaptureButton.Location = new System.Drawing.Point(220, 129);
            this.gbCaptureButton.Name = "gbCaptureButton";
            this.gbCaptureButton.Size = new System.Drawing.Size(126, 76);
            this.gbCaptureButton.TabIndex = 10;
            this.gbCaptureButton.TabStop = false;
            this.gbCaptureButton.Text = "Capture Activation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frames:";
            // 
            // frameCountSelector
            // 
            this.frameCountSelector.Location = new System.Drawing.Point(56, 17);
            this.frameCountSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frameCountSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.frameCountSelector.Name = "frameCountSelector";
            this.frameCountSelector.Size = new System.Drawing.Size(64, 20);
            this.frameCountSelector.TabIndex = 1;
            this.frameCountSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // captureActivate
            // 
            this.captureActivate.Location = new System.Drawing.Point(9, 45);
            this.captureActivate.Name = "captureActivate";
            this.captureActivate.Size = new System.Drawing.Size(111, 23);
            this.captureActivate.TabIndex = 0;
            this.captureActivate.Text = "Start Capture";
            this.captureActivate.UseVisualStyleBackColor = true;
            this.captureActivate.Click += new System.EventHandler(this.captureActivate_Click);
            // 
            // gbImageCapture
            // 
            this.gbImageCapture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbImageCapture.Controls.Add(this.flowLayoutPanel3);
            this.gbImageCapture.Location = new System.Drawing.Point(6, 129);
            this.gbImageCapture.Name = "gbImageCapture";
            this.gbImageCapture.Size = new System.Drawing.Size(208, 77);
            this.gbImageCapture.TabIndex = 9;
            this.gbImageCapture.TabStop = false;
            this.gbImageCapture.Text = "Camera Selection";
            this.gbImageCapture.Enter += new System.EventHandler(this.gbImageCapture_Enter);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.cameraActivationList);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(196, 54);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Processing Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cameraTabControl
            // 
            this.cameraTabControl.Location = new System.Drawing.Point(3, 278);
            this.cameraTabControl.MinimumSize = new System.Drawing.Size(360, 0);
            this.cameraTabControl.Name = "cameraTabControl";
            this.cameraTabControl.SelectedIndex = 0;
            this.cameraTabControl.Size = new System.Drawing.Size(360, 429);
            this.cameraTabControl.TabIndex = 8;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel6.Controls.Add(this.cameraDisplayBox);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(398, 726);
            this.flowLayoutPanel6.TabIndex = 6;
            // 
            // cameraDisplayBox
            // 
            this.cameraDisplayBox.AutoSize = true;
            this.cameraDisplayBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cameraDisplayBox.BackColor = System.Drawing.Color.Transparent;
            this.cameraDisplayBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.cameraDisplayBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cameraDisplayBox.Location = new System.Drawing.Point(380, 8);
            this.cameraDisplayBox.MinimumSize = new System.Drawing.Size(10, 10);
            this.cameraDisplayBox.Name = "cameraDisplayBox";
            this.cameraDisplayBox.Size = new System.Drawing.Size(10, 10);
            this.cameraDisplayBox.TabIndex = 7;
            // 
            // CCDAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 773);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Name = "CCDAppMain";
            this.Text = "Multiple CCD Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExit);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.cameraSettingsTabPage.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCaptureButton.ResumeLayout(false);
            this.gbCaptureButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameCountSelector)).EndInit();
            this.gbImageCapture.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
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
        private System.Windows.Forms.TabControl cameraSettingsTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel cameraDisplayBox;
        private System.Windows.Forms.TabControl cameraTabControl;
        private System.Windows.Forms.Button stopCaptureButton;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.GroupBox gbImageCapture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.GroupBox gbCaptureButton;
        private System.Windows.Forms.NumericUpDown frameCountSelector;
        private System.Windows.Forms.Button captureActivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button folderBrowserOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

