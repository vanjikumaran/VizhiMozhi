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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value != progressBar1.Maximum)
                progressBar1.Value = (progressBar1.Value + 1);


            else
                this.Close();

            


        }
    }
}
