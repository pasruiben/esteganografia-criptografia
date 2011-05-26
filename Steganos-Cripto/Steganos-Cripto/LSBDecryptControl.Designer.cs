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
            this.bitPerSampleMessageTextBox.Location = new System.Drawing.Point(123, 18);
            this.bitPerSampleMessageTextBox.Name = "bitPerSampleMessageTextBox";
            this.bitPerSampleMessageTextBox.Size = new System.Drawing.Size(40, 20);
            this.bitPerSampleMessageTextBox.TabIndex = 1;
            this.bitPerSampleMessageTextBox.Text = "0";
            this.bitPerSampleMessageTextBox.TextChanged += new System.EventHandler(this.bitPerSampleMessageTextBox_TextChanged);
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(240, 18);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(41, 20);
            this.seedTextBox.TabIndex = 2;
            this.seedTextBox.Text = "0";
            this.seedTextBox.TextChanged += new System.EventHandler(this.seedTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semilla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num car:";
            // 
            // numCharTextBox
            // 
            this.numCharTextBox.Location = new System.Drawing.Point(123, 73);
            this.numCharTextBox.Name = "numCharTextBox";
            this.numCharTextBox.Size = new System.Drawing.Size(40, 20);
            this.numCharTextBox.TabIndex = 4;
            this.numCharTextBox.Text = "0";
            this.numCharTextBox.TextChanged += new System.EventHandler(this.numCharTextBox_TextChanged);
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
            this.Size = new System.Drawing.Size(320, 135);
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
