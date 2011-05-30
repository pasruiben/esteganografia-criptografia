using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganos_Cripto
{
    public partial class LSBDecryptControl : UserControl
    {
        public LSBDecryptControl()
        {
            InitializeComponent();
        }

        private void bitPerSampleMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int BitsPerSampleLSB = int.Parse(bitPerSampleMessageTextBox.Text);
                if (!(BitsPerSampleLSB >= 1 && BitsPerSampleLSB <= State.Instance.BitsPerSample)) throw new Exception();

                State.Instance.BitsPerSampleLSBDecrypt = BitsPerSampleLSB;

                Main.activeAlgorithm.update();
            }
            catch (Exception) { }
        }

        private void seedTextBox_TextChanged(object sender, EventArgs e)
        {
            int SeedLSBDecrypt = 1;
            try
            {
                SeedLSBDecrypt = int.Parse(seedTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.SeedLSBDecrypt = SeedLSBDecrypt;
        }

        private void numCharTextBox_TextChanged(object sender, EventArgs e)
        {
            int messageLength = 1;
            try
            {
                messageLength = int.Parse(numCharTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.MessageLengthLSBDecrypt = messageLength;
        }

        private void LSBDecryptControl_Load(object sender, EventArgs e)
        {
            Main.activeAlgorithm.update();
        }
    }
}
