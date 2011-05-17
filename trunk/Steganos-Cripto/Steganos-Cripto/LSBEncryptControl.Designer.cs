namespace Steganos_Cripto
{
    partial class LSBEncryptControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bitPerSampleMessageTextBox = new System.Windows.Forms.TextBox();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bits por sample:";
            // 
            // bitPerSampleMessageTextBox
            // 
            this.bitPerSampleMessageTextBox.Location = new System.Drawing.Point(112, 76);
            this.bitPerSampleMessageTextBox.Name = "bitPerSampleMessageTextBox";
            this.bitPerSampleMessageTextBox.Size = new System.Drawing.Size(40, 20);
            this.bitPerSampleMessageTextBox.TabIndex = 1;
            this.bitPerSampleMessageTextBox.Text = "1";
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(252, 76);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(50, 20);
            this.seedTextBox.TabIndex = 2;
            this.seedTextBox.Text = "55";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semilla:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(25, 26);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(148, 13);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Longitud máxima del mensaje:";
            // 
            // LSBControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.bitPerSampleMessageTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LSBControl";
            this.Size = new System.Drawing.Size(394, 124);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox bitPerSampleMessageTextBox;
        public System.Windows.Forms.TextBox seedTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label infoLabel;

    }
}
