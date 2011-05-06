using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganos_Cripto
{
    public partial class Main : Form
    {
        private void soToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Audio|*.wav;*.mp3";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.infoToolStripStatusLabel.Text = "Audio cargado";
                this.Text = "Esteganografía en audio - " + dlg.SafeFileName;

                if (Util.isWavFile(dlg.FileName))
                {
                    WavCriptoControl wavCriptoControl1 = new WavCriptoControl(dlg.FileName);
                    wavCriptoControl1.Location = new System.Drawing.Point(15, 25);
                    wavCriptoControl1.Size = new System.Drawing.Size(353, 225);
                    Controls.Add(wavCriptoControl1);               
                }  
            }
        }
    }
}
