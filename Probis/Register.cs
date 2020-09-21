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
    public partial class Register : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        public Register()
        {
            InitializeComponent();
            conn = new SqlConnection(connection);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("open");
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string username;
            int tipe;
            string password;
            int ctr_Userkembar=0;

            username = textBox_username.Text;
            password = textBox_password.Text;
            tipe = cb_type.SelectedIndex;

            string query_cekUser = "select * from [user]";
            SqlDataAdapter adp_selectUser = new SqlDataAdapter(query_cekUser, conn);
            DataSet dset = new DataSet();
            adp_selectUser.Fill(dset, "type");
            for(int i = 0; i < dset.Tables[0].Rows.Count;i++)
            {
                if (dset.Tables[0].Rows[i].ItemArray[1].ToString() == username || dset.Tables[0].Rows[i].ItemArray[2].ToString()==password)
                {
                    ctr_Userkembar++;
                }
            }
            if (ctr_Userkembar > 0)
            {
                MessageBox.Show("Tidak Valid,Username atau Password telah terdaftar");
            }
            else
            {
                string queryInsertUser = "INSERT INTO [user] VALUES('" + username + "','" + password + "'," + tipe + ")";
                SqlCommand cmd = new SqlCommand(queryInsertUser, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("User telah berhasil di daftarkan");
                }

                reader.Close();
            }
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
