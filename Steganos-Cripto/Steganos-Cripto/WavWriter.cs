using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Steganos_Cripto
{
    class WavWriter
    {
        public static readonly int samplesOffsetWav = 44;

        public static void run(String filename, Header header, Sample[] samples)
        {
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            fs.Write(header.data, 0, header.data.Length);

            IList<byte> finalDataWav = new List<byte>();
            foreach (Sample s in samples)
            {
                byte[] d = Util.ToByteArray(s.data);

                if (State.Instance.BitsPerSample == 16)
                {
                    finalDataWav.Add(d[1]);
                }
                finalDataWav.Add(d[0]);
            }

            byte[] data = finalDataWav.ToArray<byte>();

            fs.Write(data, 0, data.Length);

            fs.Close();
        }
    }
}
