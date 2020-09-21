using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probis
{
    public partial class gudang : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlDataAdapter gudangAdapter;
        public gudang()
        {
            InitializeComponent();

            conn = new SqlConnection(connection);
        }

        private void gudang_Load(object sender, EventArgs e)
        {
            load_dg_stock();
        }
        public void load_dg_stock()
        {
            conn.Open();
            dataGridView_stock.Rows.Clear();
            string querySelectStock = "Select * from stock";
            gudangAdapter = new SqlDataAdapter(querySelectStock, conn);
            DataSet gudangData = new DataSet();
            gudangAdapter.Fill(gudangData);
            dataGridView_stock.DataSource = gudangData.Tables[0];
            dataGridView_stock.Refresh();
            conn.Close();
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            add_stock tambahStock = new add_stock(this);
            tambahStock.Show();
        }
    }
}
