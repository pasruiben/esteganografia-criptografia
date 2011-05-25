using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Steganos_Cripto
{
    class FileUtil
    {
        public static int getFileSize(String fileName)
        {
            return (int)new FileInfo(fileName).Length;
        }
    }
}
