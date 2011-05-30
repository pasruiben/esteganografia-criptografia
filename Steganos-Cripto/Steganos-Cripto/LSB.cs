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

            int bitPerSampleMessage = State.Instance.BitsPerSampleLSBEncrypt;

            int numSamples = WavProcessor.numSamples(State.Instance.FileNameIn);
            float maxMessage = (numSamples * bitPerSampleMessage) / 8;

            encrypyView.infoLabel.Text = "Longitud máxima del mensaje: " + maxMessage + " caracteres";
        }

        public override void encrypt(String message, String key)
        {
            WavProcessor wProcessor = new WavProcessor(State.Instance.FileNameIn);
            Header header = wProcessor.header;
            Sample[] samples = wProcessor.samples;

            int bitsPerSampleMessage = State.Instance.BitsPerSampleLSBEncrypt;
            int seed = State.Instance.SeedLSBEncrypt;

            IndexRandomGenerator rnd = new IndexRandomGenerator(seed, samples.Length);

            byte[] messageBytes = null;
            if (key.Equals(""))
            {
                 messageBytes = Encoding.ASCII.GetBytes(message);
            }
            else
            {
                messageBytes = Xor.XorMessageWithKey(Encoding.ASCII.GetBytes(message), key);
            }

            BitArray xoredMessageArray = new BitArray(messageBytes);

            int messageBitArrayIndex = 0;
            
            while (messageBitArrayIndex < xoredMessageArray.Length)
            {
                int sampleIndex = rnd.generateUnusedIndex();

                Sample s1 = samples[sampleIndex];

                for (int t = State.Instance.BitsPerSample - bitsPerSampleMessage; t < State.Instance.BitsPerSample && messageBitArrayIndex < xoredMessageArray.Length; t++)
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

            int bitsPerSampleMessage = State.Instance.BitsPerSampleLSBDecrypt;
            int messageLength = State.Instance.MessageLengthLSBDecrypt;
            int seed = State.Instance.SeedLSBDecrypt;

            IndexRandomGenerator rnd = new IndexRandomGenerator(seed, samples.Length); ;

            int size = messageLength * 8;
            BitArray xoredMessageArray = new BitArray(size);

            int bitCount = 0;
            while (bitCount < size)
            {
                int sampleIndex = rnd.generateUnusedIndex();

                Sample s = samples[sampleIndex];

                for (int t = State.Instance.BitsPerSample - bitsPerSampleMessage; t < State.Instance.BitsPerSample && bitCount < size; t++)
                {
                    xoredMessageArray[bitCount++] = s.data[t];
                }
            }

            byte[] messageXor = Util.ToByteArray(xoredMessageArray);
            for (int i = 0; i < messageXor.Length; i++) messageXor[i] = BitReverser.Reverse(messageXor[i]);

            string res = "";

            if (!key.Equals(""))
            {
                res = Encoding.ASCII.GetString(Xor.XorMessageWithKey(messageXor, key));
            }

            res = Encoding.ASCII.GetString(messageXor);

            return res;
        }

    }
}
