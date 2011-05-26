using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Steganos_Cripto
{
    class WavProcessor
    {
        public static readonly int samplesOffsetWav = 44;

        public Header header { get; set; }
        public Sample[] samples { get; set; }


        public WavProcessor(String filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            header = new Header();
            header.data = br.ReadBytes(samplesOffsetWav);

            //los samples empiezan a partir del offset 44. (en los wav)
            int numBytes = FileUtil.getFileSize(filename) - samplesOffsetWav;
            byte[] buffer = br.ReadBytes((int)numBytes);

            int numSamples = (numBytes * 8 / State.Instance.BitsPerSample);
            samples = new Sample[numSamples];

            int j = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                samples[i] = new Sample(buffer[j++], buffer[j++]);
            }

            fs.Close();
        }

        public static int numSamples(String filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            br.BaseStream.Seek(40, SeekOrigin.Begin);
            ulong numBytesSamples = br.ReadUInt64();

            fs.Close();

            return (int)(8 * numBytesSamples / (ulong)State.Instance.BitsPerSample);
        }

    }
}
