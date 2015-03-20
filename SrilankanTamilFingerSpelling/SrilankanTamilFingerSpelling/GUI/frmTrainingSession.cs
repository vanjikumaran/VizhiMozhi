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
using NeuronDotNet.Core;
using NeuronDotNet.Core.Backpropagation;
using CoreLetter;

namespace SrilankanTamilFingerSpelling.GUI
{

    /// <summary>
    /// this class is to train the trainging set into nueralnetwork and 
    /// sorrt the instance in the traing set !!!
    /// </summary>

    public partial class frmTrainingSession : Form
    {

        #region Difining the varibles
       
        /// <summary>
        /// Difine the reffernce type and vaule type
        /// </summary>


        Alphabet currentLetter = null;

        #region Difine the Letters
            private static readonly string[] letters = 
            {
                "அ","ஆ","இ","ஈ","உ","ஊ","எ","ஏ","ஐ","ஒ","ஓ","ஔ",
           
               
                "ஃ",
           
            
                "க்","ங்","ச்","ஞ்" ,"ட்","ண்","த்","ந்" ,"ப்" ,"ம்" ,"ய்" ,"ர்", "ல்" ,"வ்","ழ்", "ள்", "ற்","ன்",
           
               
                
                "ஷ்","ஹ்","ஜ்","ஸ்"
       
           };

        #endregion
        
        
        
        #endregion
        
        #region Initialization
        
            public frmTrainingSession()
            {
                
                InitializeComponent();
            }
       
        #endregion
        
        #region LoadMethod
            private void frmTrainingSession_Load(object sender, EventArgs e)
            {
                cboAplhabet.Items.AddRange(letters);
                cboAplhabet.SelectedIndex = 0;
                currentLetter = Alphabet.GetLetter(cboAplhabet.SelectedIndex);
            }
    

        #endregion

        #region SetLable

            private void SetLabels()
            {
                try
                {
                    lblOf.Text = (currentLetter.InstanceIndex + 1) + " of " + currentLetter.InstancesCount.ToString();
                    picProcessedImage.Image = currentLetter.CurrentInstance;
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Exeption occured in SetLable Method");
                }
                
               
            }

        #endregion

        #region NextMethod
            private void btnNext_Click(object sender, EventArgs e)
            {
                currentLetter.MoveNext();
                SetLabels();
            }
        #endregion

        #region PreviosMethod
            private void btnPrevious_Click(object sender, EventArgs e)
            {
                currentLetter.MovePrevious();
                SetLabels();
            }
        #endregion

