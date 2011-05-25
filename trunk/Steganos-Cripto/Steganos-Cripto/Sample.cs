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
            data = new BitArray(State.Instance.BitsPerSample);
            for (int i = 0; i < 8; i++)
            {
                data[15-i] = (b1 & (1<<i)) >= 1;
                data[7-i] = (b2 & (1<<i)) >= 1;
            }
        }

        public override string ToString()
        {
            byte[] value = Util.ToByteArray(this.data);
            return String.Format("0x{0:X2} 0x{1:X2}", value[0], value[1]);
        }

    }
}
