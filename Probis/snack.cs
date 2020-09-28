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
    public partial class snack : Form
    {

        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        SqlDataAdapter adap;
        public snack()
        {
            InitializeComponent();
        }

        private void snack_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            load_dg_snack();
        }


        public void load_dg_snack()
        {
            conn.Open();
            string querySelectStock = "Select nama,harga from menu where tipe_menu =3";
            adap = new SqlDataAdapter(querySelectStock, conn);
            DataSet desertdata = new DataSet();
            adap.Fill(desertdata);
            dataGridView_snack.DataSource = desertdata.Tables[0];
            dataGridView_snack.Refresh();
            conn.Close();
        }

        private void dataGridView_snack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