        #region RemoveCurrentInstance
            private void btnRemove_Click(object sender, EventArgs e)
            {

                if (MessageBox.Show("Are you sure to remove current instance?", "Confirm Removal", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    currentLetter.RemoveCurrentInstance();
                    SetLabels();

                }



            }
         #endregion

        #region RemoveAllInstance
            private void btnRemoveAll_Click(object sender, EventArgs e)
            {
                try
                {
                     if (MessageBox.Show("Are you sure?", "Confirm Removal", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                     {
                        currentLetter.RemoveAll();
                        SetLabels();

                     }
                }
                
                catch (Exception exeptionInRemoveAllInstance)
                {
                    Console.WriteLine("Exeption occored in Remove all instance");

                   
                }
            }
    
        #endregion

        #region LoadLetter in Combo Box
            private void LoadLetter(object sender, EventArgs e)
            {
                currentLetter = Alphabet.GetLetter(cboAplhabet.SelectedIndex);
                SetLabels();
            }
        #endregion


        #region Disable all buttons
            private void disableAll() {

                cboAplhabet.Enabled = false;
                btnExit.Enabled = false;
                btnPrevious.Enabled = false;
                btnRemove.Enabled = false;
                btnTrain.Enabled = false;
                btnRemoveAll.Enabled = false;
                btnNext.Enabled = false;

            }
            #endregion


        #region Enable all buttons
            private void enableAll()
            {
                cboAplhabet.Enabled = true;
                btnExit.Enabled = true;
                btnPrevious.Enabled = true;
                btnRemove.Enabled = true;
                btnTrain.Enabled = true;
                btnRemoveAll.Enabled = true;
                btnNext.Enabled = true;

            }
            #endregion

        #region Training Command Method
            private void btnTrain_Click(object sender, EventArgs e)
            {

                disableAll();
                


                int cycles = 200;

                if (!int.TryParse(txtCycles.Text, out cycles)) { cycles = 200; }

                txtCycles.Text = cycles.ToString();

                int currentCombination = 0;


                int totalCombinations = Alphabet.LetterCount * (Alphabet.LetterCount - 1) / 2;

                for (int i = 0; i < Alphabet.LetterCount; i++)
                {
                    for (int j = i + 1; j < Alphabet.LetterCount; j++)
                    {
                       
                        
                        ////coded on 5th august 2010
                        //ActivationLayer inputLayer = new LinearLayer(10000);
                        //ActivationLayer hiddenLayer = new SigmoidLayer(1000);
                        //ActivationLayer hiddenLayer2 = new SigmoidLayer(4);
                        //ActivationLayer outputLayer = new SigmoidLayer(2);

                        //new BackpropagationConnector(inputLayer, hiddenLayer);
                        //new BackpropagationConnector(hiddenLayer, hiddenLayer2);
                        //new BackpropagationConnector(hiddenLayer2, outputLayer);

                        //BackpropagationNetwork network = new BackpropagationNetwork(inputLayer, outputLayer);

                        //TrainingSet trainingSet = new TrainingSet(10000, 2);
                        //// code end





                        
                        ActivationLayer inputLayer = new LinearLayer(30);
                        ActivationLayer hiddenLayer = new SigmoidLayer(4);
                        ActivationLayer outputLayer = new SigmoidLayer(2);



                        new BackpropagationConnector(inputLayer, hiddenLayer);
                        new BackpropagationConnector(hiddenLayer, outputLayer);

                        BackpropagationNetwork network = new BackpropagationNetwork(inputLayer, outputLayer);

                        TrainingSet trainingSet = new TrainingSet(30, 2);


                        Alphabet ithLetter = Alphabet.GetLetter(i);
                        Alphabet jthLetter = Alphabet.GetLetter(j);



                        foreach (System.Drawing.Image instance in ithLetter.Instances)
                        {

                            trainingSet.Add(new TrainingSample(getGetEquivalentVector(instance), new double[] { 1d, 0d }));



                        }
                        foreach (System.Drawing.Image instance in jthLetter.Instances)
                        {
                            trainingSet.Add(new TrainingSample(getGetEquivalentVector(instance), new double[] { 0d, 1d }));
                        }

                       progressTraining.Value = 100 * currentCombination / totalCombinations;

                        Application.DoEvents();

                        bool correct = false;

                        int currentCycles = 35;
                        int count = trainingSet.TrainingSampleCount;

                        while (correct == false & currentCycles <= cycles)
                        {
                            network.Initialize();
                            network.Learn(trainingSet, currentCycles);
                            correct = true;
                            for (int sampleIndex = 0; sampleIndex < count; sampleIndex++)
                            {
                                double[] op = network.Run(trainingSet[sampleIndex].InputVector);
                                if (((trainingSet[sampleIndex].OutputVector[0] > trainingSet[sampleIndex].OutputVector[1]) && op[0] - op[1] < 0.4) || ((trainingSet[sampleIndex].OutputVector[0] < trainingSet[sampleIndex].OutputVector[1]) && op[1] - op[0] < 0.4))
                                {
                                    correct = false;
                                    trainingSet.Add(trainingSet[sampleIndex]);
                                }
                            }
                            currentCycles *= 2;
                        }

                        lstLog.Items.Add(cboAplhabet.Items[i] + " & " + cboAplhabet.Items[j] + " = " + network.MeanSquaredError.ToString("0.0000"));
                        lstLog.TopIndex = lstLog.Items.Count - (int)(lstLog.Height / lstLog.ItemHeight);
                        try
                        {
                            using (Stream stream = File.Open(Application.StartupPath + @"\Networks\" + i.ToString("00") + j.ToString("00") + ".ndn", FileMode.Create))
                            {
                                IFormatter formatter = new BinaryFormatter();
                                formatter.Serialize(stream, network);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Failed to save trained neural networks", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        currentCombination++;
                    }
                }
                progressTraining.Value = 0;
                enableAll();
           }
        #endregion

        #region Get Image Vector Space in Double Array
        
           public double[] getGetEquivalentVector(System.Drawing.Image processingImage)
            {

               ///////////Codeed on 5th august 2010
               //////// Bitmap image = new Bitmap(processingImage);
               //////// ResizeNearestNeighbor resize = new ResizeNearestNeighbor(100, 100);
               //////// Processors.ConvertToDouble newConvetedArray = new SrilankanTamilFingerSpelling.Processors.ConvertToDouble();
               //////// return newConvetedArray.convertIt(resize.Apply(image));
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

        
        #region Button Exit
           private void btnExit_Click(object sender, EventArgs e)
           {
               if (MessageBox.Show("Are you sure to close this?", "Confirm Close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
               {
                   this.Close();
               }
           }

           #endregion
    }
}
