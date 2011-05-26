using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganos_Cripto
{
    public abstract class Algorithm
    {
        public String Name { get; set; }
        public Control EncryptView { get; set; }
        public Control DecryptView { get; set; }

        public abstract void init();

        public abstract void encrypt(String message, String key);
        public abstract String decrypt(String key);

        public override string ToString()
        {
            return Name;
        }
    }
}
