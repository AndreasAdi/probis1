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
        string nama_menu = "";
        string harga = "";
        private add_order addorder;
        public snack(add_order add_Order)
        {
            InitializeComponent();
            this.addorder = add_Order;
        }

        private void snack_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            conn.Open();
            //Load data ke datagridview
            string query = "Select nama,harga from menu where tipe_menu =3";
            loaddgv(query, dataGridView_snack);
            //Load gambar ke datagriview
            string querygambar = "Select path_gambar from menu where id_menu =22";
            loadgambar(querygambar,pictureBox_coffe);
            conn.Close();
        }

        //Fungsi buat load data ke data gridview 
        private void loaddgv(string query, DataGridView dgv)
        {
            dgv.Rows.Clear();
            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();

            List<string> listmenu = new List<string>();
            List<string> listharga = new List<string>();

            while (reader.Read())
            {
                listmenu.Add(reader.GetValue(0).ToString());
                listharga.Add(reader.GetValue(1).ToString());
            }
            reader.Close();

            for (int i = 0; i < listmenu.Count; i++)
            {
                dgv.Rows.Add(listmenu[i], listharga[i]);
            }
        }

        //Fungsi buat load gambar ke picture box 
        private void loadgambar(string query, PictureBox p)
        {
            string pathgambar = "";

            SqlCommand querypathgambar = new SqlCommand(query, conn);

            SqlDataReader r = querypathgambar.ExecuteReader();

            if (r.Read())
            {
                pathgambar = r.GetString(0);
                r.Close();
            }

            p.Image = Image.FromFile(Application.StartupPath + "\\" + pathgambar);
        }

        private void dataGridView_snack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                conn.Open();
                nama_menu = dataGridView_snack.Rows[e.RowIndex].Cells[0].Value.ToString();
                harga = dataGridView_snack.Rows[e.RowIndex].Cells[1].Value.ToString();

                string querygambar = "Select path_gambar from menu where nama = '" + nama_menu + "'";

                loadgambar(querygambar, pictureBox_coffe);
                conn.Close();
            }
           
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string qty = numericUpDown_jumlah.Value.ToString();
            addorder.dataGridView_order.Rows.Add(nama_menu, qty, harga);
        }
    }
}
