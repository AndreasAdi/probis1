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
    public partial class listorder : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        public listorder()
        {
            InitializeComponent();
        }

        private void listorder_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connection);
            conn.Open();
            string query = "Select * from horder where status =0";
            loaddgv(query, dgv_pending);

            query = "Select * from horder where status =1";
            loaddgv(query, dgv_process);

            query = "Select * from horder where status =2";
            loaddgv(query, dgv_finish);

            query = "Select * from horder where status =3";
            loaddgv(query, dgv_paid);
            conn.Close();
        }

        private void loaddgv(string query, DataGridView dgv)
        {
            dgv.Rows.Clear();
            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();

            List<string> orderno = new List<string>();
            List<int> total = new List<int>();
            List<string> status = new List<string>();
            List<string> meja = new List<string>();
            string tanggal = DateTime.Now.ToString("dd/MM/yy")+" 00:00:00";
            status.Clear();
            while (reader.Read())
            {
        
                if (reader.GetValue(2).ToString()==tanggal)
                {
                    total.Add(int.Parse(reader.GetValue(1).ToString()));
                    orderno.Add(reader.GetValue(0).ToString());
                    meja.Add(reader.GetValue(5).ToString());

                    if (reader.GetValue(3).ToString() == "0")
                    {
                        status.Add("Pending");
                    }
                    if (reader.GetValue(3).ToString() == "1")
                    {
                        status.Add("Process");
                    }
                    if (reader.GetValue(3).ToString() == "2")
                    {
                        status.Add("Finish");
                    }
                    if (reader.GetValue(3).ToString() == "3")
                    {
                        status.Add("Paid");
                    }
                 

                }
                else
                {
                   
                }
      
              
            }
            reader.Close();

            if (dgv.Columns.Count==6)
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "View Detail";
                    button.HeaderText = "View Detail";
                    button.Text = "View Detail";
                    button.UseColumnTextForButtonValue = true;
                    dgv.Columns.Add(button);
                }

            }


            for (int i = 0; i < total.Count; i++)
            {
       
                dgv.Rows.Add(orderno[i],meja[i],total[i],0,total[i],status[i]);
            }
        }

        private void dataGridView_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_pending.Columns[6].Index)
            {
                string id = dgv_pending.Rows[e.RowIndex].Cells[0].Value.ToString();
                Detail_Order dorder = new Detail_Order(id);
                dorder.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Select * from horder where status =0";
            loaddgv(query, dgv_pending);

            query = "Select * from horder where status =1";
            loaddgv(query, dgv_process);

            query = "Select * from horder where status =2";
            loaddgv(query, dgv_finish);
    

            query = "Select * from horder where status =3";
            loaddgv(query, dgv_paid);

            conn.Close();
        }

        private void dgv_process_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_process.Columns[6].Index)
            {
                string id = dgv_process.Rows[e.RowIndex].Cells[0].Value.ToString();
                Detail_Order dorder = new Detail_Order(id);
                dorder.Show();
            }
        }

        private void dgv_finish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_finish.Columns[6].Index)
            {
                string id = dgv_finish.Rows[e.RowIndex].Cells[0].Value.ToString();
                Detail_Order dorder = new Detail_Order(id);
                dorder.Show();
            }
        }

        private void dgv_paid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_paid.Columns[6].Index)
            {
                string id = dgv_paid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Detail_Order dorder = new Detail_Order(id);
                dorder.Show();
            }
        }
    }
}
