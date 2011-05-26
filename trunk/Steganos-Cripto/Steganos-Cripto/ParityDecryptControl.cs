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
    public partial class ParityDecryptControl : UserControl
    {
        public ParityDecryptControl()
        {
            InitializeComponent();
        }

        private void samplesPerRegionTextBox_TextChanged(object sender, EventArgs e)
        {
            int SamplesPerRegionParityDecrypt = 1;
            try
            {
                SamplesPerRegionParityDecrypt = int.Parse(samplesPerRegionTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.SamplesPerRegionParityDecrypt = SamplesPerRegionParityDecrypt;
        }

        private void seedTextBox_TextChanged(object sender, EventArgs e)
        {
            int SeedParityDecrypt = 1;
            try
            {
                SeedParityDecrypt = int.Parse(seedTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.SeedParityDecrypt = SeedParityDecrypt;
        }

        private void numCharTextBox_TextChanged(object sender, EventArgs e)
        {
            int messageLength = 1;
            try
            {
                messageLength = int.Parse(numCharTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.MessageLengthParityDecrypt = messageLength;
        }
    }
}
