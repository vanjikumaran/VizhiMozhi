namespace SrilankanTamilFingerSpelling.GUI
{
    partial class frmRegognition
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
            this.picSourceImage = new System.Windows.Forms.PictureBox();
            this.webCam = new WebCamUserController.WebCamVirtualDevice();
            this.lblResult = new System.Windows.Forms.Label();
            this.WordCreatorTimer = new System.Windows.Forms.Timer(this.components);
            this.WordCreatorTimer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSourceImage
            // 
            this.picSourceImage.Location = new System.Drawing.Point(25, 21);
            this.picSourceImage.Name = "picSourceImage";
            this.picSourceImage.Size = new System.Drawing.Size(350, 350);
            this.picSourceImage.TabIndex = 0;
            this.picSourceImage.TabStop = false;
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
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Red;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblResult.Location = new System.Drawing.Point(164, 290);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 52);
            this.lblResult.TabIndex = 22;
            // 
            // WordCreatorTimer
            // 
            this.WordCreatorTimer.Enabled = true;
            this.WordCreatorTimer.Interval = 350;
            this.WordCreatorTimer.Tick += new System.EventHandler(this.WordCreatorTimer_Tick);
            // 
            // WordCreatorTimer2
            // 
            this.WordCreatorTimer2.Enabled = true;
            this.WordCreatorTimer2.Interval = 355;
            this.WordCreatorTimer2.Tick += new System.EventHandler(this.WordCreatorTimer2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(232, 390);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(492, 142);
            this.textBox1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.picSourceImage);
            this.groupBox1.Location = new System.Drawing.Point(275, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 384);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Stream";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(843, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 25;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmRegognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SrilankanTamilFingerSpelling.Properties.Resources.MDIChild;
            this.ClientSize = new System.Drawing.Size(930, 539);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 89);
            this.Name = "frmRegognition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Srilankan Tamil Finger Spelling :: Regognition Phase";
            this.Load += new System.EventHandler(this.frmRegognition_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegognition_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSourceImage;
        private WebCamUserController.WebCamVirtualDevice webCam;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer WordCreatorTimer;
        private System.Windows.Forms.Timer WordCreatorTimer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}