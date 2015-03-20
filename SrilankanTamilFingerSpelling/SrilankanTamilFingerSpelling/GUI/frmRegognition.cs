using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using System.Threading;


using NeuronDotNet.Core;
using NeuronDotNet.Core.Backpropagation;
using CoreLetter;



using SrilankanTamilFingerSpelling.Utilities.WordEngine;

namespace SrilankanTamilFingerSpelling.GUI
{
    public partial class frmRegognition : Form
    {


        #region Definition
        /// <summary>
        /// this section is to define all nessary actributes 
        /// </summary>

        Queue<System.Drawing.Image> firstLevelQueue = new Queue<System.Drawing.Image>(); // to save image coming form webcamera
        Queue<System.Drawing.Image> secondLevelQueue = new Queue<System.Drawing.Image>(); // to store preprocessed and motion selected image
        
        FirstStageImageProcess firstProcess;
        
        MotionDetector mottion = new MotionDetector();
        
        public int queueCount = 0;
        
        bool threadBool = true;


        Queue<string> regogLetter = new Queue<string>();
        Queue<TamilLetter> recognizedLetter = new Queue<TamilLetter>();

        Queue<TamilLetter> toWordLetter = new Queue<TamilLetter>();



        Stack<TamilLetter> stackLetterHolder = new Stack<TamilLetter>();



        int countForWord = 0;
        string tempString = null;
        string tempString2 = null;
        TamilLetter tempTamilLetter;


        VowelConsonantFoundation VCEngine = new VowelConsonantFoundation();

        # endregion

        #region Difine Letters
        private static readonly string[] letters = 
        {
                "அ","ஆ","இ","ஈ","உ","ஊ","எ","ஏ","ஐ","ஒ","ஓ","ஔ",
                          
                "ஃ",
                       
                "க்","ங்","ச்","ஞ்" ,"ட்","ண்","த்","ந்" ,"ப்" ,"ம்" ,"ய்" ,"ர்", "ல்" ,"வ்","ழ்", "ள்", "ற்","ன்",
       
                "ஷ்","ஹ்","ஜ்","ஸ்"
        };



        private static readonly TamilLetter[] tamilLetters =
        {
            //Vowel Letters


            new TamilLetter("அ",Category.VOWEL),
            new TamilLetter("ஆ",Category.VOWEL),
            new TamilLetter("இ",Category.VOWEL),
            new TamilLetter("ஈ",Category.VOWEL),
            new TamilLetter("உ",Category.VOWEL),
            new TamilLetter("ஊ",Category.VOWEL),
            new TamilLetter("எ",Category.VOWEL),
            new TamilLetter("ஏ",Category.VOWEL),
            new TamilLetter("ஐ",Category.VOWEL),
            new TamilLetter("ஒ",Category.VOWEL),
            new TamilLetter("ஓ",Category.VOWEL),
            new TamilLetter("ஔ",Category.VOWEL),


            //Special Letter

            new TamilLetter("ஃ",Category.SPECIAL),

            // Consonants Letters

            new TamilLetter("க்",Category.CONSONANT),
            new TamilLetter("ங்",Category.CONSONANT),
            new TamilLetter("ச்",Category.CONSONANT),
            new TamilLetter("ஞ்",Category.CONSONANT),
            new TamilLetter("ட்",Category.CONSONANT),
            new TamilLetter("ண்",Category.CONSONANT),
            new TamilLetter("த்",Category.CONSONANT),
            new TamilLetter("ந்",Category.CONSONANT),
            new TamilLetter("ப்",Category.CONSONANT),
            new TamilLetter("ம்",Category.CONSONANT),
            new TamilLetter("ய்",Category.CONSONANT),
            new TamilLetter("ர்",Category.CONSONANT),
            new TamilLetter("ல்",Category.CONSONANT),
            new TamilLetter("வ்",Category.CONSONANT),
            new TamilLetter("ழ்",Category.CONSONANT),
            new TamilLetter("ள்",Category.CONSONANT),
            new TamilLetter("ற்",Category.CONSONANT),
            new TamilLetter("ன்",Category.CONSONANT),



            //Grantha Letters

            new TamilLetter("ஷ்",Category.GRANTHA),
            new TamilLetter("ஹ்",Category.GRANTHA),
            new TamilLetter("ஜ்",Category.GRANTHA),
            new TamilLetter("ஸ்",Category.GRANTHA)

 
        };
        #endregion


