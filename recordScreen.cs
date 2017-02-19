using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SM
{
    public partial class recordScreen : Form
    {
        public recordScreen()
        {
            InitializeComponent();
            _bttn_record.Enabled = false;
        }

        private void _bttn_record_Click(object sender, EventArgs e)
        {
            bool ifData = false;
            try
            {
                //mysql connection
                String connectionString = "server=127.0.0.1;uid=root;pwd=root;database=db_sm;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //mysql query execute
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM PRODUCT_MART WHERE BARCODE = " + _tb_barcode.Text;
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    if (Reader["NAME"].ToString() != "")
                    {
                        ifData = true;
                        break;
                    }
                }

                if (ifData)
                {
                    MessageBox.Show(Reader["BARCODE"].ToString() + " BARKODLU ÜRÜNÜNÜZ " + Reader["NAME"].ToString() + " OLARAK KAYDI MEVCUTTUR.","HATALI GİRİŞ",MessageBoxButtons.OK,MessageBoxIcon.Error );
                    Reader.Close();
                }
                else
                {
                    Reader.Close();
                    cmd.CommandText = "INSERT INTO PRODUCT_MART VALUES(?name,?type,?cost,?barcode)";
                    cmd.Parameters.Add("?name", MySqlDbType.VarChar).Value = _tb_name.Text.ToUpper();
                    cmd.Parameters.Add("?type", MySqlDbType.VarChar).Value = _tb_type.Text.ToUpper();
                    cmd.Parameters.Add("?cost", MySqlDbType.Float).Value = float.Parse(_tb_cost.Text);
                    cmd.Parameters.Add("?barcode", MySqlDbType.UInt64).Value = long.Parse(_tb_barcode.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(_tb_name.Text.ToUpper() + " ÜRÜNÜNÜZ " + _tb_type.Text.ToUpper() + " KATEGORİSİNDE " +
                                 _tb_cost.Text.ToUpper() + " ÜCRETİYLE KAYDEDİLMİŞTİR.","KAYIT" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                //messagebox

                //empty related records
                _tb_name.Text = "";
                _tb_type.Text = "";
                _tb_cost.Text = "";
                _tb_barcode.Text = "";

                connection.Close();
            }
            catch(Exception ex)
            {
                traceLogger logger = new traceLogger();
                logger.enterRecord(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                barcodeReadWindow brw = new barcodeReadWindow();
                var result = brw.ShowDialog();
                if (result == DialogResult.OK)
                    _tb_barcode.Text = brw.okValue;                 
            }
            catch (Exception ex)
            {
                traceLogger logger = new traceLogger();
                logger.enterRecord(ex.ToString());
            }
        }

        private void setButtonEnabled()
        {
            if(_tb_barcode.Text != "" && _tb_cost.Text != "" && _tb_name.Text != "" && _tb_type.Text != "")
                _bttn_record.Enabled = true;
        }

        private void _tb_name_TextChanged(object sender, EventArgs e)
        {
            setButtonEnabled();
        }


    }
}
