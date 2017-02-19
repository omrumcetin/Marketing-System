using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SM
{
    public partial class barcodeReadWindow : Form
    {
        public barcodeReadWindow()
        {
            InitializeComponent();
        }

        public string okValue { get; set; }
        public string cancelValue { get; set; }

        private void _bttn_ok_Click(object sender, EventArgs e)
        { 
            this.okValue = _tb_barcode.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void _bttn_exit_Click(object sender, EventArgs e)
        {
            this.cancelValue = "1";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void _bttn_ok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _bttn_ok_Click(sender, e);
            }
        }
    }
}
