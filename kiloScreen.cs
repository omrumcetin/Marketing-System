using System;
using System.Windows.Forms;

namespace SM
{
    public partial class kiloScreen : Form
    {
        public string okValue;
        public kiloScreen()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _bttn_okClick_Click(sender, e);
            }
        }

        private void _bttn_okClick_Click(object sender, EventArgs e)
        {
            this.okValue = _tb_kilo.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
