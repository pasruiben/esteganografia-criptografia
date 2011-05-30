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
    public partial class LSBEncryptControl : UserControl
    {
        public LSBEncryptControl()
        {
            InitializeComponent();
        }

        private void updateInfo()
        {
            int BitsPerSampleLSBEncrypt = State.Instance.BitsPerSampleLSBEncrypt;
            int numSamples = WavProcessor.numSamples(State.Instance.FileNameIn);
            int maxMessageLengthLSB = (numSamples * BitsPerSampleLSBEncrypt) / 8;

            infoLabel.Text = "Longitud máxima del mensaje: " + maxMessageLengthLSB + " caracteres";
        }

        private void bitPerSampleMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int BitsPerSampleLSBEncrypt = int.Parse(bitPerSampleMessageTextBox.Text);
                if (!(BitsPerSampleLSBEncrypt >= 1 && BitsPerSampleLSBEncrypt <= State.Instance.BitsPerSample)) throw new Exception();

                State.Instance.BitsPerSampleLSBEncrypt = BitsPerSampleLSBEncrypt;

                updateInfo();
            }
            catch (Exception) { }
        }

        private void seedTextBox_TextChanged(object sender, EventArgs e)
        {
            int SeedLSBEncrypt = 1;
            try
            {
                SeedLSBEncrypt = int.Parse(seedTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.SeedLSBEncrypt = SeedLSBEncrypt;
        }

        private void LSBEncryptControl_Load(object sender, EventArgs e)
        {
            updateInfo();
        }
    }
}
