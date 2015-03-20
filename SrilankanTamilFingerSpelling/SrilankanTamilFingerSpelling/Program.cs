using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SrilankanTamilFingerSpelling
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);




            //Application.Run(new GUI.frmWebCamGUI());
            //Application.Run(new GUI.frmTrainingSession());
            //     Application.Run(new GUI.frmRegognition());
            //  Application.Run(new GUI.frmMDIParent());
            Application.Run(new GUI.frmSplashScreen());


           // Application.Run(new GUI.frmMDIParent());

         Application.Run(new GUI.frmMainInterFace());
        }




        private static void ShowAssemblies(object sender, AssemblyLoadEventArgs e)
        {
            // Store name of assembly in the queue

   
        }


    }
}
