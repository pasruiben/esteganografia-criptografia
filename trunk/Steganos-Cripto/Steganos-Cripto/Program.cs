using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Steganos_Cripto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            State.Instance.SeedLSBEncrypt = 55;
            State.Instance.SeedLSBDecrypt = 55;
            State.Instance.SeedParityEncrypt = 55;
            State.Instance.SeedParityDecrypt = 55;

            State.Instance.SamplesPerRegionParityEncrypt = 32;
            State.Instance.SamplesPerRegionParityDecrypt = 32;

            State.Instance.BitsPerSampleLSBEncrypt = 1;
            State.Instance.BitsPerSampleLSBDecrypt = 1;

            State.Instance.MessageLengthLSBDecrypt = 10;
            State.Instance.MessageLengthParityDecrypt = 10;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
