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
    public partial class ParityEncryptControl : UserControl
    {
        public ParityEncryptControl()
        {
            InitializeComponent();
        }

        private void updateInfo()
        {
            infoLabel.Text = "Longitud máxima del mensaje: " + State.Instance.MaxMessageLengthParityEncrypt + " caracteres";
        }

        private void samplesPerRegionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int samplesPerRegion = int.Parse(samplesPerRegionTextBox.Text);
                int numSamples = WavProcessor.numSamples(State.Instance.FileNameIn);
                if (!(samplesPerRegion >= 1 && samplesPerRegion <= numSamples)) throw new Exception();

                State.Instance.SamplesPerRegionParityEncrypt = samplesPerRegion;

                Main.activeAlgorithm.update();
                updateInfo();
            }
            catch (Exception) { }
        }

        private void seedTextBox_TextChanged(object sender, EventArgs e)
        {
            int SeedParityEncrypt = 1;
            try
            {
                SeedParityEncrypt = int.Parse(seedTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.SeedParityEncrypt = SeedParityEncrypt;
        }

        private void ParityEncryptControl_Load(object sender, EventArgs e)
        {
            Main.activeAlgorithm.update();
            updateInfo();
        }

    }
}
