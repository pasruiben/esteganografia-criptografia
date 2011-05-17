using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganos_Cripto
{
    abstract class Algorithm
    {
        public String Name { get; set; }
        public Control EncryptView { get; set; }
        public Control DecryptView { get; set; }

        public String filenameIn { get; set; }
        public String filenameOut { get; set; }

        public abstract void init(String fileInput, String fileOut);

        public abstract void encrypt(String message, String key);
        public abstract void decrypt(String key);

        public override string ToString()
        {
            return Name;
        }
    }
}
