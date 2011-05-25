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


        public override void init()
        {
            ParityEncryptControl encrypyView = base.EncryptView as ParityEncryptControl;

            int samplesPerRegion = int.Parse(encrypyView.samplesPerRegionTextBox.Text);

            initData(samplesPerRegion);

            float maxMessage = regions.Count / 8;

            encrypyView.infoLabel.Text = "Longitud máxima del mensaje: " + maxMessage + " caracteres";
        }

        private void initData(int samplesPerRegion)
        {
            WavProcessor wProcessor = new WavProcessor(State.Instance.FileNameIn);

            header = wProcessor.header;

            Sample[] samples = wProcessor.samples;

            int numRegions = samples.Length / samplesPerRegion;

            regions = new List<Sample[]>();


            int j = 0;
            for (int t = 0; t < numRegions; t++)
            {
                Sample[] s = new Sample[samplesPerRegion];

                for (int i = 0; i < s.Length; i++)
                {
                    s[i] = samples[j++];
                }
                regions.Add(s);
            }

            int rest = samples.Length % numRegions;

            if (rest != 0)
            {
                Sample[] s = new Sample[rest];
                for (int i = 0; i < samples.Length; i++)
                {
                    s[i] = samples[j++];
                }
                regions.Add(s);
            }
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
            IndexRandomGenerator rnd = new IndexRandomGenerator(seed, regions.Count);

            Random rnd2 = new Random((int)DateTime.Now.Ticks);

            byte[] xoredMessage = Xor.XorMessageWithKey(Encoding.ASCII.GetBytes(message), key);
            BitArray xoredMessageArray = new BitArray(xoredMessage);

            int messageBitArrayIndex = 0;
            while (messageBitArrayIndex < xoredMessageArray.Length)
            {
                int regionIndex = rnd.generateUnusedIndex();
                
                Sample[] s1 = regions[regionIndex];

                bool parity = CalculateParity(s1);

                if(parity != xoredMessageArray[messageBitArrayIndex])
                {
                    int sampleIndex = rnd2.Next(s1.Length);
                    output[regionIndex][sampleIndex].data[State.Instance.BitsPerSample - 1] = !output[regionIndex][sampleIndex].data[State.Instance.BitsPerSample - 1];
                }  
            
                messageBitArrayIndex++;
            }

            IList<Sample> outputSamples = new List<Sample>();
            foreach(Sample[] ss in regions)
            {
                foreach (Sample s in ss)
                {
                    outputSamples.Add(s);
                }
            }

            WavWriter.run(State.Instance.FileNameOut, header, outputSamples.ToArray<Sample>());
        }

        public override void decrypt(String key)
        {
            ParityDecryptControl decryptView = base.DecryptView as ParityDecryptControl;

            int messageLength = int.Parse(decryptView.numCharTextBox.Text);
            int seed = int.Parse(decryptView.seedTextBox.Text);

            IndexRandomGenerator rnd = new IndexRandomGenerator(seed, regions.Count);

            int size = messageLength * 8;
            BitArray xoredMessageArray = new BitArray(size);

            int bitCount = 0;
            while (bitCount < size)
            {
                int regionIndex = rnd.generateUnusedIndex();

                Sample[] s1 = regions[regionIndex];

                bool parity = CalculateParity(s1);

                xoredMessageArray[bitCount++] = parity;
            }

            byte[] messageXor = Util.ToByteArray(xoredMessageArray);
            byte[] message = Xor.XorMessageWithKey(messageXor, key);

            string res = Encoding.ASCII.GetString(message);

            Main m = decryptView.Parent.Parent.Parent.Parent.Parent as Main;

            m.textBox1.Text = res;
        }

        private bool CalculateParity(Sample[] s1)
        {
            bool res = false;

            foreach (Sample s in s1)
            {
                foreach (bool b in s.data)
                {
                    res ^= b;
                }
            }

            return res;
        }
    }
}
