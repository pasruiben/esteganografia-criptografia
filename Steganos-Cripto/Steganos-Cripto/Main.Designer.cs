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
            this.label1 = new System.Windows.Forms.Label();
            this.playOriginalButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.playModifiedButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 262);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(840, 22);
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
            this.menuStrip.Size = new System.Drawing.Size(840, 24);
            this.menuStrip.TabIndex = 2;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // soToolStripMenuItem
            // 
            this.soToolStripMenuItem.Name = "soToolStripMenuItem";
            this.soToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.soToolStripMenuItem.Text = "Acerca";
            this.soToolStripMenuItem.Click += new System.EventHandler(this.soToolStripMenuItem_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(78, 161);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(234, 53);
            this.messageTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mensaje:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(78, 97);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(125, 20);
            this.keyTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Original:";
            // 
            // playOriginalButton
            // 
            this.playOriginalButton.Location = new System.Drawing.Point(89, 47);
            this.playOriginalButton.Name = "playOriginalButton";
            this.playOriginalButton.Size = new System.Drawing.Size(75, 23);
            this.playOriginalButton.TabIndex = 8;
            this.playOriginalButton.Text = "Reproducir";
            this.playOriginalButton.UseVisualStyleBackColor = true;
            this.playOriginalButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modificado:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // playModifiedButton
            // 
            this.playModifiedButton.Location = new System.Drawing.Point(351, 188);
            this.playModifiedButton.Name = "playModifiedButton";
            this.playModifiedButton.Size = new System.Drawing.Size(97, 23);
            this.playModifiedButton.TabIndex = 11;
            this.playModifiedButton.Text = "Reproducir";
            this.playModifiedButton.UseVisualStyleBackColor = true;
            this.playModifiedButton.Click += new System.EventHandler(this.playModifiedButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.playModifiedButton);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(369, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 232);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 284);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playOriginalButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playOriginalButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button playModifiedButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

