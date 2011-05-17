using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Steganos_Cripto
{
    public partial class Main : Form
    {
        String filenameIn;
        String filenameOut = @"C:\Users\jacano\out.wav";

        List<Algorithm> algorithms = null;
        Algorithm activeAlgorithm = null;

        public Main()
        {
            InitializeComponent();

            algorithms = new List<Algorithm>();
            algorithms.Add(new LSB());

            algoritmosComboBox.Items.AddRange(algorithms.ToArray<Algorithm>());
        }

        private void soToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Audio|*.wav";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.infoToolStripStatusLabel.Text = "Audio cargado";
                this.Text = "Esteganografía en audio - " + dlg.SafeFileName;

                filenameIn = dlg.FileName;
                panel2.Visible = true;
                tabControl1.Visible = true;
                panel3.Visible = true;
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(filenameIn);
            simpleSound.Play();
        }

        private void playModifiedButton_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(filenameOut);
            simpleSound.Play();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            activeAlgorithm = algoritmosComboBox.SelectedItem as Algorithm;

            activeAlgorithm.init(filenameIn);
            this.panel1.Controls.Add(activeAlgorithm.view);

            aplicarButton.Visible = true;
        }

        private void aplicar_Click(object sender, EventArgs e)
        {
            activeAlgorithm.run(filenameOut, messageTextBox.Text, keyTextBox.Text);

            this.infoToolStripStatusLabel.Text = "Algoritmo aplicado";
            reproducirModificadoPanel.Visible = true;
        }
    }
}
