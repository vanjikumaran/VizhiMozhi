namespace SrilankanTamilFingerSpelling.GUI
{
    partial class frmMainInterFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainInterFace));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAddInstance = new System.Windows.Forms.Label();
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblRecognition = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::SrilankanTamilFingerSpelling.Properties.Resources.btnClose;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(918, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAddInstance
            // 
            this.lblAddInstance.AutoSize = true;
            this.lblAddInstance.BackColor = System.Drawing.Color.SteelBlue;
            this.lblAddInstance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddInstance.ForeColor = System.Drawing.Color.White;
            this.lblAddInstance.Location = new System.Drawing.Point(494, 41);
            this.lblAddInstance.Name = "lblAddInstance";
            this.lblAddInstance.Size = new System.Drawing.Size(90, 17);
            this.lblAddInstance.TabIndex = 1;
            this.lblAddInstance.Text = "Add Instance";
            this.lblAddInstance.Click += new System.EventHandler(this.lblAddInstance_Click);
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTrain.ForeColor = System.Drawing.Color.White;
            this.lblTrain.Location = new System.Drawing.Point(610, 41);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(41, 17);
            this.lblTrain.TabIndex = 2;
            this.lblTrain.Text = "Train";
            this.lblTrain.Click += new System.EventHandler(this.lblTrain_Click);
            // 
            // lblRecognition
            // 
            this.lblRecognition.AutoSize = true;
            this.lblRecognition.BackColor = System.Drawing.Color.SteelBlue;
            this.lblRecognition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecognition.ForeColor = System.Drawing.Color.White;
            this.lblRecognition.Location = new System.Drawing.Point(688, 41);
            this.lblRecognition.Name = "lblRecognition";
            this.lblRecognition.Size = new System.Drawing.Size(83, 17);
            this.lblRecognition.TabIndex = 3;
            this.lblRecognition.Text = "Recognition";
            this.lblRecognition.Click += new System.EventHandler(this.lblRecognition_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(804, 41);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(37, 17);
            this.lblHelp.TabIndex = 4;
            this.lblHelp.Text = "Help";
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.BackColor = System.Drawing.Color.SteelBlue;
            this.lblAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutUs.ForeColor = System.Drawing.Color.White;
            this.lblAboutUs.Location = new System.Drawing.Point(881, 41);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(66, 17);
            this.lblAboutUs.TabIndex = 5;
            this.lblAboutUs.Text = "About Us";
            this.lblAboutUs.Click += new System.EventHandler(this.lblAboutUs_Click);
            // 
            // frmMainInterFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SrilankanTamilFingerSpelling.Properties.Resources.MDI2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(959, 699);
            this.Controls.Add(this.lblAboutUs);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblRecognition);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.lblAddInstance);
            this.Controls.Add(this.btnClose);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainInterFace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainInterFace";
            this.Load += new System.EventHandler(this.frmMainInterFace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAddInstance;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblRecognition;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblAboutUs;
    }
}