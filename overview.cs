using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SM
{
    public partial class overview : Form
    {
        public overview()
        {
            InitializeComponent();
            setEnabled(false);
            setEnabledUpdate(false);
        }

        private void overview_Load(object sender, EventArgs e)
        {
            try
            {
                //datatable
                DataTable dt = new DataTable();

                String connectionString = "server=127.0.0.1;uid=root;pwd=root;database=db_sm;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //mysql query execute
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM PRODUCT_MART";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd.CommandText, connection);
                mySqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
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
            string query = "";

            int prodNameCheck = 0,typeCheck = 0;
            try
            {
                //datatable
                DataTable dt = new DataTable();

                String connectionString = "server=127.0.0.1;uid=root;pwd=root;database=db_sm;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //mysql query execute
                MySqlCommand cmd = connection.CreateCommand();
                query = "SELECT * FROM PRODUCT_MART WHERE ";
                if(_tb_productName.Text != "")
                {
                    query += "NAME LIKE UPPER('%" + _tb_productName.Text + "%')";
                    prodNameCheck = 1;
                }
                if (_tb_type.Text != "")
                {
                    if (prodNameCheck == 1)
                        query += " AND ";
                    query += "TYPE LIKE UPPER('%" + _tb_type.Text + "%')";
                    typeCheck = 1;
                }

                if (_tb_barcode.Text != "" )
                {
                    if (prodNameCheck == 1 || typeCheck == 1)
                        query += " AND ";
                    query += "BARCODE = " + _tb_barcode.Text ;
                }
                cmd.CommandText = query;
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd.CommandText, connection);
                mySqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                traceLogger logger = new traceLogger();
                logger.enterRecord(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = "server=127.0.0.1;uid=root;pwd=root;database=db_sm;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //mysql query execute
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE PRODUCT_MART SET COST = ?cost WHERE BARCODE = " + _tb_updateBarcode.Text;
                cmd.Parameters.Add("?cost", MySqlDbType.Float).Value = _tb_updatePrice.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show(_tb_updateBarcode.Text + " BARKOD NUMARALI ÜRÜNÜNÜZÜN (ADET/KG) FİYATI : " + _tb_updatePrice.Text +" TL OLARAK GÜNCELLENMİŞTİR");
                overview_Load(sender,e);
            }
            catch(Exception ex)
            {
                traceLogger logger = new traceLogger();
                logger.enterRecord(ex.ToString());
            }
        }

        private void _bttn_erase_Click(object sender, EventArgs e)
        {
            string query = "";

            int prodNameCheck = 0, typeCheck = 0;
            try
            {
                //datatable
                DataTable dt = new DataTable();

                String connectionString = "server=127.0.0.1;uid=root;pwd=root;database=db_sm;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //mysql query execute
                MySqlCommand cmd = connection.CreateCommand();
                query = "DELETE FROM PRODUCT_MART WHERE ";
                if (_tb_productName.Text != "")
                {
                    query += "NAME LIKE UPPER('%" + _tb_productName.Text + "%')";
                    prodNameCheck = 1;
                }
                if (_tb_type.Text != "")
                {
                    if (prodNameCheck == 1)
                        query += " AND ";
                    query += "TYPE LIKE UPPER('%" + _tb_type.Text + "%')";
                    typeCheck = 1;
                }

                if (_tb_barcode.Text != "")
                {
                    if (prodNameCheck == 1 || typeCheck == 1)
                        query += " AND ";
                    query += "BARCODE = " + _tb_barcode.Text;
                }
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(_tb_barcode.Text + " BARKODLU ÜRÜNÜNÜZ SİLİNMİŞTİR.");
                overview_Load(sender, e);
            }
            catch (Exception ex)
            {
                traceLogger logger = new traceLogger();
                logger.enterRecord(ex.ToString());
            }
        }

        private void _tb_productName_TextChanged(object sender, EventArgs e)
        {
            setEnabled(true);
        }
        private void setEnabled(bool b)
        {
            _bttn_erase.Enabled = b;
            button1.Enabled = b;
        }

        private void _tb_updateBarcode_TextChanged(object sender, EventArgs e)
        {
            setEnabledUpdate(true);
        }

        private void setEnabledUpdate(bool b)
        {
            if (_tb_updateBarcode.Text != "" && _tb_updatePrice.Text != "")
                button2.Enabled = b;
            else
                button2.Enabled = false;
                    
        }
    }
}
