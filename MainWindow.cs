using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SM
{
    
    public partial class MainWindow : Form
    {
        //global variables
        float sum = 0;
        public MainWindow()
        {
            InitializeComponent();
            enableButtons(false);
        }

        public void enableButtons(bool enabled)
        {
            _bttn_newTrade.Enabled = !enabled;
            _tb_barcode.Enabled = enabled;
            _bttn_endTrade.Enabled = enabled;
            _bttn_additionalCost.Enabled = enabled;
            _tb_additionalCost.Enabled = enabled;
            _bttn_erase.Enabled = enabled;
        }

        private void kayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recordScreen recordWindow = new recordScreen();
            recordWindow.Show();
        }

        private void _menuStrip_sorgu_Click(object sender, EventArgs e)
        {
            overview overviewWindow = new overview();
            overviewWindow.Show();
        }

        private void _bttn_newTrade_Click(object sender, EventArgs e)
        {
            enableButtons(true);
            _tb_barcode.Focus();
        }
        private void calculations()
        {
            
            _bttn_newTrade.Enabled = false;
            MySqlDataReader Reader = null;
            float cost = 0;
            try
            {
                //mysql connection
                String connectionString = "server=127.0.0.1;uid=root;pwd=root;database=db_sm;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();

                              
                cmd.CommandText = "SELECT * FROM PRODUCT_MART WHERE BARCODE = " + _tb_barcode.Text;
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    if (Reader["TYPE"].ToString() == "BİRİM")
                    {
                        ListViewItem lw = new ListViewItem(Reader["NAME"].ToString());
                        kiloScreen ks = new kiloScreen();
                        var result = ks.ShowDialog();
                        if(result == DialogResult.OK)
                        {
                            lw.SubItems.Add(ks.okValue);
                        }
                        cost = float.Parse(Reader["COST"].ToString()) * float.Parse(ks.okValue);
                        lw.SubItems.Add(cost.ToString());
                        _lw_trade.Items.Add(lw);
                    }
                    else
                    {
                        //add item to listbox
                        ListViewItem lw = new ListViewItem(Reader["NAME"].ToString());
                        lw.SubItems.Add("1");
                        cost = float.Parse(Reader["COST"].ToString());
                        lw.SubItems.Add(cost.ToString());
                        _lw_trade.Items.Add(lw);
                    }
                    
                }
                
                _tb_barcode.Text = "";
                sum += cost;
                _tb_tradeResult.Text = sum.ToString() + " TL"; 
                
                
                Reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                traceLogger logger = new traceLogger();
                logger.enterRecord(ex.ToString());
            }
        }

        private void _lw_trade_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = _lw_trade.Columns[e.ColumnIndex].Width;
        }

        private void _tb_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                calculations();
            }
        }

        private void _bttn_endTrade_Click(object sender, EventArgs e)
        {
            enableButtons(false);
            sum = 0;
            _lw_trade.Items.Clear();
            _tb_tradeResult.Text = "";
        }

        private void MainWindow_ResizeEnd(object sender, EventArgs e)
        {
            _lw_trade.Columns[0].Width = (_lw_trade.ClientSize.Width / 3) * 2;
            _lw_trade.Columns[1].Width = (_lw_trade.ClientSize.Width / 6);
            _lw_trade.Columns[2].Width = (_lw_trade.ClientSize.Width / 6);
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                _lw_trade.Columns[0].Width = (_lw_trade.ClientSize.Width / 3) * 2;
                _lw_trade.Columns[1].Width = (_lw_trade.ClientSize.Width / 6);
                _lw_trade.Columns[2].Width = (_lw_trade.ClientSize.Width / 6);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maximum = _lw_trade.SelectedItems.Count;
            try
            {
                for (int i = 0; i < maximum; i++)
                {
                    sum -= float.Parse(_lw_trade.SelectedItems[0].SubItems[2].Text);
                    _lw_trade.SelectedItems[0].Remove();
                    _tb_tradeResult.Text = sum.ToString() + " TL";
                    _tb_barcode.Focus();
                }
            }catch(Exception ex)
            {
                traceLogger logger = new traceLogger();
                logger.enterRecord(ex.ToString());
            }
                
        }

        private void _bttn_additionalCost_Click(object sender, EventArgs e)
        {
            ListViewItem lw = new ListViewItem("Ek Ücret");
            lw.SubItems.Add("");
            lw.SubItems.Add(_tb_additionalCost.Text);
            _lw_trade.Items.Add(lw);
            float cost = float.Parse(_tb_additionalCost.Text);
            sum += cost;
            _tb_tradeResult.Text = sum.ToString() + " TL";
        }
    }
}
