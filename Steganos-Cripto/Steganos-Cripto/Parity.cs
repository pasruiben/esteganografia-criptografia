using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace Steganos_Cripto
{

    class Parity : Algorithm
    {
        Header header = null;
        IList<Sample[]> regions = null;

        public Parity()
        {
            base.EncryptView = new ParityEncryptControl();
            base.DecryptView = new ParityDecryptControl();

            base.Name = "Parity";
        }


        public override void init(string fileInput, String fileOutput)
        {
            base.filenameIn = fileInput;
            base.filenameOut = fileOutput;


            ParityEncryptControl encrypyView = base.EncryptView as ParityEncryptControl;

            int samplesPerRegion = int.Parse(encrypyView.samplesPerRegionTextBox.Text);

            int numBytes = Util.getFileSize(fileInput) - Util.samplesOffsetWav;
            int numSamples = (numBytes * 8 / Util.bitsPerSample);
            int numRegions = numSamples / samplesPerRegion;

            setData(numBytes, numSamples, numRegions, samplesPerRegion);

            float maxMessage = numRegions / 8;

            encrypyView.infoLabel.Text = "Longitud máxima del mensaje: " + maxMessage + " caracteres";
        }


        private void setData(int numBytes, int numSamples, int numRegions, int samplesPerRegion)
        {
            header = new Header();
            regions = new List<Sample[]>();

            FileStream fs = new FileStream(filenameIn, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            header.data = br.ReadBytes(Util.samplesOffsetWav);
            byte[] buffer = br.ReadBytes((int)numBytes);

            int j = 0;
            for (int t = 0; t < numRegions; t++)
            {
                Sample[] samples = new Sample[samplesPerRegion];

                for (int i = 0; i < samples.Length; i++)
                {
                    samples[i] = new Sample(buffer[j++], buffer[j++]);
                }
                regions.Add(samples);
            }

            int rest = numSamples % numRegions;

            if (rest != 0)
            {
                Sample[] samples = new Sample[rest];
                for (int i = 0; i < samples.Length; i++)
                {
                    samples[i] = new Sample(buffer[j++], buffer[j++]);
                }
                regions.Add(samples);
            }

            fs.Close();
        }

        public override void encrypt(String message, String key)
        {
            IList<Sample[]> output = null;

            output = new List<Sample[]>();

            foreach (Sample[] s in regions)
            {
                regions.Add(s.Clone() as Sample[]);
            }

            ParityEncryptControl encryptView = base.EncryptView as ParityEncryptControl;

            int seed = int.Parse(encryptView.seedTextBox.Text);
            Random rnd = new Random(seed);
            List<int> usedIndexRegions = new List<int>();

            Random rnd2 = new Random((int)DateTime.Now.Ticks);

            byte[] xoredMessage = Util.XorMessageWithKey(Encoding.ASCII.GetBytes(message), key);
            BitArray xoredMessageArray = new BitArray(xoredMessage);

            int messageBitArrayIndex = 0;
            while (messageBitArrayIndex < xoredMessageArray.Length)
            {
                int regionIndex = Util.generateUnusedIndex(rnd, usedIndexRegions, regions.Count);
                
                Sample[] s1 = regions[regionIndex];

                bool parity = Util.Parity(s1);

                if(parity != xoredMessageArray[messageBitArrayIndex])
                {
                    int sampleIndex = rnd2.Next(s1.Length);
                    output[regionIndex][sampleIndex].data[Util.bitsPerSample - 1] = !output[regionIndex][sampleIndex].data[Util.bitsPerSample - 1];
                }  
            
                messageBitArrayIndex++;
            }

            FileStream fs = new FileStream(filenameOut, FileMode.Create | FileMode.CreateNew, FileAccess.ReadWrite);
            fs.Write(header.data, 0, header.data.Length);

            int numBytes = Util.getFileSize(filenameIn) - Util.samplesOffsetWav;
            byte[] finalDataWav = new byte[numBytes];

            int j = 0;
            foreach (Sample[] s1 in regions)
            {
                foreach (Sample s in s1)
                {
                    byte[] d = Util.ToByteArray(s.data);
                    for (int i = 1; i >= 0; i--)
                    {
                        finalDataWav[j++] = d[i];
                    }
                }
            }

            fs.Write(finalDataWav, 0, finalDataWav.Length);

            fs.Close();
        }

        public override void decrypt(String key)
        {


        }
    }
}
