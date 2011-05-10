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
        public Control view { get; set; }

        public abstract void init(String fileInput);
        public abstract void run(String fileOutput, String message, String key);
    }
}
