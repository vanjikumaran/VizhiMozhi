using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Drawing;

using CoreLetter;

namespace SrilankanTamilFingerSpelling
{ 
    
    public class Alphabet
    {

      
        private int instanceIndex;
        private readonly int letterIndex;
                
        private readonly List<Image> instances;
        
        
        private static readonly Alphabet[] letters = new Alphabet[LetterCount];

        public const int LetterCount = 35;

        public int InstanceIndex
        {
            get { return instanceIndex; }
        }

        public int LetterIndex
        {
            get { return letterIndex; }
        }

        public int InstancesCount
        {
            get { return instances.Count; }
        }

        public Image CurrentInstance
        {
            get
            {
                if (instanceIndex >-1) { return instances[instanceIndex]; }

                else return null;
            
            }
        }

        public IEnumerable<Image> Instances
        {
            get
            {
                for (int i = 0; i < instances.Count; i++)
                {
                    yield return instances[i];
                }
            }
        }

        private Alphabet(int letterIndex)
        {
            this.letterIndex = letterIndex;

            using (Stream stream = File.Open(Path(letterIndex), FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                
               
                
                
                
                this.instances = formatter.Deserialize(stream) as List<Image>;
                this.instanceIndex = (this.instances.Count == 0) ? -1 : 0;
            }
        }

        private static string Path(int letterIndex)
        {
            return Application.StartupPath + @"\Letters\" + letterIndex.ToString("00") + ".ltr";
        }

        public static Alphabet GetLetter(int index)
        {
            if (letters[index] == null)
            {
                letters[index] = new Alphabet(index);
            }
            return letters[index];
        }

        public void MoveNext()
        {
            if (this.instances.Count != 0)
            {
                instanceIndex = (instanceIndex + 1) % this.instances.Count;
            }
        }

        public void MovePrevious()
        {
            if (this.instances.Count != 0)
            {
                instanceIndex = (instanceIndex - 1 + this.instances.Count) % this.instances.Count;
            }
        }

        public void SetIndex(int index)
        {
            instanceIndex = index;
        }

        public void AddInstance(Image instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            this.instances.Add(instance);
            this.instanceIndex = this.instances.Count - 1;
            Save();
        }

        public void RemoveCurrentInstance()
        {
            if (instanceIndex >= 0)
            {
                instances.RemoveAt(instanceIndex);
                if (instanceIndex == instances.Count) { this.instanceIndex--; }
                Save();
            }
        }

        public void RemoveAll()
        {
            instances.Clear();
            instanceIndex = -1;
            Save();
        }

        private void Save()
        {
            using (Stream stream = File.Open(Path(letterIndex), FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, instances);
            }
        }
    }
}
