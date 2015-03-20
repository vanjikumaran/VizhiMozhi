using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AForge;
using AForge.Imaging.Filters;

namespace SrilankanTamilFingerSpelling
{
    class ImageProcess
    {
        private Bitmap _processImage;

        public ImageProcess(Bitmap processImage)
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








            this._processImage = thrsholdIt(this._processImage);


            AForge.Imaging.Filters.BlobsFiltering filter1 = new BlobsFiltering();
            filter1.CoupledSizeFiltering = true;
            filter1.MinWidth = 10;
            filter1.MinHeight = 10;

            filter1.ApplyInPlace(this._processImage);

            





            cropingTool cropper = new cropingTool((Bitmap)this._processImage);

            this._processImage = cropper.Cropper();


            this._processImage = this.ResizeImage(this._processImage);





            return this._processImage;




        }




        ~ImageProcess()
        {


        }

        public Bitmap thrsholdIt(Bitmap bitmap)
        {

            Bitmap returnBitmap = new Bitmap(bitmap);
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    System.Drawing.Color color = bitmap.GetPixel(j, i);

                    if (color.R > 0)
                    {
                        returnBitmap.SetPixel(j, i, Color.White);

                    }
                    else
                    {
                        returnBitmap.SetPixel(j, i, Color.Black);
                    }

                }
            }

            return returnBitmap;
        }




    }
}
