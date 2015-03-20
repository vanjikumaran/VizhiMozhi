using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SrilankanTamilFingerSpelling.GUI
{
    public partial class frmMainInterFace : Form
    {
        public frmMainInterFace()
        {
            InitializeComponent();
        }

        private void frmMainInterFace_Load(object sender, EventArgs e)
        {

        }

        private void lblAddInstance_Click(object sender, EventArgs e)
        {
            frmWebCamGUI frmInMDIWeb = new frmWebCamGUI();
            frmInMDIWeb.MdiParent = this;
            frmInMDIWeb.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to exit the system?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }

                this.Close();
            }


        }

        /// <summary>
        /// To open the training interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTrain_Click(object sender, EventArgs e)
        {
            frmTrainingSession frmInMDItraining = new frmTrainingSession();
            frmInMDItraining.MdiParent = this;
          frmInMDItraining.Show();
        }
        /// <summary>
        /// To open recognition interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblRecognition_Click(object sender, EventArgs e)
        {
            
            frmRegognition frmInMDIRecognition = new frmRegognition();
            frmInMDIRecognition.MdiParent = this;
            frmInMDIRecognition.Show();
        }

        /// <summary>
        /// To open about us 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lblAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs frmInAboutUs = new AboutUs();
            frmInAboutUs.MdiParent = this;
            frmInAboutUs.Show();
        }
    }
}
