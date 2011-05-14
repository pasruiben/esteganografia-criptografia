using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace Steganos_Cripto
{
    class LSB : Algorithm
    {
        Header header = null;
        Sample[] samples = null;

        int bitsPerSample = 16;

        public LSB()
        {
            base.view = new LSBControl();
            base.Name = "LSB";
        }

        private void setSamples(String fileInput)
        {
            FileStream fs = new FileStream(fileInput, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            header = new Header();
            header.data = br.ReadBytes(44);

            //los samples empiezan a partir del offset 44. (en los wav)
            int numBytes = ((int) new FileInfo(fileInput).Length) - 44;
            byte[] buffer = br.ReadBytes((int)numBytes);

            int numSamples = (numBytes * 8 / bitsPerSample);
            samples = new Sample[numSamples];
            
            int j = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                samples[i] = new Sample(buffer[j++], buffer[j++]);
                //String s = samples[i].ToString();
            }

            fs.Close();
        }


        public override void run(String fileOutput, String message, String key)
        {
            Sample[] output = new Sample[samples.Length];

            output = samples.Clone() as Sample[];

            LSBControl view = base.view as LSBControl;

            int bitsPerSampleMessage = int.Parse(view.bitPerSampleMessageTextBox.Text);

            int seed = int.Parse(view.seedTextBox.Text);
            Random rnd = new Random(seed);
            List<int> usedIndexSamples = new List<int>();

            byte[] xoredMessage = Util.XorMessageWithKey(message, key);
            BitArray xoresMessageArray = new BitArray(xoredMessage);

            int messageBitArrayIndex = 0;
            
            while (messageBitArrayIndex < xoresMessageArray.Length)
            {
                int sampleIndex = generateSampleIndex(rnd, usedIndexSamples);
                usedIndexSamples.Add(sampleIndex);

                Sample s = samples[sampleIndex];

                for (int t = bitsPerSample - bitsPerSampleMessage; t < bitsPerSample ; t++)
                {
                    output[sampleIndex].data[t] = s.data[t] ^ xoresMessageArray[messageBitArrayIndex++];
                }
            }

            FileStream fs = new FileStream(fileOutput, FileMode.Create | FileMode.CreateNew, FileAccess.ReadWrite);

            fs.Write(header.data, 0, header.data.Length);

            byte[] finalDataWav = new byte[samples.Length * 2];
            int j = 0;
            foreach (Sample s in samples)
            {
                byte[] d = Util.ToByteArray(s.data); 
                for(int i = 1 ; i >= 0 ; i--)
                {
                    finalDataWav[j++] = d[i];
                }
            }

            fs.Write(finalDataWav, 0, finalDataWav.Length);

            fs.Close();
        }


        private int generateSampleIndex(Random rnd, List<int> usedIndexSamples)
        {
            int sampleIndex;
            do
            {
                sampleIndex = rnd.Next(samples.Length);
            }
            while (usedIndexSamples.Contains(sampleIndex));

            return sampleIndex;
        }


        public override void init(string fileInput)
        {
            LSBControl view = base.view as LSBControl;

            setSamples(fileInput);

            int bitPerSampleMessage = int.Parse(view.bitPerSampleMessageTextBox.Text);

            float maxMessage = (samples.Length*bitPerSampleMessage)/8;

            view.infoLabel.Text = "Longitud máxima del mensaje: " + maxMessage + " caracteres";
        }

        public override string ToString()
        {
            return "LSB";
        }
    }
}
