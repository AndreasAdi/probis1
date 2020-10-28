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
        int total = 0;
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

            if (dgv_detail_order.Rows.Count <=1)
            {
                button3.Enabled = false;
            }
            else if (dgv_detail_order.Rows.Count > 1)
            {
                button3.Enabled = true;
            }
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
                listqty.Add(reader.GetValue(2).ToString());
            }
            reader.Close();

            for (int i = 0; i < listmenu.Count; i++)
            {
                dgv.Rows.Add(listmenu[i],listqty[i],int.Parse(listharga[i]));
                total += int.Parse(listharga[i]) * int.Parse(listqty[i]);
            }

            label3.Text  = total.ToString("#,##0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SplitTable splitTable = new SplitTable(id);
            splitTable.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JoinTable joinTable = new JoinTable(id);
            joinTable.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_finish_order_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand updateHorder = new SqlCommand("UPDATE horder set status = 3  WHERE id_horder = " + id + "", conn);
            updateHorder.ExecuteNonQuery();
            MessageBox.Show("Berhasil");
            conn.Close();
        }

        private void btn_cancel_order_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand updateHorder = new SqlCommand("UPDATE horder set status = 4  WHERE id_horder = " + id + "", conn);
            updateHorder.ExecuteNonQuery();
            MessageBox.Show("Berhasil Cancel Order");
            conn.Close();
        }
    }
}
