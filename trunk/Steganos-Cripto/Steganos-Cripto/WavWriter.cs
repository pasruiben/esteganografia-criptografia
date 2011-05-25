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
            FileStream fs = new FileStream(filename, FileMode.Create | FileMode.CreateNew, FileAccess.ReadWrite);

            fs.Write(header.data, 0, header.data.Length);

            int numBytes = FileUtil.getFileSize(filename) - samplesOffsetWav;
            byte[] finalDataWav = new byte[numBytes];
            int j = 0;
            foreach (Sample s in samples)
            {
                byte[] d = Util.ToByteArray(s.data);
                for (int i = 1; i >= 0; i--)
                {
                    finalDataWav[j++] = d[i];
                }
            }

            fs.Write(finalDataWav, 0, finalDataWav.Length);

            fs.Close();
        }
    }
}
