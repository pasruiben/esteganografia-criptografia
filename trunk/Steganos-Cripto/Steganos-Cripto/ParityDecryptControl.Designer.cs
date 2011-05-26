namespace Steganos_Cripto
{
    partial class ParityDecryptControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.samplesPerRegionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numCharTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Semilla:";
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(253, 23);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(50, 20);
            this.seedTextBox.TabIndex = 7;
            this.seedTextBox.Text = "0";
            this.seedTextBox.TextChanged += new System.EventHandler(this.seedTextBox_TextChanged);
            // 
            // samplesPerRegionTextBox
            // 
            this.samplesPerRegionTextBox.Location = new System.Drawing.Point(120, 23);
            this.samplesPerRegionTextBox.Name = "samplesPerRegionTextBox";
            this.samplesPerRegionTextBox.Size = new System.Drawing.Size(40, 20);
            this.samplesPerRegionTextBox.TabIndex = 13;
            this.samplesPerRegionTextBox.Text = "0";
            this.samplesPerRegionTextBox.TextChanged += new System.EventHandler(this.samplesPerRegionTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Samples por región:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Num car:";
            // 
            // numCharTextBox
            // 
            this.numCharTextBox.Location = new System.Drawing.Point(396, 23);
            this.numCharTextBox.Name = "numCharTextBox";
            this.numCharTextBox.Size = new System.Drawing.Size(50, 20);
            this.numCharTextBox.TabIndex = 14;
            this.numCharTextBox.Text = "0";
            this.numCharTextBox.TextChanged += new System.EventHandler(this.numCharTextBox_TextChanged);
            // 
            // ParityDecryptControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCharTextBox);
            this.Controls.Add(this.samplesPerRegionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seedTextBox);
            this.Name = "ParityDecryptControl";
            this.Size = new System.Drawing.Size(480, 78);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox seedTextBox;
        public System.Windows.Forms.TextBox samplesPerRegionTextBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox numCharTextBox;
    }
}
