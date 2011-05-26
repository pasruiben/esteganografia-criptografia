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

        private void bitPerSampleMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            int BitsPerSampleLSBEncrypt = 1;
            try
            {
                BitsPerSampleLSBEncrypt = int.Parse(bitPerSampleMessageTextBox.Text);
            }
            catch (Exception) { }

            State.Instance.BitsPerSampleLSBEncrypt = BitsPerSampleLSBEncrypt;

            Main.activeAlgorithm.init();
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
    }
}
