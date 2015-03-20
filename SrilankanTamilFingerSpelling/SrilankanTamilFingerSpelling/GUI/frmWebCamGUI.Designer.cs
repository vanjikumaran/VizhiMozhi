namespace SrilankanTamilFingerSpelling.GUI
{
    partial class frmWebCamGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebCamGUI));
            this.picSource = new System.Windows.Forms.PictureBox();
            this.webCam = new WebCamUserController.WebCamVirtualDevice();
            this.MotionDetectionTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cboAplhabet = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.AddInstanceToFileTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSource
            // 
            this.picSource.Location = new System.Drawing.Point(25, 21);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(350, 350);
            this.picSource.TabIndex = 0;
            this.picSource.TabStop = false;
            // 
            // webCam
            // 
            this.webCam.CaptureHeight = 240;
            this.webCam.CaptureWidth = 320;
            this.webCam.FrameNumber = ((ulong)(0ul));
            this.webCam.Location = new System.Drawing.Point(0, 0);
            this.webCam.Name = "WebCamVirtualDevice";
            this.webCam.Size = new System.Drawing.Size(342, 252);
            this.webCam.TabIndex = 0;
            this.webCam.TimeToCapture_milliseconds = 100;
            this.webCam.ImageCaptured += new WebCamUserController.WebCamVirtualDevice.WebCamEventHandler(this.webCamera_ImageCaptured);
            // 
            // MotionDetectionTimer
            // 
            this.MotionDetectionTimer.Enabled = true;
            this.MotionDetectionTimer.Interval = 333;
            this.MotionDetectionTimer.Tick += new System.EventHandler(this.MotionDetectionTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboAplhabet
            // 
            this.cboAplhabet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAplhabet.FormattingEnabled = true;
            this.cboAplhabet.Location = new System.Drawing.Point(143, 38);
            this.cboAplhabet.Name = "cboAplhabet";
            this.cboAplhabet.Size = new System.Drawing.Size(174, 32);
            this.cboAplhabet.TabIndex = 4;
            this.cboAplhabet.SelectedIndexChanged += new System.EventHandler(this.cboAplhabet_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(143, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 38);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddInstanceToFileTimer
            // 
            this.AddInstanceToFileTimer.Interval = 333;
            this.AddInstanceToFileTimer.Tick += new System.EventHandler(this.AddInstanceToFileTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboAplhabet);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(305, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 179);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tamil Gylph";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(861, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.picSource);
            this.groupBox2.Location = new System.Drawing.Point(275, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 384);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Stream";
            // 
            // frmWebCamGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SrilankanTamilFingerSpelling.Properties.Resources.MDIChild;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(948, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 89);
            this.Name = "frmWebCamGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Srilankan Tamil Finger Spelling :: Recoding the Instance";
            this.Load += new System.EventHandler(this.frmWebCamGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSource;
        private WebCamUserController.WebCamVirtualDevice webCam;
        private System.Windows.Forms.Timer MotionDetectionTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboAplhabet;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer AddInstanceToFileTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}