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
            try
            {
                int samplesPerRegion = int.Parse(samplesPerRegionTextBox.Text);
                int numSamples = WavProcessor.numSamples(State.Instance.FileNameIn);
                if (!(samplesPerRegion >= 1 && samplesPerRegion <= numSamples)) throw new Exception();

                State.Instance.SamplesPerRegionParityDecrypt = samplesPerRegion;

                Main.activeAlgorithm.update();
            }
            catch (Exception) { }
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

        private void ParityDecryptControl_Load(object sender, EventArgs e)
        {
            Main.activeAlgorithm.update();
        }
    }
}
