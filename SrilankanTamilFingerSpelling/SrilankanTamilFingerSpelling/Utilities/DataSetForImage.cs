using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrilankanTamilFingerSpelling
{
    class DataSetForImage
    {
        int _hight;
        int _wight;
        int _area;
        int _gravity;

        public DataSetForImage()
        {



        }
        public DataSetForImage(int Hight, int Wight, int Area,int gravity) {
            _hight = Hight;
            _wight = Wight;
            _area = Area;
            _gravity = gravity;

        }

        public int hight() { return _hight; }

        public int wight() { return _wight; }
        public int area() { return _area; }
        public int gravity() { return _gravity; }
    }
}
