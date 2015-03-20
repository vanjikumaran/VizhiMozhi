using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrilankanTamilFingerSpelling.Utilities.WordEngine
{
    class VowelConsonantFoundation
    {
        private TamilLetter firstLetter;
        private TamilLetter secondLetter;
        private string tempLetter;

       
        public string processLetters(TamilLetter _tamilLetter)
        {
            tempLetter = null;

            if (firstLetter == null)
            {
                // create initial Base Letter
                this.firstLetter = _tamilLetter;

                if ((this.firstLetter.Vowel == Category.VOWEL) || (this.firstLetter.Vowel == Category.SPECIAL))
                {
                    this.tempLetter = this.firstLetter.TamilGlyphs;
                    this.firstLetter = null;
                }
   
            }


            else
            {
                this.secondLetter = _tamilLetter;

                if (((this.firstLetter.Vowel == Category.CONSONANT) || (this.firstLetter.Vowel == Category.GRANTHA)) && (this.secondLetter.Vowel == Category.VOWEL))
                {

                    tempLetter = MakeCharacter.ProcessMakeCharacters(firstLetter.TamilGlyphs.ToString(), secondLetter.TamilGlyphs.ToString());

                    this.firstLetter = null;
                    this.secondLetter = null;
                   //this.firstLetter = this.secondLetter;
                   // return this.tempLetter;

                }

                else if ((this.firstLetter.Vowel == Category.CONSONANT) && (this.secondLetter.Vowel == Category.CONSONANT))

                {
                    this.tempLetter = firstLetter.TamilGlyphs.ToString();
                    this.firstLetter = this.secondLetter;
                    //return this.tempLetter;
                
                }


                

                
                
                

               
            }



            return this.tempLetter;



        }
    
    
    
    
    
    
    
    
    
    
    }



}
