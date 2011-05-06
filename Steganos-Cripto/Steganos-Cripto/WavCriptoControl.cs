using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Steganos_Cripto
{
    public partial class WavCriptoControl : UserControl
    {
        static String OriginalFilename = null;
        static String ModifiedFilename = null;

        public WavCriptoControl(String filename)
        {
            InitializeComponent();

            OriginalFilename = filename;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(OriginalFilename);
            simpleSound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(OriginalFilename);
            simpleSound.Play();
        }
    }
}
