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
using System.Runtime.CompilerServices;
namespace Probis
{
    public partial class halamaKoki : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        public halamaKoki()
        {
            InitializeComponent();
        }
        private void cetakOrder()
        {
            conn = new SqlConnection(connection);
            conn.Open();
            string query = "select * from horder where status = 0";
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader dr = comm.ExecuteReader();
            //List<string> str = new List<string>();
            int i = 0;
            string tanggal = DateTime.Now.ToString("dd/MM/yy") + " 00:00:00";
            while (dr.Read())
            {
                if (dr.GetValue(2).ToString()==tanggal)
                {
                    if (i / 5 == 0)
                    {
                        templateOrder order = new templateOrder();
                        order.idOrder = dr.GetValue(0).ToString();
                        order.noOrder.Text = "Order Id No - " + (dr.GetValue(0).ToString());
                        int x = 365;

                        order.MdiParent = this;
                        order.Show();

                        order.Location = new Point(25 + (i * x) + (i * 10), 0);

                    }
                    else if (i == 10)
                    {
                        break;
                    }
                    else
                    {
                        templateOrder order = new templateOrder();
                        order.idOrder = dr.GetValue(0).ToString();
                        order.noOrder.Text = "Order Id No - " + (dr.GetValue(0).ToString());
                        int x = 365;
                        int y = 500;
                        order.MdiParent = this;
                        order.Show();
                        order.Location = new Point(25 + ((i - 5) * x) + ((i - 5) * 10), y + 20);
                        ;
                    }
                    i++;
                }
    

            }
            conn.Close();


        }

        private void halamaKoki_Load(object sender, EventArgs e)
        {
            cetakOrder();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                foreach (Form c in this.MdiChildren)
                {
                    c.Close();
                }
                cetakOrder();
            }
            else
            {
                cetakOrder();
            }
        }
    }
}
