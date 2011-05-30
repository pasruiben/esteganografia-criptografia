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
            infoLabel.Text = "Longitud máxima del mensaje: " + State.Instance.MaxMessageLengthLSBEncrypt + " caracteres";
        }

        private void bitPerSampleMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int BitsPerSampleLSB = int.Parse(bitPerSampleMessageTextBox.Text);
                if (!(BitsPerSampleLSB >= 1 && BitsPerSampleLSB <= State.Instance.BitsPerSample)) throw new Exception();

                State.Instance.BitsPerSampleLSBEncrypt = BitsPerSampleLSB;

                Main.activeAlgorithm.update();

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
            Main.activeAlgorithm.update();
            updateInfo();
        }
    }
}
