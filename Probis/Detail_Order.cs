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
    public partial class Detail_Order : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        string id;
        public Detail_Order(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Detail_Order_Load(object sender, EventArgs e)
        {
            lbl_no_order.Text = "No Order  : "+id;
            conn = new SqlConnection(connection);
            conn.Open();
            string query = "select m.nama,m.harga,d.jumlah_order from menu m,dorder d where m.id_menu = d.id_menu and id_horder = '"+id+"'";
            loaddgv(query, dgv_detail_order);
            conn.Close();
        }

        private void loaddgv(string query, DataGridView dgv)
        {
            dgv.Rows.Clear();
            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();

            List<string> listmenu = new List<string>();
            List<string> listharga = new List<string>();
            List<string> listqty = new List<string>();

            while (reader.Read())
            {
                listmenu.Add(reader.GetValue(0).ToString());
                listharga.Add(reader.GetValue(1).ToString());
                listqty.Add(reader.GetValue(1).ToString());
            }
            reader.Close();

            for (int i = 0; i < listmenu.Count; i++)
            {
                dgv.Rows.Add(listmenu[i],listqty[i],listharga[i]);
            }
        }
    }
}
