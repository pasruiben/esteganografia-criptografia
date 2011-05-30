using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steganos_Cripto
{
    public sealed class State
    {
        #region Singleton
        private static readonly State instance = new State();

        private State() { }

        public static State Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        public String FileNameIn { get; set; }
        public String FileNameOut { get; set; }
        public int BitsPerSample { get; set; }

        public int BitsPerSampleLSBEncrypt { get; set; }
        public int BitsPerSampleLSBDecrypt { get; set; }

        public int SamplesPerRegionParityEncrypt { get; set; }
        public int SamplesPerRegionParityDecrypt { get; set; }

        public int SeedLSBEncrypt { get; set; }
        public int SeedLSBDecrypt { get; set; }

        public int SeedParityEncrypt { get; set; }
        public int SeedParityDecrypt { get; set; }

        public int MessageLengthLSBDecrypt { get; set; }
        public int MessageLengthParityDecrypt { get; set; }

        public int MaxMessageLengthLSBEncrypt { get; set; }
        public int MaxMessageLengthParityEncrypt { get; set; }

        public int MaxMessageLengthLSBDecrypt { get; set; }
        public int MaxMessageLengthParityDecrypt { get; set; }

    }
}
