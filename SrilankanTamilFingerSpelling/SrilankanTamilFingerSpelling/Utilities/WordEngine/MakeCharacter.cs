using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SrilankanTamilFingerSpelling.Utilities.WordEngine
{
    public class MakeCharacter
    {





        /// <summary>
        /// This Method will create a Vowel consonant Based on parametters
        /// </summary>
        /// <param name="firstLetter"></param>
        /// <param name="secondLetter"></param>
        /// <returns></returns>
        public static string ProcessMakeCharacters(string firstLetter, string secondLetter)
        {
            string tempLetter = null;

            //Vowel Consonant

            #region க்

            //க்
            if (firstLetter == "க்")
            {

                //க
                if (secondLetter == "அ")
                {
                    tempLetter = "க";
                }

                //கா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "கா";
                }

                //கி
                else if (secondLetter == "இ")
                {
                    tempLetter = "கி";
                }
                //கீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "கீ";
                }
                //கு
                else if (secondLetter == "உ")
                {
                    tempLetter = "கு";
                }

                //கூ
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "கூ";
                }


                //கெ
                else if (secondLetter == "எ")
                {
                    tempLetter = "கெ";
                }
                //கே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "கே";
                }

                //கை
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "கை";
                }
                //கொ
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "கொ";
                }
                //கோ
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "கோ";
                }
                //கௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "கௌ";
                }

            }

            #endregion


            #region ங்

            //ங்
            if (firstLetter == "ங்")
            {

                //ங
                if (secondLetter == "அ")
                {
                    tempLetter = "ங";
                }

                //ஙா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ஙா";
                }

                //ஙி
                else if (secondLetter == "இ")
                {
                    tempLetter = "ஙி";
                }
                //ஙீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ஙீ";
                }
                //ஙு
                else if (secondLetter == "உ")
                {
                    tempLetter = "ஙு";
                }

                //ஙூ
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ஙூ";
                }


                //ஙெ
                else if (secondLetter == "எ")
                {
                    tempLetter = "ஙெ";
                }
                //ஙே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ஙே";
                }

                //ஙை
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ஙை";
                }
                //கொ
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ஙொ";
                }
                //ஙோ
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ஙோ";
                }
                //ஙௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ஙௌ";
                }

            }
            #endregion

            #region ச்
            //ச்
           if (firstLetter == "ச்")
            {

                //ச
                if (secondLetter == "அ")
                {
                    tempLetter = "ச";
                }

                //சா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "சா";
                }

                //சி
                else if (secondLetter == "இ")
                {
                    tempLetter = "சி";
                }
                //சீ 
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "சீ";
                }
                //சு     
                else if (secondLetter == "உ")
                {
                    tempLetter = "சு";
                }

                //சூ
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "சூ";
                }


                //செ
                else if (secondLetter == "எ")
                {
                    tempLetter = "செ";
                }
                //சே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "சே";
                }

                //சை
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "சை";
                }
                //சொ
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "சொ";
                }
                // சோ 
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "சோ";
                }
                //சௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "சௌ";
                }

            }

            #endregion


            #region ஞ்
            //ஞ்


           if (firstLetter == "ஞ்")
            {

                //ஞ
                if (secondLetter == "அ")
                {
                    tempLetter = "ஞ";
                }

                //ஞா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ஞா";
                }

                //ஞி
                else if (secondLetter == "இ")
                {
                    tempLetter = "ஞி";
                }
                //ஞீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ஞீ";
                }
                //ஞு     
                else if (secondLetter == "உ")
                {
                    tempLetter = "ஞு";
                }

                //ஞூ
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ஞூ";
                }


                //ஞெ
                else if (secondLetter == "எ")
                {
                    tempLetter = "ஞெ";
                }



                //ஞே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ஞே";
                }

                //ஞை
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ஞை";
                }
                //ஞொ
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ஞொ";
                }
                // ஞோ 
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ஞோ";
                }
                //ஞௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ஞௌ";
                }

            }
            #endregion


            #region ட்
            //ட்
           if (firstLetter == "ட்")
            {

                //ட
                if (secondLetter == "அ")
                {
                    tempLetter = "ட";
                }

                //டா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "டா";
                }

                //டி
                else if (secondLetter == "இ")
                {
                    tempLetter = "டி";
                }
                //டீ     
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "டீ";
                }
                //டு
                else if (secondLetter == "உ")
                {
                    tempLetter = "டு";
                }

                //டூ
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "டூ";
                }


                // டெ 
                else if (secondLetter == "எ")
                {
                    tempLetter = "டெ";
                }
                //டே     
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "டே";
                }

                //டை
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "டை";
                }
                //டொ  
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "டொ";
                }
                //டோ
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "டோ";
                }
                //டௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "டௌ";
                }

            }
            #endregion


            #region ண்
            //ண்
            if (firstLetter == "ண்")
            {

                //ண 
                if (secondLetter == "அ")
                {
                    tempLetter = "ண";
                }

                //ணா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ணா";
                }

                //ணி
                else if (secondLetter == "இ")
                {
                    tempLetter = "ணி";
                }
                //ணீ     
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ணீ";
                }
                //ணு  
                else if (secondLetter == "உ")
                {
                    tempLetter = "ணு";
                }

                //ணூ
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ணூ";
                }


                //ணெ
                else if (secondLetter == "எ")
                {
                    tempLetter = "ணெ";
                }
                //ணே     
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ணே";
                }

                //ணை
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ணை";
                }
                //ணொ  
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ணொ";
                }
                //ணோ
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ணோ";
                }
                //ணௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ணௌ";
                }

            }
            #endregion


            #region த்
            //த்
            if (firstLetter == "த்")
            {

                //த 
                if (secondLetter == "அ")
                {
                    tempLetter = "த";
                }

                //தா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "தா";
                }

                // தி
                else if (secondLetter == "இ")
                {
                    tempLetter = "தி";
                }
                //தீ   
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "தீ";
                }
                //து
                else if (secondLetter == "உ")
                {
                    tempLetter = "து";
                }

                //தூ
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "தூ";
                }


                //தெ
                else if (secondLetter == "எ")
                {
                    tempLetter = "தெ";
                }
                //தே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "தே";
                }

                //தை
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "தை";
                }
                //தொ  
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "தொ";
                }
                //தோ
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "தோ";
                }
                //தௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "தௌ";
                }

            }
            #endregion


            #region ந்
            //ந்
            if (firstLetter == "ந்")
            {

                //ந   
                if (secondLetter == "அ")
                {
                    tempLetter = "ந";
                }

                //நா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "நா";
                }

                // நி
                else if (secondLetter == "இ")
                {
                    tempLetter = "நி";
                }
                //நீ   
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "நீ";
                }
                //நு 
                else if (secondLetter == "உ")
                {
                    tempLetter = "நு";
                }

                //நூ    
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "நூ";
                }


                //நெ
                else if (secondLetter == "எ")
                {
                    tempLetter = "நெ";
                }
                //நே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "நே";
                }

                //நை
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "நை";
                }
                //நொ  
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "நொ";
                }
                //நோ 
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "நோ";
                }
                //நௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "நௌ";
                }

            }
            #endregion



            #region ப்
            //ப்
            if (firstLetter == "ப்")
            {

                //ப
                if (secondLetter == "அ")
                {
                    tempLetter = "ப";
                }

                //பா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "பா";
                }

                // பி
                else if (secondLetter == "இ")
                {
                    tempLetter = "பி";
                }
                //பீ 
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "பீ";
                }
                //பு
                else if (secondLetter == "உ")
                {
                    tempLetter = "பு";
                }

                //பூ    
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "பூ";
                }


                //பெ
                else if (secondLetter == "எ")
                {
                    tempLetter = "பெ";
                }
                //பே  
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "பே";
                }

                //பை
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "பை";
                }
                //பொ 
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "பொ";
                }
                //போ 
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "போ";
                }
                //பௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "பௌ";
                }

            }
            #endregion



            #region ம்
            //ம்
            if (firstLetter == "ம்")
            {

                //ம      
                if (secondLetter == "அ")
                {
                    tempLetter = "ம";
                }

                //மா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "மா";
                }

                // மி
                else if (secondLetter == "இ")
                {
                    tempLetter = "மி";
                }
                //மீ 
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "மீ";
                }
                //மு
                else if (secondLetter == "உ")
                {
                    tempLetter = "மு";
                }

                //மூ    
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "மூ";
                }


                //மெ
                else if (secondLetter == "எ")
                {
                    tempLetter = "மெ";
                }
                //மே  
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "மே";
                }

                //மை 
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "மை";
                }
                //மொ   
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "மொ";
                }
                //மோ 
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "மோ";
                }
                //மௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "மௌ";
                }

            }
            #endregion


            #region ய்
            //ய்
            if (firstLetter == "ய்")
            {

                //ய           
                if (secondLetter == "அ")
                {
                    tempLetter = "ய";
                }

                //யா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "யா";
                }

                // யி
                else if (secondLetter == "இ")
                {
                    tempLetter = "யி";
                }
                //யீ 
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "யீ";
                }
                //யு
                else if (secondLetter == "உ")
                {
                    tempLetter = "யு";
                }

                //யூ    
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "யூ";
                }


                //யெ
                else if (secondLetter == "எ")
                {
                    tempLetter = "யெ";
                }
                //யே     
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "யே";
                }

                //யை 
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "யை";
                }
                //யொ   
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "யொ";
                }
                //யோ 
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "யோ";
                }
                //யௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "யௌ";
                }

            }
            #endregion


            #region ர்
            //ர்
            if (firstLetter == "ர்")
            {

                //ர                 
                if (secondLetter == "அ")
                {
                    tempLetter = "ர";
                }

                //ரா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ரா";
                }

                // ரி
                else if (secondLetter == "இ")
                {
                    tempLetter = "ரி";
                }
                //ரீ 
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ரீ";
                }
                //ரு
                else if (secondLetter == "உ")
                {
                    tempLetter = "ரு";
                }

                //ரூ    
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ரூ";
                }


                //ரெ  
                else if (secondLetter == "எ")
                {
                    tempLetter = "ரெ";
                }
                //ரே    
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ரே";
                }

                //ரை 
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ரை";
                }
                //ரொ     
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ரொ";
                }
                //ரோ 
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ரோ";
                }
                //ரௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ரௌ";
                }

            }
            #endregion



            #region ல்
            //ல்
            if (firstLetter == "ல்")
            {

                //ல                     
                if (secondLetter == "அ")
                {
                    tempLetter = "ல";
                }

                //லா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "லா";
                }

                //லி
                else if (secondLetter == "இ")
                {
                    tempLetter = "லி";
                }
                //லீ 
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "லீ";
                }
                //லு
                else if (secondLetter == "உ")
                {
                    tempLetter = "லு";
                }

                //லூ    
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "லூ";
                }


                //லெ    
                else if (secondLetter == "எ")
                {
                    tempLetter = "லெ";
                }
                //லே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "லே";
                }

                //லை 
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "லை";
                }
                //லொ     
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "லொ";
                }
                //லோ
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "லோ";
                }
                //லௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "லௌ";
                }

            }
            #endregion

            #region வ்
            //வ்
            if (firstLetter == "வ்")
            {

                //வ               
                if (secondLetter == "அ")
                {
                    tempLetter = "வ";
                }

                //வா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "வா";
                }

                //வி       
                else if (secondLetter == "இ")
                {
                    tempLetter = "வி";
                }
                //வீ 
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "வீ";
                }
                //வு
                else if (secondLetter == "உ")
                {
                    tempLetter = "வு";
                }

                //வூ   
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "வூ";
                }


                //வெ    
                else if (secondLetter == "எ")
                {
                    tempLetter = "வெ";
                }
                //வே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "வே";
                }

                //வை    
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "வை";
                }
                //வொ     
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "வொ";
                }
                //வோ
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "வோ";
                }
                //வௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "வௌ";
                }

            }
            #endregion

            #region ழ்
            //ழ்
            if (firstLetter == "ழ்")
            {

                //ழ                  
                if (secondLetter == "அ")
                {
                    tempLetter = "ழ";
                }

                //ழா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ழா";
                }

                //ழி       
                else if (secondLetter == "இ")
                {
                    tempLetter = "ழி";
                }
                //ழீ 
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ழீ";
                }
                //வு
                else if (secondLetter == "உ")
                {
                    tempLetter = "ழு";
                }

                //வூ   
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ழூ";
                }


                //ழெ    
                else if (secondLetter == "எ")
                {
                    tempLetter = "ழெ";
                }
                //ழே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ழே";
                }

                //ழை          
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ழை";
                }
                //ழொ     
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ழொ";
                }
                //ழோ
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ழோ";
                }
                //ழௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ழௌ";
                }

            }
            #endregion


            #region ள்
            //ள்
            if (firstLetter == "ள்")
            {

                //ள                        
                if (secondLetter == "அ")
                {
                    tempLetter = "ள";
                }

                //ளா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ளா";
                }

                //ளி       
                else if (secondLetter == "இ")
                {
                    tempLetter = "ளி";
                }
                //ளீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ளீ";
                }
                //ளு
                else if (secondLetter == "உ")
                {
                    tempLetter = "ளு";
                }

                //ளூ   
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ளூ";
                }


                //ளெ    
                else if (secondLetter == "எ")
                {
                    tempLetter = "ளெ";
                }
                //ளே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ளே";
                }

                //ளை          
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ளை";
                }
                //ளொ     
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ளொ";
                }
                //ளோ  
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ளோ";
                }
                //ளௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ளௌ";
                }

            }
            #endregion

            #region ற்
            //ற்
            if (firstLetter == "ற்")
            {

                //ற                            
                if (secondLetter == "அ")
                {
                    tempLetter = "ற";
                }

                //றா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "றா";
                }

                //றி       
                else if (secondLetter == "இ")
                {
                    tempLetter = "றி";
                }
                //றீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "றீ";
                }
                //று
                else if (secondLetter == "உ")
                {
                    tempLetter = "று";
                }

                //றூ   
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "றூ";
                }


                //றெ    
                else if (secondLetter == "எ")
                {
                    tempLetter = "றெ";
                }
                //றே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "றே";
                }

                //றை      
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "றை";
                }
                //றொ        
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "றொ";
                }
                //றோ  
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "றோ";
                }
                //றௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "றௌ";
                }

            }
            #endregion


            #region ன்
            //ன்
            if (firstLetter == "ன்")
            {
  
                //ன                          
                if (secondLetter == "அ")
                {
                    tempLetter = "ன";
                }

                //னா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "னா";
                }

                //னி      
                else if (secondLetter == "இ")
                {
                    tempLetter = "னி";
                }
                //னீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "னீ";
                }
                //னு

                else if (secondLetter == "உ")
                {
                    tempLetter = "னு";
                }

                //னூ   
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "னூ";
                }


                //னெ    
                else if (secondLetter == "எ")
                {
                    tempLetter = "னெ";
                }
                //னே
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "னே";
                }

                //னை     
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "னை";
                }

                //னொ 
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "றொ";
                }
                //னோ  
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "னோ";
                }
                //னௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "னௌ";
                }

            }
            #endregion
        
            
            
            
            // Vowel Grantha


           #region ஷ்
            //ஷ்
            if (firstLetter == "ஷ்")
            {

                //ஷ                         
                if (secondLetter == "அ")
                {
                    tempLetter = "ஷ";
                }

                //ஷா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ஷா";
                }

                //ஷி     
                else if (secondLetter == "இ")
                {
                    tempLetter = "ஷி";
                }
                //ஷீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ஷீ";
                }
                //ஷு

                else if (secondLetter == "உ")
                {
                    tempLetter = "ஷு";
                }

                //ஷூ   
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ஷூ";
                }


                //ஷெ 
                else if (secondLetter == "எ")
                {
                    tempLetter = "ஷெ";
                }
                //ஷே    
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ஷே";
                }

                //ஷை     
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ஷை";
                }

                //ஷொ 
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ஷொ";
                }
                //ஷோ  
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ஷோ";
                }
                //ஷௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ஷௌ";
                }

            }
            #endregion


            #region ஹ்

            //ஹ்
            if (firstLetter == "ஹ்")
            {

                //ஹ                              
                if (secondLetter == "அ")
                {
                    tempLetter = "ஹ";
                }

                //ஹா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ஹா";
                }

                //ஹி     
                else if (secondLetter == "இ")
                {
                    tempLetter = "ஹி";
                }
                //ஹீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ஹீ";
                }
                //ஹு

                else if (secondLetter == "உ")
                {
                    tempLetter = "ஹு";
                }

                //ஹூ   
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ஹூ";
                }


                //ஹெ  
                else if (secondLetter == "எ")
                {
                    tempLetter = "ஹெ";
                }
                //ஹே  
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ஹே";
                }

                //ஹை    
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ஹை";
                }

                //ஹொ 
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ஹொ";
                }
                //ஹோ  
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ஹோ";
                }
                //ஹௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ஹௌ";
                }

            }
            #endregion



            #region ஜ்

            //ஜ்
            if (firstLetter == "ஜ்")
            {

                //ஜ                            
                if (secondLetter == "அ")
                {
                    tempLetter = "ஜ";
                }

                //ஜா
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ஜா";
                }

                //ஜி     
                else if (secondLetter == "இ")
                {
                    tempLetter = "ஜி";
                }
                //ஜீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ஜீ";
                }
                //ஜு

                else if (secondLetter == "உ")
                {
                    tempLetter = "ஜு";
                }

                //ஜூ   
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ஜூ";
                }

     
                //ஜெ  
                else if (secondLetter == "எ")
                {
                    tempLetter = "ஜெ";
                }
                //ஜே  
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ஜே";
                }

                //ஜை    
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ஜை";
                }

                //ஜொ 
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ஜொ";
                }
                //ஜோ  
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ஜோ";
                }
                //ஜௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ஜௌ";
                }

            }
            #endregion


            #region ஸ்

            //ஸ்
            if (firstLetter == "ஸ்")
            {

                //ஸ                           
                if (secondLetter == "அ")
                {
                    tempLetter = "ஸ";
                }

                //ஸா  
                else if (secondLetter == "ஆ")
                {
                    tempLetter = "ஸா";
                }

                //ஸி     
                else if (secondLetter == "இ")
                {
                    tempLetter = "ஸி";
                }
                //ஸீ
                else if (secondLetter == "ஈ")
                {
                    tempLetter = "ஸீ";
                }
                //ஸு  
                else if (secondLetter == "உ")
                {
                    tempLetter = "ஸு";
                }

                //ஸூ   
                else if (secondLetter == "ஊ")
                {
                    tempLetter = "ஸூ";
                }


                //ஸெ  
  
                else if (secondLetter == "எ")
                {
                    tempLetter = "ஸெ";
                }
                //ஸே  
                else if (secondLetter == "ஏ")
                {
                    tempLetter = "ஸே";
                }

                //ஸை    
                else if (secondLetter == "ஐ")
                {
                    tempLetter = "ஸை";
                }

                //ஸொ 
                else if (secondLetter == "ஒ")
                {
                    tempLetter = "ஸொ";
                }
                //ஸோ  
                else if (secondLetter == "ஓ")
                {
                    tempLetter = "ஸோ";
                }
                //ஸௌ
                else if (secondLetter == "ஔ")
                {
                    tempLetter = "ஸௌ";
                }

            }
            #endregion

   
            return tempLetter;
        
        
        
        
        
        
        
        
        
        }

    }
}
