using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrilankanTamilFingerSpelling.Utilities.WordEngine
{
    class TamilLetter
    {

        private string tamilGlyphs;
        private Category vowel;


        public TamilLetter()
        { 
        
        }

        public TamilLetter(string _tamilGlyphs, Category _vowel)
        {
            this.tamilGlyphs = _tamilGlyphs;
            this.vowel = _vowel;
              
        }


        public string TamilGlyphs
        {
            get { return this.tamilGlyphs; }
        
        }


        public Category Vowel
        {
             get { return this.vowel; }
        
        }




    }
}
