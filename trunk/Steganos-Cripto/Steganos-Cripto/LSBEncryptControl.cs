﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganos_Cripto
{
    public partial class LSBEncryptControl : UserControl
    {
        public LSBEncryptControl()
        {
            InitializeComponent();
        }

        private void bitPerSampleMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            Main.activeAlgorithm.init();
        }
    }
}
