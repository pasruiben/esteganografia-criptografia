namespace Steganos_Cripto
{
    partial class ParityEncryptControl
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.samplesPerRegionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(3, 25);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(148, 13);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Longitud máxima del mensaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Semilla:";
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(220, 71);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(50, 20);
            this.seedTextBox.TabIndex = 7;
            this.seedTextBox.Text = "55";
            // 
            // samplesPerRegionTextBox
            // 
            this.samplesPerRegionTextBox.Location = new System.Drawing.Point(109, 71);
            this.samplesPerRegionTextBox.Name = "samplesPerRegionTextBox";
            this.samplesPerRegionTextBox.Size = new System.Drawing.Size(40, 20);
            this.samplesPerRegionTextBox.TabIndex = 11;
            this.samplesPerRegionTextBox.Text = "32";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Samples por región:";
            // 
            // ParityEncryptControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.samplesPerRegionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seedTextBox);
            this.Name = "ParityEncryptControl";
            this.Size = new System.Drawing.Size(295, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label infoLabel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox seedTextBox;
        public System.Windows.Forms.TextBox samplesPerRegionTextBox;
        public System.Windows.Forms.Label label1;
    }
}
