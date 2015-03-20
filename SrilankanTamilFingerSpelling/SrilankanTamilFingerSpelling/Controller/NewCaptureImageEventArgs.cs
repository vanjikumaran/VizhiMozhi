using System;


namespace SrilankanTamilFingerSpelling.Controller
{
    public class NewCaptureImageEventArgs : EventArgs

    {


       public NewCaptureImageEventArgs() 
        {
            System.Windows.Forms.MessageBox.Show("Event has been created");

        
        }

        public void MessageFromEvent()

        {


            System.Windows.Forms.MessageBox.Show("this is message from event Hi vanji");
        
        }


    }
}
