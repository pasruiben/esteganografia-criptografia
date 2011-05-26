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
        public static Algorithm activeAlgorithm { get; set; }

        public Main()
        {
            InitializeComponent();

            List<Algorithm> algorithms = new List<Algorithm>();
            algorithms.Add(new LSB());
            algorithms.Add(new Parity());

            algoritmosComboBox.Items.AddRange(algorithms.ToArray<Algorithm>());
        }

        private void soToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esteganografía en audio.\nRealizado por Juan Antonio Cano Salado, Borja Moreno Fernandez y Pascual Javier Ruiz Benitez");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Audio|*.wav";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.infoToolStripStatusLabel.Text = "Audio cargado";
                this.Text = "Esteganografía en audio - " + dlg.SafeFileName;

                State.Instance.FileNameIn = dlg.FileName;
                State.Instance.FileNameOut = dlg.FileName + ".out.wav";

                //TODO: Calcular cuantos bits por sample tiene el fichero y modificar Wavprocessor y Sample para cada caso.
                State.Instance.BitsPerSample = 16;

                panel2.Visible = true;
                tabControl1.Visible = true;
                panel3.Visible = true;
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(State.Instance.FileNameIn);
            simpleSound.Play();
        }

        private void playModifiedButton_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(State.Instance.FileNameOut);
            simpleSound.Play();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            activeAlgorithm = algoritmosComboBox.SelectedItem as Algorithm;

            activeAlgorithm.init();

            this.panel1.Controls.Clear();
            this.panel4.Controls.Clear();

            this.panel1.Controls.Add(activeAlgorithm.EncryptView);
            this.panel4.Controls.Add(activeAlgorithm.DecryptView);

            aplicarCifradoButton.Visible = true;
        }

        private void aplicar_Cifrado_Click(object sender, EventArgs e)
        {
            activeAlgorithm.encrypt(messageTextBox.Text, keyTextBox.Text);

            this.infoToolStripStatusLabel.Text = "Algoritmo de cifrado aplicado";
            reproducirModificadoPanel.Visible = true;
        }

        private void AplicarDescifradoButton_Click(object sender, EventArgs e)
        {
            String res = activeAlgorithm.decrypt(keyTextBox.Text);
            textBox1.Text = res;
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = messageTextBox.Text.Length.ToString();
        }
    }
}
