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

        public LSB()
        {
            base.EncryptView = new LSBEncryptControl();
            base.DecryptView = new LSBDecryptControl();
            base.Name = "LSB";
        }

        private void setData()
        {
            FileStream fs = new FileStream(filenameIn, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            header = new Header();
            header.data = br.ReadBytes(Util.samplesOffsetWav);

            //los samples empiezan a partir del offset 44. (en los wav)
            int numBytes = ((int) new FileInfo(filenameIn).Length) - Util.samplesOffsetWav;
            byte[] buffer = br.ReadBytes((int)numBytes);

            int numSamples = (numBytes * 8 / Util.bitsPerSample);
            samples = new Sample[numSamples];
            
            int j = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                samples[i] = new Sample(buffer[j++], buffer[j++]);
                //String s = samples[i].ToString();
            }

            fs.Close();
        }


        public override void encrypt(String message, String key)
        {
            Sample[] output = new Sample[samples.Length];

            output = samples.Clone() as Sample[];

            LSBEncryptControl encryptView = base.EncryptView as LSBEncryptControl;

            int bitsPerSampleMessage = int.Parse(encryptView.bitPerSampleMessageTextBox.Text);

            int seed = int.Parse(encryptView.seedTextBox.Text);
            Random rnd = new Random(seed);
            List<int> usedIndexSamples = new List<int>();

            byte[] xoredMessage = Util.XorMessageWithKey(Encoding.ASCII.GetBytes(message), key);
            BitArray xoredMessageArray = new BitArray(xoredMessage);

            int messageBitArrayIndex = 0;
            
            while (messageBitArrayIndex < xoredMessageArray.Length)
            {
                int sampleIndex = Util.generateUnusedIndex(rnd, usedIndexSamples, samples.Length);

                Sample s1 = samples[sampleIndex];

                for (int t = Util.bitsPerSample - bitsPerSampleMessage; t < Util.bitsPerSample ; t++)
                {
                    output[sampleIndex].data[t] = xoredMessageArray[messageBitArrayIndex++];
                }
            }

            FileStream fs = new FileStream(filenameOut, FileMode.Create | FileMode.CreateNew, FileAccess.ReadWrite);

            fs.Write(header.data, 0, header.data.Length);

            int numBytes = Util.getFileSize(filenameIn) - Util.samplesOffsetWav;
            byte[] finalDataWav = new byte[numBytes];
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


        public override void decrypt(String key)
        {
            LSBDecryptControl decryptView = base.DecryptView as LSBDecryptControl;

            int bitsPerSampleMessage = int.Parse(decryptView.bitPerSampleMessageTextBox.Text);
            int messageLength = int.Parse(decryptView.numCharTextBox.Text);
            int seed = int.Parse(decryptView.seedTextBox.Text);

            Random rnd = new Random(seed);
            List<int> usedIndexSamples = new List<int>();

            int size = messageLength * 8;
            BitArray xoredMessageArray = new BitArray(size);

            int bitCount = 0;
            while (bitCount < size)
            {
                int sampleIndex = Util.generateUnusedIndex(rnd, usedIndexSamples, samples.Length);

                Sample s = samples[sampleIndex];

                for (int t = Util.bitsPerSample - bitsPerSampleMessage; t < Util.bitsPerSample; t++)
                {
                    xoredMessageArray[bitCount++] = s.data[t];
                }
            }

            byte[] messageXor = Util.ToByteArray(xoredMessageArray);
            byte[] message = Util.XorMessageWithKey(messageXor, key);

            string res = Encoding.ASCII.GetString(message);

            Main m = decryptView.Parent.Parent.Parent.Parent.Parent as Main;

            m.textBox1.Text = res;
        }


        public override void init(string fileInput, String fileOutput)
        {
            base.filenameIn = fileInput;
            base.filenameOut = fileOutput;

            setData();

            LSBEncryptControl encrypyView = base.EncryptView as LSBEncryptControl;

            int bitPerSampleMessage = int.Parse(encrypyView.bitPerSampleMessageTextBox.Text);

            float maxMessage = (samples.Length*bitPerSampleMessage)/8;

            encrypyView.infoLabel.Text = "Longitud máxima del mensaje: " + maxMessage + " caracteres";
        }

    }
}
