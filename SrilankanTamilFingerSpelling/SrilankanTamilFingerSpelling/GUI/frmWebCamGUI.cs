using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SrilankanTamilFingerSpelling.GUI
{
    /// <summary>
    /// In this class User have to select the letter from combobox 
    /// and have to start to sign infront of the Webcam
    /// if instance are identified as finger spelling
    /// which will add into the appropriate file 
    /// 
    /// </summary>
    /// 

    public partial class frmWebCamGUI : Form
    {

        public int queueCount = 0;
        int timespan = 0;
        Alphabet currentLetter = null;

        /// <summary>
        /// here 2 Image queues are intanciated first will collect the data from
        /// Webcam Stright away..2nd will collect the pre processed and selected signed Image into It
        /// </summary>

        Queue<Image> firstLevelQueue = new Queue<Image>();
        Queue<Image> secondLevelQueue = new Queue<Image>();



        List<Image> imageList = new List<Image>();


        FirstStageImageProcess firstProcess ;
        MotionDetector mottion = new MotionDetector();





        /// <summary>
        /// Tamil vowels, consonants, special character and grantha letters 
        /// </summary>

        #region Define Letter
        private static readonly string[] letters = 
        {
           "அ","ஆ","இ","ஈ","உ","ஊ","எ","ஏ","ஐ","ஒ","ஓ","ஔ",
           
           "ஃ",
           
            
           "க்","ங்","ச்","ஞ்" ,"ட்","ண்","த்","ந்" ,"ப்" ,"ம்" ,"ய்" ,"ர்", "ல்" ,"வ்","ழ்", "ள்", "ற்","ன்",
           
               
                
           "ஷ்","ஹ்","ஜ்","ஸ்"
       
        };
        #endregion



        /// <summary>
        /// this method this the Auto Difined method 
        /// </summary>



        
        public frmWebCamGUI()
        {
            InitializeComponent();
        }








        private void frmWebCamGUI_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;
            button1.Enabled = false;

            cboAplhabet.Items.AddRange(letters);
            cboAplhabet.SelectedIndex = 0;

            currentLetter = Alphabet.GetLetter(cboAplhabet.SelectedIndex);
            
            
            
            
            this.webCam.CaptureHeight = this.picSource.Height;
            this.webCam.CaptureWidth = this.picSource.Width;
            this.webCam.TimeToCapture_milliseconds = (1000/3);
            webCam.Start(0);
            webCam.Stop();
            
            
            
            
            mottion.MotionLevelCalculation = true;


                      


        }



        /// <summary>
        /// this method will change the alphabet instance to currentLetter
        /// </summary>


        private void cboAplhabet_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLetter = Alphabet.GetLetter(cboAplhabet.SelectedIndex);
            queueCount = 0;
            
        }






        private void webCamera_ImageCaptured(object source, WebCamUserController.WebcamEventArgs e)
        {



            this.picSource.Image = e.WebCamImage;
            firstLevelQueue.Enqueue(e.WebCamImage);

        }



        private void MotionDetectionTimer_Tick(object sender, EventArgs e)
        {



            /// If First Level Queue has more than four Images 
            /// this will start to process on the images on that
            /// 

            if (firstLevelQueue.Count > 4)
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
                        AddInstanceToFileTimer.Start();// starting the timer to add instance in file 

                    }
                }



                temImage.Dispose();
                temImage2.Dispose();
            }




          
            


      







        }// end of method


  



        private void button1_Click(object sender, EventArgs e)
        {
            webCam.Stop();
            MotionDetectionTimer.Stop();
            button2.Enabled = true;
        }

       



        private void button3_Click(object sender, EventArgs e)
        {
            webCam.Start(0);

            button1.Enabled = true;
        }

        private void AddInstanceToFileTimer_Tick(object sender, EventArgs e)
        {

            try
            {
                if (secondLevelQueue.Count>0)
                {
                    currentLetter.AddInstance(secondLevelQueue.Dequeue());
                }

            }
            catch (Exception exeptionAtAddInstanceToFileTimer_Tick)
            {
                
                Console.WriteLine("Error has been occord in Adding instance into file");
            }


            
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