        #region Vector
        public double[] getGetEquivalentVector(System.Drawing.Image processingImage)
        {


            ///////////Codeed on 5th august 2010
            ////////Bitmap image = new Bitmap(processingImage);

            ////////ResizeNearestNeighbor resize = new ResizeNearestNeighbor(100, 100);
            //////// resize.Apply(image);
            ////////Processors.ConvertToDouble newConvetedArray = new SrilankanTamilFingerSpelling.Processors.ConvertToDouble();
            ////////return newConvetedArray.convertIt(image);
            //////////ending code







            Bitmap processImage = (Bitmap)processingImage;
            // here i have to blob it and convert it to double array 


            BlobCounterBase bc = new BlobCounter();

            bc.FilterBlobs = true;
            bc.MinWidth = 10;
            bc.MinHeight = 10;

            bc.ProcessImage(processImage);
            Blob[] blobs = bc.GetObjects(processImage, false);
            DataSetForImage[] imageDataSet = new DataSetForImage[blobs.Length];
            int count = 0;

            foreach (Blob blob in blobs)
            {
                imageDataSet[count] = new DataSetForImage(blob.Image.Height, blob.Image.Width, blob.Area, blob.CenterOfGravity.X);
                count++;
            }

            Letter ABCLeter = new Letter(imageDataSet);
            double[] arry = ABCLeter.GetEquivalentVector();
            return arry;


        }
        #endregion

        public frmRegognition()
        {
            InitializeComponent();
        }



        private void frmRegognition_Load(object sender, EventArgs e)
        {
            this.webCam.CaptureHeight = this.picSourceImage.Height;
            this.webCam.CaptureWidth = this.picSourceImage.Width;
            this.webCam.TimeToCapture_milliseconds = (1000 / 3);
            webCam.Start(0);
            //webCam.Stop();




            mottion.MotionLevelCalculation = true;

            /// instantiating the threads


            ThreadStart threadStartForProcess = new ThreadStart(RegonitionMethod);
            Thread threadRecognition = new Thread(threadStartForProcess);
            threadRecognition.Start();
          

            ThreadStart threadStartForImageProcessing = new ThreadStart(ImageProcessingMethods);
            Thread  threadImageProcessing = new Thread(threadStartForImageProcessing);
            threadImageProcessing.Start();

        }


        #region Web Camera Capturing Method
        private void webCamera_ImageCaptured(object source, WebCamUserController.WebcamEventArgs e)
        {



            this.picSourceImage.Image = e.WebCamImage;
            firstLevelQueue.Enqueue(e.WebCamImage);

        }
        #endregion






        #region Regognition Thread Method



