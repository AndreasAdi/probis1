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
    public partial class Coffee : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        SqlDataAdapter kopiadapter;
        string nama_menu = "";
        string harga = "";

        private add_order addorder;
        public Coffee(add_order add_Order)
        {

            InitializeComponent();
            this.addorder = add_Order;
        }

        private void Coffee_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            load_dg_kopi();
        }

        public void load_dg_kopi()
        {
            string pathgambar="";
            //Comment test Commit
            conn.Open();
            dataGridView_kopi.Rows.Clear();

            SqlCommand querypathgambar = new SqlCommand("Select path_gambar from menu where id_menu =1",conn);

            SqlDataReader r = querypathgambar.ExecuteReader();

            if (r.Read())
            {
               pathgambar = r.GetString(0);

                //MessageBox.Show(pathgambar);
                r.Close();
            }
         
            //var stream = myImage.ToStream(Application.StartupPath + "\\" + pathgambar);
            pictureBox_coffe.Image = Image.FromFile(Application.StartupPath+"\\"+pathgambar);


            string querySelectStock = "Select nama,harga from menu where tipe_menu =1";
            kopiadapter = new SqlDataAdapter(querySelectStock, conn);
            DataSet kopidata = new DataSet();
            kopiadapter.Fill(kopidata);
            dataGridView_kopi.DataSource = kopidata.Tables[0];
            dataGridView_kopi.Refresh();
            conn.Close();
        }

        private void dataGridView_kopi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            nama_menu = dataGridView_kopi.Rows[e.RowIndex].Cells[0].Value.ToString();
            harga = dataGridView_kopi.Rows[e.RowIndex].Cells[1].Value.ToString();
           
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            string qty = numericUpDown_jumlah.Value.ToString();
            addorder.dataGridView_order.Rows.Add(nama_menu, qty, harga);
           

        }

        private void dataGridView_kopi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
