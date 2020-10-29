using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Probis
{
    public partial class templateOrder : Form
    {
        public string idOrder;
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        public templateOrder()
        {
            InitializeComponent();
        }
        private void loadOrder()
        {
            conn = new SqlConnection(connection);
            conn.Open();
            string query = "select catatan from horder d where id_horder = '" + idOrder + "'";
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader = comm.ExecuteReader();
            
            while (reader.Read())
            {
                richTextBox1.Text= "CATATAN = ";
                richTextBox1.Text += Environment.NewLine + reader.GetValue(0).ToString();
            }
            reader.Close();
            query = "select d.jumlah_order , m.nama from menu m, dorder d where d.id_horder = '" + idOrder + "' and m.id_menu = d.id_menu";
            comm = new SqlCommand(query, conn);
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                dataGridOrder.Rows.Add(reader.GetValue(1).ToString(), reader.GetValue(0).ToString());
            }
            conn.Close();
        }
        private void cek()
        {
            bool state = false;
            foreach (DataGridViewRow temp in dataGridOrder.Rows)
            {

                DataGridViewCheckBoxCell stat = (DataGridViewCheckBoxCell)temp.Cells[2];
                if (stat.Value == stat.FalseValue)
                {
                    state = true;
                    break;
                }
            }
            if (state == true)
            {
                MessageBox.Show("Semua Pesanan Harus selesai dahulu..!!");

            }
            else
            {
                conn = new SqlConnection(connection);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update horder set status = 2 where id_horder ='" + idOrder + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pesanan Selesai");
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Eror, " + ex);
                }

                this.Close();
            }
        }
        private void templateOrder_Load(object sender, EventArgs e)
        {
            loadOrder();

        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            cek();
        }

        private void dataGridOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update horder set status = 1 where id_horder ='" + idOrder + "'", conn);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Pesanan Selesai");
                conn.Close();
                btnProcessOrder.Enabled = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Eror, " + ex);
            }
        }
    }
}
