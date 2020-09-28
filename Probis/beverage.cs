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
    public partial class beverage : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        SqlDataAdapter adap;
        public beverage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void beverage_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            load_dg_beverage();
        }

        public void load_dg_beverage()
        {
            conn.Open();
            string querySelectStock = "Select nama,harga from menu where tipe_menu =2";
            adap = new SqlDataAdapter(querySelectStock, conn);
            DataSet desertdata = new DataSet();
            adap.Fill(desertdata);
            dataGridView_berverages.DataSource = desertdata.Tables[0];
            dataGridView_berverages.Refresh();
            conn.Close();
        }
    }
}
