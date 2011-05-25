using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steganos_Cripto
{
    class Xor
    {
        public static byte[] XorMessageWithKey(byte[] message, string key)
        {
            byte[] res = new byte[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                res[i] = (byte)(message[i] ^ key[i % key.Length]);
            }

            return res;
        }
    }
}