        public void RegonitionMethod()
        {

            while (threadBool)
            {


                try
                {
                    if (secondLevelQueue.Count > 0)
                    {

                        double[] input = getGetEquivalentVector(secondLevelQueue.Dequeue());

                        int winner = 0;
                        int current = 1;



                        while (current < Alphabet.LetterCount)
                        {
                            try
                            {
                                using (Stream stream = File.Open(Application.StartupPath + @"\Networks\" + winner.ToString("00") + current.ToString("00") + ".ndn", FileMode.Open))
                                {
                                    IFormatter formatter = new BinaryFormatter();
                                    INetwork network = (INetwork)formatter.Deserialize(stream);

                                    double[] output = network.Run(input);
                                    string result = letters[winner] + " vs " + letters[current] + " = ";
                                    if (output[1] > output[0])
                                    {
                                        winner = current;
                                    }
                                    result += letters[winner];

                                }
                                current++;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Failed to load saved neural networks", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        
                        //MessageBox.Show(letters[winner].ToString());
                        //lblResult.Text = letters[winner].ToString();
                        regogLetter.Enqueue(letters[winner].ToString());
                        recognizedLetter.Enqueue(tamilLetters[winner]);

                    }

                }
                catch (Exception exeptionAtAddInstanceToFileTimer_Tick)
                {

                    Console.WriteLine("Error has been occord in Recognizing the Charactor");
                }







            }


        }

        #endregion



     
        #region Image Processing Method


        public void ImageProcessingMethods()
        {

            while (threadBool)
            {



                try
                {

                    if (firstLevelQueue.Count > 2)
                    {
                        Bitmap temImage = (Bitmap)firstLevelQueue.Dequeue();
                        firstProcess = new FirstStageImageProcess(temImage);
                        Bitmap temImage2 = (Bitmap)firstProcess.processTheImage();
                        int count = mottion.ProcessFrame((Bitmap)temImage2.Clone());
                        //// if count is 0 it means its first image or image which doesnt have 
                        //// red color in that image 

                        if (count > 2 && count < 2500)
                        {

                            if ((queueCount < 4))
                            {
                                queueCount++;
                            }

                            else
                            {
                                Console.WriteLine(count.ToString());
                                ImageProcess imageProcess = new ImageProcess((Bitmap)temImage2.Clone());
                                secondLevelQueue.Enqueue((Bitmap)imageProcess.processTheImage());


                            }
                        }



                        temImage.Dispose();
                        temImage2.Dispose();
                    }





                }
                catch (Exception expetionAtfirstToSecondImage)
                {

                    Console.WriteLine("Probelm at Image Processing method");
                }

            }





        }


        #endregion
       




        
       

       
        
        
        
        
        
        private void WordCreatorTimer_Tick(object sender, EventArgs e)
        {

            
            if (recognizedLetter.Count > 0)
            {
                // if recognized tamil letter more than two 
                // from recognized letter Queue first letter will be assigned into the temperay tamil letter variable 


                tempTamilLetter = recognizedLetter.Dequeue();

                //if first tempstring is null stack of letters will clear it self first
                // and put Tamil Letter into the stack! and assing the tamil glyph into first Tempray variable


                if (tempString == null)
                {
                    stackLetterHolder.Clear();// empty the Stack of Tamil letters

                    stackLetterHolder.Push(tempTamilLetter); // Add new Tamil Letter into the stack
                 
                    tempString = tempTamilLetter.TamilGlyphs; // assign the tamil glyph into temperay string to check
                }

                /// if first temperay varibale's tamil gylphs Equal to the next tamil Letters Gylphs
                /// then the Tamil letter will be assign into the stack!!
                
                            
                else if (tempString == tempTamilLetter.TamilGlyphs)
                {

                    stackLetterHolder.Push(tempTamilLetter);

                    /// if stack is more than 1 only it will start to process on identifing the 
                    /// word creation
                    /// 

                    if (stackLetterHolder.Count > 1)
                    {
                        
                        /// if tempString Null the first letter will assigned into the toWordLetter Queue
                        /// and it will start to count Temprary number( CountForWord)
                        
                       if (tempString2 == null)
                        {
                            toWordLetter.Enqueue(tempTamilLetter); /// add the tamil letter into the toWordLetterQueue
                            tempString2 = tempTamilLetter.TamilGlyphs; /// assign the tamil glyphs into tempString2
                            countForWord++; // count 
                            ///stackLetterHolder.Clear();
 
                        }

                        /// second Temprary String and current tempTamilLetter's tamil glyphs are equal!
                       else if (tempString2 == tempTamilLetter.TamilGlyphs)
                       {
                           /// if count is grater than 5 and tempTamilLetter is consonant or grantha 
                           /// tempTamil Letter Will be assing into toWordLetter Queue
                           /// and assign that value into second temprary String
                           /// and reset the count to 0
                           
                           if ((countForWord > 5) && ((tempTamilLetter.Vowel == Category.CONSONANT) || (tempTamilLetter.Vowel == Category.GRANTHA)))
                           {
                               toWordLetter.Enqueue(tempTamilLetter);
                               tempString2 = tempTamilLetter.TamilGlyphs;
                               countForWord = 0;
                         
                           }

                           /// if second Temprary variable is equal to the tmail glyphs in the tempTamil Letter
                           ///add one more to count!!
                           ///
                           
                           else
                           {
                               countForWord++;
                           }

                       }
                       

                       /// if secound Tempary String is not equal to Current TempTamilLetter 
                       /// it will be added into toWordLetter Queue
                       /// 


                       else
                       {
                           toWordLetter.Enqueue(tempTamilLetter);
                           tempString2 = tempTamilLetter.TamilGlyphs;
                           countForWord = 0;

                       }




                    }
                }

                
                
                /// if first temp string variable is != or it not equal to current gylphs 
                /// stack will be cleared and it will be assinged into that stack! and first temp allso assigned
                else
                {
                    stackLetterHolder.Clear();
                    stackLetterHolder.Push(tempTamilLetter);
                    tempString = tempTamilLetter.TamilGlyphs;

                }


            }










            /// Working pErfectly but have to handle the error rate

            //////if (recognizedLetter.Count > 0)
            //////{
            //////    tempTamilLetter = recognizedLetter.Dequeue();


            //////    if (tempString == null)
            //////    {
            //////        toWordLetter.Enqueue(tempTamilLetter);
            //////        tempString = tempTamilLetter.TamilGlyphs;


            //////        countForWord++;

            //////        listBox1.Items.Add("this is letter null   Letter" + tempString + " count " + countForWord);
            //////    }

            //////    else if (tempString == tempTamilLetter.TamilGlyphs)
            //////    {
            //////        if ((countForWord > 6) && ((tempTamilLetter.Vowel == Category.CONSONANT) || (tempTamilLetter.Vowel == Category.GRANTHA)))
            //////        {

            //////            toWordLetter.Enqueue(tempTamilLetter);
            //////            tempString = tempTamilLetter.TamilGlyphs;


            //////            countForWord = 1;
            //////            listBox1.Items.Add("If confition of > 5 Letter " + tempString + " count " + countForWord);



            //////        }

            //////        else
            //////        {
            //////            countForWord++;
            //////            listBox1.Items.Add("count less part Letter" + tempString + " count " + countForWord);
            //////        }

            //////        //return;
            //////    }

            //////    else
            //////    {
            //////        toWordLetter.Enqueue(tempTamilLetter);
            //////        tempString = tempTamilLetter.TamilGlyphs;
            //////        countForWord = 1;
            //////        listBox1.Items.Add("final Letter " + tempString + " count " + countForWord);


            //////    }



            //////}


            //////////////////if (recognizedLetter.Count>0)
            //////////////////{
            //////////////////    tempTamilLetter = recognizedLetter.Dequeue();

            //////////////////    if (tempString== null)
            //////////////////    {
            //////////////////        toWordLetter.Enqueue(tempTamilLetter);
            //////////////////        tempString = tempTamilLetter.TamilGlyphs;
            //////////////////        countForWord++;
            //////////////////    }

            //////////////////    else if (tempString == tempTamilLetter.TamilGlyphs)
            //////////////////    {

            //////////////////        countForWord++;
            //////////////////        //return;
            //////////////////    }

            //////////////////    else
            //////////////////    {
            //////////////////        toWordLetter.Enqueue(tempTamilLetter);
            //////////////////        tempString = tempTamilLetter.TamilGlyphs;
                    
                
            //////////////////    }



            //////////////////}

            
          

       }

        private void WordCreatorTimer2_Tick(object sender, EventArgs e)
        {

            /// this timer is depend on funtion of wordCreatorTimer timer !!!



            //string tempSt = lblResult.Text;
            string tempSt = textBox1.Text;

            if (toWordLetter.Count > 0)
            {
                string TestingValue = VCEngine.processLetters(toWordLetter.Dequeue());
                if (TestingValue != null)
                {

                    textBox1.Text = tempSt + TestingValue;

                }

 
              //  listBox2.Items.Add(toWordLetter.Dequeue().TamilGlyphs);

            }
            



           


        }

        private void frmRegognition_FormClosed(object sender, FormClosedEventArgs e)
        {

            threadBool = false;
            webCam.Stop();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this?", "Confirm Close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }






    }
}
