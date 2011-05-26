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
            int BitsPerSampleLSBDecrypt = 1;
            try
            {
                BitsPerSampleLSBDecrypt = int.Parse(bitPerSampleMessageTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.BitsPerSampleLSBDecrypt = BitsPerSampleLSBDecrypt;
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
    }
}
