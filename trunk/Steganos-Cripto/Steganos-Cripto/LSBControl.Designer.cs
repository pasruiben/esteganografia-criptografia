namespace Steganos_Cripto
{
    partial class LSBControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bits por sample:";
            // 
            // bitPerSampleMessageTextBox
            // 
            this.bitPerSampleMessageTextBox.Location = new System.Drawing.Point(110, 106);
            this.bitPerSampleMessageTextBox.Name = "bitPerSampleMessageTextBox";
            this.bitPerSampleMessageTextBox.Size = new System.Drawing.Size(97, 20);
            this.bitPerSampleMessageTextBox.TabIndex = 1;
            this.bitPerSampleMessageTextBox.Text = "1";
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(110, 154);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(97, 20);
            this.seedTextBox.TabIndex = 2;
            this.seedTextBox.Text = "55";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semilla:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(20, 30);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(148, 13);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Longitud máxima del mensaje:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // LSBControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.bitPerSampleMessageTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LSBControl";
            this.Size = new System.Drawing.Size(316, 201);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox bitPerSampleMessageTextBox;
        public System.Windows.Forms.TextBox seedTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.GroupBox groupBox1;

    }
}
