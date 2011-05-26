using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steganos_Cripto
{
    class BitReverser
    {
        public static byte Reverse(byte inByte)
        {
            byte result = 0x00;
            byte mask = 0x00;

            for (mask = 0x80;
                                Convert.ToInt32(mask) > 0;
                                mask >>= 1)
            {
                result >>= 1;
                byte tempbyte = (byte)(inByte & mask);
                if (tempbyte != 0x00)
                    result |= 0x80;
            }
            return (result);
        }
    }
}
