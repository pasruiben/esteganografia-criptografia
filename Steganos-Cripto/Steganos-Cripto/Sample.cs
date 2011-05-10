using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Steganos_Cripto
{
    class Sample
    {
        public BitArray data { get; set; }

        public Sample(byte b1, byte b2)
        {
            data = new BitArray(16);
            for (int i = 0; i < 8; i++)
            {
                data[15-i] = (b1 & (1>>i)) == 1;
                data[7-i] = (b2 & (1>>i)) == 1;
            }
        }

    }
}
