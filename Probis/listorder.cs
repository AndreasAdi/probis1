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
            string query = "Select * from horder";
            loaddgv(query, dataGridView_stock);
            conn.Close();
        }

        private void loaddgv(string query, DataGridView dgv)
        {
            dgv.Rows.Clear();
            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();

            List<string> orderno = new List<string>();
            List<string> total = new List<string>();
            List<string> status = new List<string>();

            while (reader.Read())
            {
                total.Add(reader.GetValue(1).ToString());
                orderno.Add(reader.GetValue(0).ToString());
                if (reader.GetValue(3).ToString()=="0")
                {
                    status.Add("Pending");
                }
              
            }
            reader.Close();

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "View Detail";
                button.HeaderText = "View Detail";
                button.Text = "View Detail";
                button.UseColumnTextForButtonValue = true; 
                this.dataGridView_stock.Columns.Add(button);
            }

            for (int i = 0; i < total.Count; i++)
            {
       
                dgv.Rows.Add(orderno[i],0,total[i],0,total[i],status[i]);
            }
        }

        private void dataGridView_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_stock.Columns[6].Index)
            {
                string id = dataGridView_stock.Rows[e.RowIndex].Cells[0].Value.ToString();
                Detail_Order dorder = new Detail_Order(id);
                dorder.Show();
            }
        }
    }
}
