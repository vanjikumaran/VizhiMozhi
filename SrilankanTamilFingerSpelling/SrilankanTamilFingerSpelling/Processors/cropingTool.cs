using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SrilankanTamilFingerSpelling
{
    class cropingTool
    {

        Bitmap _baseImage;



        public cropingTool(Bitmap baseImage)
        {
            this._baseImage = baseImage;

        }


        public Bitmap Cropper()
        {
            int w = this._baseImage.Width;
            int h = this._baseImage.Height;



            Func<int, bool> allWhiteRow = row =>
            {
                for (int i = 0; i < w; ++i)
                    if (this._baseImage.GetPixel(i, row).R == 255)
                        return false;
                return true;
            };



            Func<int, bool> allWhiteColumn = col =>
            {
                for (int i = 0; i < h; ++i)
                    if (this._baseImage.GetPixel(col, i).R == 255)
                        return false;
                return true;
            };

            int topmost = 0;
            for (int row = 0; row < h; ++row)
            {
                if (allWhiteRow(row))
                    topmost = row;
                else break;
            }

            int bottommost = this._baseImage.Height;
            for (int row = h - 1; row >= 0; --row)
            {
                if (allWhiteRow(row))
                    bottommost = row;
                else break;
            }

            int leftmost = 0;
            int rightmost = this._baseImage.Width;
            for (int col = 0; col < w; ++col)
            {
                if (allWhiteColumn(col))
                    leftmost = col;
                else
                    break;
            }

            for (int col = w - 1; col >= 0; --col)
            {
                if (allWhiteColumn(col))
                    rightmost = col;
                else
                    break;
            }

            int croppedWidth = (rightmost - leftmost);
            int croppedHeight = (bottommost - topmost);

            //note over here please

            if (croppedWidth < 0 && croppedHeight < 0)
            {

                croppedWidth = this._baseImage.Width;
                croppedHeight = this._baseImage.Height;




            }


            try
            {
                Bitmap target = new Bitmap(croppedWidth, croppedHeight);
                using (Graphics g = Graphics.FromImage(target))
                {
                    g.DrawImage(this._baseImage, new RectangleF(0, 0, croppedWidth, croppedHeight), new RectangleF(leftmost, topmost, croppedWidth, croppedHeight), GraphicsUnit.Pixel);
                }
                return target;
            }
            catch (Exception ex)
            {
                throw new Exception(
                  string.Format("Values are topmost={0} btm={1} left={2} right={3}", topmost, bottommost, leftmost, rightmost),
                  ex);
            }
        }

    }
}
