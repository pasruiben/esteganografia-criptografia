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

        public LSB()
        {
            base.EncryptView = new LSBEncryptControl();
            base.DecryptView = new LSBDecryptControl();
            base.Name = "LSB";
        }

        public override void init()
        {
            LSBEncryptControl encrypyView = base.EncryptView as LSBEncryptControl;

            int bitPerSampleMessage = 0;
            try
            {
                bitPerSampleMessage = int.Parse(encrypyView.bitPerSampleMessageTextBox.Text);
            }
            catch (Exception) { }

            int numSamples = WavProcessor.numSamples(State.Instance.FileNameIn);
            float maxMessage = (numSamples * bitPerSampleMessage) / 8;

            encrypyView.infoLabel.Text = "Longitud máxima del mensaje: " + maxMessage + " caracteres";
        }

        public override void encrypt(String message, String key)
        {
            WavProcessor wProcessor = new WavProcessor(State.Instance.FileNameIn);
            Header header = wProcessor.header;
            Sample[] samples = wProcessor.samples;

            LSBEncryptControl encryptView = base.EncryptView as LSBEncryptControl;

            int bitsPerSampleMessage = int.Parse(encryptView.bitPerSampleMessageTextBox.Text);

            int seed = int.Parse(encryptView.seedTextBox.Text);
            IndexRandomGenerator rnd = new IndexRandomGenerator(seed, samples.Length);

            byte[] xoredMessage = Xor.XorMessageWithKey(Encoding.ASCII.GetBytes(message), key);
            BitArray xoredMessageArray = new BitArray(xoredMessage);

            int messageBitArrayIndex = 0;
            
            while (messageBitArrayIndex < xoredMessageArray.Length)
            {
                int sampleIndex = rnd.generateUnusedIndex();

                Sample s1 = samples[sampleIndex];

                for (int t = State.Instance.BitsPerSample - bitsPerSampleMessage; t < State.Instance.BitsPerSample; t++)
                {
                    samples[sampleIndex].data[t] = xoredMessageArray[messageBitArrayIndex++];
                }
            }

            WavWriter.run(State.Instance.FileNameOut, header, samples);
        }


        public override String decrypt(String key)
        {
            WavProcessor wProcessor = new WavProcessor(State.Instance.FileNameIn);
            Sample[] samples = wProcessor.samples;

            LSBDecryptControl decryptView = base.DecryptView as LSBDecryptControl;

            int bitsPerSampleMessage = int.Parse(decryptView.bitPerSampleMessageTextBox.Text);
            int messageLength = int.Parse(decryptView.numCharTextBox.Text);
            int seed = int.Parse(decryptView.seedTextBox.Text);

            IndexRandomGenerator rnd = new IndexRandomGenerator(seed, samples.Length); ;

            int size = messageLength * 8;
            BitArray xoredMessageArray = new BitArray(size);

            int bitCount = 0;
            while (bitCount < size)
            {
                int sampleIndex = rnd.generateUnusedIndex();

                Sample s = samples[sampleIndex];

                for (int t = State.Instance.BitsPerSample - bitsPerSampleMessage; t < State.Instance.BitsPerSample; t++)
                {
                    xoredMessageArray[bitCount++] = s.data[t];
                }
            }

            byte[] messageXor = Util.ToByteArray(xoredMessageArray);
            for (int i = 0; i < messageXor.Length; i++) messageXor[i] = BitReverser.Reverse(messageXor[i]);
            byte[] message = Xor.XorMessageWithKey(messageXor, key);

            string res = Encoding.ASCII.GetString(message);

            return res;
        }

    }
}
