using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SrilankanTamilFingerSpelling.Processors
{
    class ConvertToDouble
    {

         public double[] convertIt(Image processImage)
            {

            Bitmap image = new Bitmap(processImage);
            double[] newDouble = new double[(image.Height * image.Width)];
            int arrayCount = 0;
            
            
            for (int y = 0; y < image.Height; y += 1)
            {
                byte clrPixel = 0;

                for (int x = 0; x < image.Width; x += 1)
                {
                    Color clr = image.GetPixel(x, y);

                    
                    
                    if (clr.R != clrPixel)
                    {
                        newDouble[arrayCount] = 1;
                        clrPixel = clr.R;
                    }

                    
                    
                    
                    
                    if ((clrPixel == 255) && (x == image.Width - 1))
                    {
                        newDouble[arrayCount] = 1;
                        clrPixel = 0;
                    }


                    arrayCount += 1;

                    

                }
            }

            //MessageBox.Show(arrayCount.ToString());
            return newDouble;
           
        }


    }

    
}


