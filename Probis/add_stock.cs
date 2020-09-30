using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Probis
{
    public partial class add_stock : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        private gudang dgvStock;
        public add_stock(gudang frm)
        {
            InitializeComponent();
            conn = new SqlConnection(connection);
            dgvStock = frm;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            conn.Open();
            string nama_stock = textBox1.Text;
            int jumlah = int.Parse(textBox2.Text);
            string satuan = comboBox1.SelectedItem.ToString();

            string queryInsertStock = "insert into stock(nama,jumlah,satuan) values('" + nama_stock + "'," + jumlah + ",'" + satuan + "')";
            SqlCommand cmd_InsertStock = new SqlCommand(queryInsertStock, conn);
            SqlDataReader reader_InsertStock = cmd_InsertStock.ExecuteReader();

            if (reader_InsertStock.Read())
            {
                MessageBox.Show("Berhasil Insert Stock");
                dgvStock.load_dg_stock();
            }

            reader_InsertStock.Close();
            conn.Close();
        }

        private void add_stock_Load(object sender, EventArgs e)
        {

        }
    }
}
