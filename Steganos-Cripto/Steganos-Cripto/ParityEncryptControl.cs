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

        private void samplesPerRegionTextBox_TextChanged(object sender, EventArgs e)
        {
            int samplesPerRegion = 1;
            try
            {
                samplesPerRegion = int.Parse(samplesPerRegionTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.SamplesPerRegionParityEncrypt = samplesPerRegion;

            Main.activeAlgorithm.init();
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
    }
}
