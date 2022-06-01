﻿namespace CCDApp
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
            this.stopCaptureButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.cameraTabControl = new System.Windows.Forms.TabControl();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.cameraDisplayBox = new System.Windows.Forms.FlowLayoutPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 486);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 147);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stopCaptureButton);
            this.tabPage2.Controls.Add(this.captureButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Processing Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stopCaptureButton
            // 
            this.stopCaptureButton.Enabled = false;
            this.stopCaptureButton.Location = new System.Drawing.Point(109, 31);
            this.stopCaptureButton.Name = "stopCaptureButton";
            this.stopCaptureButton.Size = new System.Drawing.Size(75, 23);
            this.stopCaptureButton.TabIndex = 19;
            this.stopCaptureButton.Text = "Stop Capture";
            this.stopCaptureButton.UseVisualStyleBackColor = true;
            this.stopCaptureButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(28, 31);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 18;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // cameraTabControl
            // 
            this.cameraTabControl.Location = new System.Drawing.Point(3, 206);
            this.cameraTabControl.MinimumSize = new System.Drawing.Size(360, 0);
            this.cameraTabControl.Name = "cameraTabControl";
            this.cameraTabControl.SelectedIndex = 0;
            this.cameraTabControl.Size = new System.Drawing.Size(360, 277);
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
            this.flowLayoutPanel6.Size = new System.Drawing.Size(488, 502);
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
            this.cameraDisplayBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.cameraDisplayBox.Name = "cameraDisplayBox";
            this.cameraDisplayBox.Size = new System.Drawing.Size(100, 100);
            this.cameraDisplayBox.TabIndex = 7;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.FileName = "$name$__$imageNumber$.bmp";
            this.saveFileDialog1.ValidateNames = false;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
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
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel cameraDisplayBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl cameraTabControl;
        private System.Windows.Forms.Button stopCaptureButton;
        private System.Windows.Forms.Button captureButton;
    }
}

