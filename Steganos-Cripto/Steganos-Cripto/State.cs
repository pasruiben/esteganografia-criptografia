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
    }
}
