using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AForge;
using AForge.Imaging.Filters;

namespace SrilankanTamilFingerSpelling
{
    public class FirstStageImageProcess
    {
        private Bitmap _processImage;

        public FirstStageImageProcess(Bitmap processImage)
        {


            Rectangle rec = new Rectangle(0, 0, processImage.Width, processImage.Height);
            Bitmap imageCOnveted = processImage.Clone(rec, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            this._processImage = imageCOnveted;

        }


        private Bitmap ResizeImage(Bitmap image)
        {
            ResizeNearestNeighbor resize = new ResizeNearestNeighbor(250, 250);
            return resize.Apply(image);
        }





        public Bitmap processTheImage()
        {

            AForge.Imaging.Filters.YCbCrFiltering filter = new YCbCrFiltering();

            filter.Cb = new DoubleRange(-0.19, 0);
            filter.Cr = new DoubleRange(0.1, 0.8);

            //to white Glove the Cb range is -0.2 to 0.9 and Cr range is -0.9 to 0

            //to red golve the Cb range is 0.2 to 0
            // Cr 0.1 to 0.5


            filter.ApplyInPlace(this._processImage);
   


            return this._processImage;




        }




        ~FirstStageImageProcess()
        {


        }

       




    }
}
