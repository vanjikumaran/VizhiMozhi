namespace SrilankanTamilFingerSpelling.GUI
{
    partial class frmTrainingSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrainingSession));
            this.picProcessedImage = new System.Windows.Forms.PictureBox();
            this.lblProcessPicture = new System.Windows.Forms.Label();
            this.lblOf = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboAplhabet = new System.Windows.Forms.ComboBox();
            this.txtCycles = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.progressTraining = new System.Windows.Forms.ProgressBar();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessedImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picProcessedImage
            // 
            this.picProcessedImage.Location = new System.Drawing.Point(32, 27);
            this.picProcessedImage.Name = "picProcessedImage";
            this.picProcessedImage.Size = new System.Drawing.Size(263, 251);
            this.picProcessedImage.TabIndex = 0;
            this.picProcessedImage.TabStop = false;
            // 
            // lblProcessPicture
            // 
            this.lblProcessPicture.AutoSize = true;
            this.lblProcessPicture.Location = new System.Drawing.Point(29, 335);
            this.lblProcessPicture.Name = "lblProcessPicture";
            this.lblProcessPicture.Size = new System.Drawing.Size(150, 17);
            this.lblProcessPicture.TabIndex = 1;
            this.lblProcessPicture.Text = "Select the Tamil Gylph";
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Location = new System.Drawing.Point(138, 295);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(46, 17);
            this.lblOf.TabIndex = 24;
            this.lblOf.Text = "label2";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(174, 376);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 36);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(78, 376);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(90, 36);
            this.btnPrevious.TabIndex = 22;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(174, 418);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(90, 35);
            this.btnRemoveAll.TabIndex = 19;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(78, 418);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 35);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboAplhabet
            // 
            this.cboAplhabet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.cboAplhabet.FormattingEnabled = true;
            this.cboAplhabet.Location = new System.Drawing.Point(188, 329);
            this.cboAplhabet.Name = "cboAplhabet";
            this.cboAplhabet.Size = new System.Drawing.Size(107, 32);
            this.cboAplhabet.TabIndex = 25;
            this.cboAplhabet.SelectedIndexChanged += new System.EventHandler(this.LoadLetter);
            // 
            // txtCycles
            // 
            this.txtCycles.Location = new System.Drawing.Point(71, 372);
            this.txtCycles.Name = "txtCycles";
            this.txtCycles.Size = new System.Drawing.Size(217, 22);
            this.txtCycles.TabIndex = 29;
            this.txtCycles.Text = "200";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(71, 413);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(217, 36);
            this.btnTrain.TabIndex = 28;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // progressTraining
            // 
            this.progressTraining.Location = new System.Drawing.Point(71, 325);
            this.progressTraining.Name = "progressTraining";
            this.progressTraining.Size = new System.Drawing.Size(217, 23);
            this.progressTraining.TabIndex = 27;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(71, 30);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(217, 244);
            this.lstLog.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lstLog);
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Controls.Add(this.txtCycles);
            this.groupBox1.Controls.Add(this.progressTraining);
            this.groupBox1.Location = new System.Drawing.Point(522, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 459);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Train Phase";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.picProcessedImage);
            this.groupBox2.Controls.Add(this.lblProcessPicture);
            this.groupBox2.Controls.Add(this.cboAplhabet);
            this.groupBox2.Controls.Add(this.lblOf);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnRemoveAll);
            this.groupBox2.Controls.Add(this.btnPrevious);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 463);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Training Set";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(828, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 36);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTrainingSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SrilankanTamilFingerSpelling.Properties.Resources.MDIChild;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(930, 539);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 89);
            this.Name = "frmTrainingSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Srilankan Tamil Finger Spelling :: Traing Phase";
            this.Load += new System.EventHandler(this.frmTrainingSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProcessedImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProcessedImage;
        private System.Windows.Forms.Label lblProcessPicture;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboAplhabet;
        private System.Windows.Forms.TextBox txtCycles;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.ProgressBar progressTraining;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
    }
}