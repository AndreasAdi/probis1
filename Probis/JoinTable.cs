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
    public partial class JoinTable : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        string id;
        string nama_menu = "";
        string harga = "";
        string qty = "";
        int index;
        string idbaru;

        public JoinTable(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void JoinTable_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            conn.Open();
            string query = "Select * from horder where status =2 and id_horder != "+id+" ";
            loaddgv(query, dataGridView1);

            query = "Select * from horder where id_horder = "+id+" ";
            loaddgv(query, dataGridView2);
            conn.Close();

        }
        private void loaddgv(string query, DataGridView dgv)
        {
            dgv.Rows.Clear();
            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();

            List<string> orderno = new List<string>();
            List<int> total = new List<int>();
            List<string> meja = new List<string>();
            string tanggal = DateTime.Now.ToString("dd/MM/yy") + " 00:00:00";
 
            while (reader.Read())
            {

                if (reader.GetValue(2).ToString() == tanggal)
                {
                    total.Add(int.Parse(reader.GetValue(1).ToString()));
                    orderno.Add(reader.GetValue(0).ToString());
                    meja.Add(reader.GetValue(5).ToString());
            
                }


            }
            reader.Close();

            for (int i = 0; i < total.Count; i++)
            {

                dgv.Rows.Add(orderno[i], meja[i], total[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Add(nama_menu, qty, int.Parse(harga));
            dataGridView1.Rows.RemoveAt(index);
            cekjumlah();
        }

        private void cekjumlah()
        {
            if (dataGridView2.Rows.Count == 0)
            {
                button3.Enabled = false;
            }
            else if (dataGridView2.Rows.Count > 0)
            {
                button3.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (e.RowIndex >= 0)
            {

                conn.Open();
                nama_menu = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                qty = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                harga = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(nama_menu, qty, int.Parse(harga));
            dataGridView2.Rows.RemoveAt(index);
            cekjumlah();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            idbaru = getlastid();
            int total = 0;

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {

                string idhorder = dataGridView2.Rows[i].Cells[0].Value.ToString();
                string query = "UPDATE dorder set id_horder = " + idbaru + " WHERE id_horder = " + idhorder + "";

                total += int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());

                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();


                SqlCommand insertjoin = new SqlCommand("Insert into joinBill(id_join,id_horder) values(" + idbaru + "," + idhorder + ")", conn);
                insertjoin.ExecuteNonQuery();


                SqlCommand updateHorder = new SqlCommand("UPDATE horder set status = 4  WHERE id_horder = " + idhorder + "", conn);
                updateHorder.ExecuteNonQuery();
            }

            SqlCommand insertHeaderOrder = new SqlCommand("Insert into horder(jumlah_harga,tanggal,status,catatan) values(" + total + ",PARSE('" + DateTime.Now.ToShortDateString() + "' as date USING 'AR-LB'),2,'')", conn);
            insertHeaderOrder.ExecuteNonQuery();



            conn.Close();

            MessageBox.Show("Berhasil join");

            Detail_Order d = new Detail_Order(idbaru,"finish");
            this.Hide();
            d.Show();
            this.Close();

        }
        private string getlastid()
        {

            string query = "select max(id_horder) from horder";
            string id = "";

            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();


            while (reader.Read())
            {
                id = reader.GetValue(0).ToString();
            }
            reader.Close();

            int temp = int.Parse(id) + 1;
            id = temp.ToString();
            return id;
        }
    }
}
