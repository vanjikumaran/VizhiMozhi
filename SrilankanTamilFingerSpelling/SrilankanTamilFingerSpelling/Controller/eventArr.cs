using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrilankanTamilFingerSpelling.Controller
{
   public class eventArr
    {
       public event EventHandler<NewCaptureImageEventArgs> EventVanji;



       public eventArr()
        {

            EventHandler<Controller.NewCaptureImageEventArgs> handler = EventVanji;
           
           if (handler != null)
            {

                Controller.NewCaptureImageEventArgs args = new SrilankanTamilFingerSpelling.Controller.NewCaptureImageEventArgs();
                handler(this, args);

            }

        }


    }
}
