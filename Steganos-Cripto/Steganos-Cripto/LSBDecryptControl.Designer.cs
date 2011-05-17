namespace Steganos_Cripto
{
    partial class LSBDecryptControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.numCharTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bits por sample:";
            // 
            // bitPerSampleMessageTextBox
            // 
            this.bitPerSampleMessageTextBox.Location = new System.Drawing.Point(110, 18);
            this.bitPerSampleMessageTextBox.Name = "bitPerSampleMessageTextBox";
            this.bitPerSampleMessageTextBox.Size = new System.Drawing.Size(40, 20);
            this.bitPerSampleMessageTextBox.TabIndex = 1;
            this.bitPerSampleMessageTextBox.Text = "1";
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(250, 18);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(50, 20);
            this.seedTextBox.TabIndex = 2;
            this.seedTextBox.Text = "55";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semilla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num car:";
            // 
            // numCharTextBox
            // 
            this.numCharTextBox.Location = new System.Drawing.Point(396, 18);
            this.numCharTextBox.Name = "numCharTextBox";
            this.numCharTextBox.Size = new System.Drawing.Size(50, 20);
            this.numCharTextBox.TabIndex = 4;
            this.numCharTextBox.Text = "11";
            // 
            // LSBDecryptControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCharTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seedTextBox);
            this.Controls.Add(this.bitPerSampleMessageTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LSBDecryptControl";
            this.Size = new System.Drawing.Size(482, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox bitPerSampleMessageTextBox;
        public System.Windows.Forms.TextBox seedTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox numCharTextBox;

    }
}
