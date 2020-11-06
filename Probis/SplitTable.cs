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
    public partial class SplitTable : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        string id;
        string nama_menu = "";
        string harga = "";
        string qty ="";
        int index;
        string idbaru;
        public SplitTable(string id)
        {
            InitializeComponent();
             this.id = id;
        }

        private void SplitTable_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            string query = "select m.nama,m.harga,d.jumlah_order from menu m,dorder d where m.id_menu = d.id_menu and id_horder = '" + id + "'";
            No_Order.Text = "No Order  : " + id;
            loaddgv(query, dataGridView1);
            cekjumlah();
            conn.Close();
        }

        private void loaddgv(string query, DataGridView dgv)
        {
            
            conn.Open();
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
                dgv.Rows.Add(listmenu[i], listqty[i], int.Parse(listharga[i]));
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(nama_menu, qty, int.Parse(harga));
            dataGridView1.Rows.RemoveAt(index);
            cekjumlah();
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

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(nama_menu, qty, int.Parse(harga));
            dataGridView2.Rows.RemoveAt(index);
            cekjumlah();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                conn.Close();
                conn.Open();
                nama_menu = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                qty = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                harga = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                conn.Close();
            }
        }

        private void cekjumlah()
        {
            if (dataGridView2.Rows.Count ==0)
            {
                button3.Enabled = false;
            }
            else if (dataGridView2.Rows.Count > 0)
            {
                button3.Enabled = true;
            }
        }

        private string getlastid()
        {
           
            string query = "select max(id_horder) from horder";
            string id="";

            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();


            while (reader.Read())
            {
                id = reader.GetValue(0).ToString();
            }
            reader.Close();

            int temp = int.Parse(id)+1;
            id = temp.ToString();
            return id;
        }

        private string getidmenu(string nama)
        {
            
      
            string query = "select id_menu from menu where nama = '"+nama+"'";
            string id = "";

            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();


            while (reader.Read())
            {
                id = reader.GetValue(0).ToString();
            }
            reader.Close();

            int temp = int.Parse(id);
            id = temp.ToString();

      

            return id;

        }

        private int getJumlahHarga()
        {


            string query = "select jumlah_harga from horder where id_horder = " + id + "";
            string temp = "";
            int jumlah_harga=0;

            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();


            while (reader.Read())
            {
               temp = reader.GetValue(0).ToString();
            }
            reader.Close();


            jumlah_harga = int.Parse(temp);

            return jumlah_harga;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            idbaru = getlastid();
            int qty = 0;
            int harga = 0;
            int total = 0;
            string id_menu="";
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                id_menu = getidmenu(dataGridView2.Rows[i].Cells[0].Value.ToString());   
                harga= Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value.ToString());
                qty = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value.ToString());
                total += harga * qty;

                SqlCommand insertDetailOrder = new SqlCommand("Insert into dorder(id_horder,id_menu,jumlah_order)values(" + idbaru + "," + id_menu + "," + qty + ")", conn);
                SqlDataReader readerInsertdetail = insertDetailOrder.ExecuteReader();
                readerInsertdetail.Close();


                SqlCommand deleteDetail = new SqlCommand("Delete from dorder where id_horder = "+id+" and id_menu = "+id_menu+"",conn);
                SqlDataReader readerDeletedetail = deleteDetail.ExecuteReader();
                readerDeletedetail.Close();



            }

            int totalbaru = getJumlahHarga();
            totalbaru -= total;

            SqlCommand updateHorder = new SqlCommand("UPDATE horder set jumlah_harga = "+totalbaru+" WHERE id_horder = "+id+"",conn);
            SqlDataReader readerUpdateHorder = updateHorder.ExecuteReader();
            readerUpdateHorder.Close();

            SqlCommand insertHeaderOrder = new SqlCommand("Insert into horder(jumlah_harga,tanggal,status,catatan) values(" + total + ",PARSE('" + DateTime.Now.ToShortDateString() + "' as date USING 'AR-LB'),2,'')", conn);
            SqlDataReader reader = insertHeaderOrder.ExecuteReader();
            reader.Close();

            SqlCommand insertsplit = new SqlCommand("Insert into splitBill(id_split,id_horder) values(" + idbaru + "," + id + ")", conn);
            insertsplit.ExecuteNonQuery();
     

            MessageBox.Show(total+"");
            MessageBox.Show(idbaru);

            conn.Close();
        }
    }
}
