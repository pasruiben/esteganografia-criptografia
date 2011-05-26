namespace Steganos_Cripto
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.infoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playOriginalButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.algoritmosComboBox = new System.Windows.Forms.ComboBox();
            this.playModifiedButton = new System.Windows.Forms.Button();
            this.aplicarCifradoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reproducirModificadoPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AplicarDescifradoButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.reproducirModificadoPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 336);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // infoToolStripStatusLabel
            // 
            this.infoToolStripStatusLabel.Name = "infoToolStripStatusLabel";
            this.infoToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.soToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip.TabIndex = 2;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // soToolStripMenuItem
            // 
            this.soToolStripMenuItem.Name = "soToolStripMenuItem";
            this.soToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.soToolStripMenuItem.Text = "Acerca";
            this.soToolStripMenuItem.Click += new System.EventHandler(this.soToolStripMenuItem_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(59, 37);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(237, 146);
            this.messageTextBox.TabIndex = 15;
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mensaje:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(83, 95);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(122, 20);
            this.keyTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Clave:";
            // 
            // playOriginalButton
            // 
            this.playOriginalButton.Location = new System.Drawing.Point(83, 177);
            this.playOriginalButton.Name = "playOriginalButton";
            this.playOriginalButton.Size = new System.Drawing.Size(83, 31);
            this.playOriginalButton.TabIndex = 8;
            this.playOriginalButton.Text = "Reproducir";
            this.playOriginalButton.UseVisualStyleBackColor = true;
            this.playOriginalButton.Click += new System.EventHandler(this.play_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modificado:";
            // 
            // algoritmosComboBox
            // 
            this.algoritmosComboBox.FormattingEnabled = true;
            this.algoritmosComboBox.Location = new System.Drawing.Point(83, 22);
            this.algoritmosComboBox.Name = "algoritmosComboBox";
            this.algoritmosComboBox.Size = new System.Drawing.Size(125, 21);
            this.algoritmosComboBox.TabIndex = 16;
            this.algoritmosComboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // playModifiedButton
            // 
            this.playModifiedButton.Location = new System.Drawing.Point(74, 5);
            this.playModifiedButton.Name = "playModifiedButton";
            this.playModifiedButton.Size = new System.Drawing.Size(70, 20);
            this.playModifiedButton.TabIndex = 11;
            this.playModifiedButton.Text = "Reproducir";
            this.playModifiedButton.UseVisualStyleBackColor = true;
            this.playModifiedButton.Click += new System.EventHandler(this.playModifiedButton_Click);
            // 
            // aplicarCifradoButton
            // 
            this.aplicarCifradoButton.Location = new System.Drawing.Point(527, 234);
            this.aplicarCifradoButton.Name = "aplicarCifradoButton";
            this.aplicarCifradoButton.Size = new System.Drawing.Size(101, 37);
            this.aplicarCifradoButton.TabIndex = 17;
            this.aplicarCifradoButton.Text = "Aplicar";
            this.aplicarCifradoButton.UseVisualStyleBackColor = true;
            this.aplicarCifradoButton.Visible = false;
            this.aplicarCifradoButton.Click += new System.EventHandler(this.aplicar_Cifrado_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(341, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 143);
            this.panel1.TabIndex = 19;
            // 
            // reproducirModificadoPanel
            // 
            this.reproducirModificadoPanel.Controls.Add(this.playModifiedButton);
            this.reproducirModificadoPanel.Controls.Add(this.label2);
            this.reproducirModificadoPanel.Location = new System.Drawing.Point(89, 250);
            this.reproducirModificadoPanel.Name = "reproducirModificadoPanel";
            this.reproducirModificadoPanel.Size = new System.Drawing.Size(155, 29);
            this.reproducirModificadoPanel.TabIndex = 18;
            this.reproducirModificadoPanel.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(273, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 333);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cifrado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.messageTextBox);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.reproducirModificadoPanel);
            this.panel3.Controls.Add(this.aplicarCifradoButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 295);
            this.panel3.TabIndex = 20;
            this.panel3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Num car:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Descifrado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.AplicarDescifradoButton);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(773, 295);
            this.panel5.TabIndex = 22;
            // 
            // AplicarDescifradoButton
            // 
            this.AplicarDescifradoButton.Location = new System.Drawing.Point(187, 208);
            this.AplicarDescifradoButton.Name = "AplicarDescifradoButton";
            this.AplicarDescifradoButton.Size = new System.Drawing.Size(101, 37);
            this.AplicarDescifradoButton.TabIndex = 20;
            this.AplicarDescifradoButton.Text = "Aplicar";
            this.AplicarDescifradoButton.UseVisualStyleBackColor = true;
            this.AplicarDescifradoButton.Click += new System.EventHandler(this.AplicarDescifradoButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(526, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 146);
            this.textBox1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(11, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 143);
            this.panel4.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mensaje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Algoritmo:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.playOriginalButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.algoritmosComboBox);
            this.panel2.Controls.Add(this.keyTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 306);
            this.panel2.TabIndex = 21;
            this.panel2.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esteganografía en audio";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.reproducirModificadoPanel.ResumeLayout(false);
            this.reproducirModificadoPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel infoToolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soToolStripMenuItem;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button playOriginalButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox algoritmosComboBox;
        private System.Windows.Forms.Button playModifiedButton;
        private System.Windows.Forms.Button aplicarCifradoButton;
        private System.Windows.Forms.Panel reproducirModificadoPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AplicarDescifradoButton;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}

