using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;


namespace SrilankanTamilFingerSpelling
{
    class Letter
    {
        DataSetForImage[] blobedImageData;
        
        
        public Letter(DataSetForImage[] _imageArray) 
        {
            blobedImageData = _imageArray;

        }


        #region VectorClassification
        public double[] GetEquivalentVector()
        {

            double[] data = new double[30];
            int i=0;

            foreach (DataSetForImage processImage in blobedImageData)
            {
                int hight = processImage.hight();
                int Wight = processImage.wight();
                int area = processImage.area();
                int grvity = processImage.gravity();

                data[i] = Math.Exp((Math.Sign(area - grvity) / Math.Log(hight * Wight)));
               // data[i] = (area - grvity) * (hight + Wight);

                i++;
            }

           return data;

        }

        #endregion VectorClassification


















    }
}
