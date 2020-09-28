using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Probis
{
    public partial class Login : Form
    {
        
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        public Login()
        {
            InitializeComponent();
           conn = new SqlConnection(connection);
           // MessageBox.Show(connection);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            conn.Open();
            string username=textBox_username.Text;
            string password = textBox_password.Text;
            string querySelectUser = "select * from [user] where username='" + username + "' and password='" + password + "'";
            SqlDataAdapter adp_selectUser = new SqlDataAdapter(querySelectUser, conn);
            DataSet dset = new DataSet();
            adp_selectUser.Fill(dset, "type");
            int log = dset.Tables[0].Rows.Count;
            if (log > 0)
            {
                if (dset.Tables[0].Rows[0].ItemArray[3].ToString() == "0")
                {
                    listorder L_order = new listorder();
                    L_order.Show();
                }
                else if(dset.Tables[0].Rows[0].ItemArray[3].ToString() == "1")
                {
                    Form_kasir kasir = new Form_kasir();
                    kasir.Show();
                }
                else if(dset.Tables[0].Rows[0].ItemArray[3].ToString() == "2")
                {
                    gudang g = new gudang();
                    g.Show();
                }
            }
            else
            {
                MessageBox.Show("Username atau password tidak terdaftar");
            }
            conn.Close();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
