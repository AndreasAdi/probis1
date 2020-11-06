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
    public partial class finishorder : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection conn;
        string id;
        int total;
        bool valid;
        public finishorder(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void finishorder_Load(object sender, EventArgs e)
        {

            label1.Text = "No Order : " + id;

            conn = new SqlConnection(connection);

            conn.Open();
            string query = "select m.nama,m.harga,d.jumlah_order from menu m,dorder d where m.id_menu = d.id_menu and id_horder = '" + id + "'";
            loaddetail(query);

            conn.Close();
        }

        private void loaddetail(string query)
        {

            SqlCommand comm = new SqlCommand(query, conn);

            SqlDataReader reader = comm.ExecuteReader();
             total = 0;

            while (reader.Read())
            {
                
                //listmenu.Add(reader.GetValue(0).ToString());
                //listharga.Add(reader.GetValue(1).ToString());
                //listqty.Add(reader.GetValue(2).ToString());

                lbl_menu.Text = lbl_menu.Text.ToString() + reader.GetValue(0).ToString() + "\n";
                lbl_harga.Text = lbl_harga.Text.ToString() +"Rp "+ reader.GetValue(1).ToString() + "\n";
                lbl_qty.Text = lbl_qty.Text.ToString()+" x"+ reader.GetValue(2).ToString() + "\n";

                total += int.Parse(reader.GetValue(1).ToString()) * int.Parse(reader.GetValue(2).ToString()); 

        
            }
            reader.Close();

            lbl_total.Text = "Total    Rp " + total.ToString("#,##0.00");

            //for (int i = 0; i < listmenu.Count; i++)
            //{
            //    dgv.Rows.Add(listmenu[i], listqty[i], int.Parse(listharga[i]));
            //    total += int.Parse(listharga[i]) * int.Parse(listqty[i]);
            //}

            //label3.Text = total.ToString("#,##0.00");
        }

        private void rb_debit_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_debit.Checked)
            {
                lbl_debit.Enabled = true;
                txt_no_debit.Enabled = true;
                btn_validate.Enabled = true;

                label3.Enabled = false;
                label4.Enabled = false;
                txt_kembalian.Enabled = true;
                txt_cash.Enabled = false;

                txt_cash.Text = "";
                txt_kembalian.Text = "";

                button1.Enabled = false;


            }
            else if (rb_cash.Checked)
            {
                lbl_debit.Enabled = false;
                txt_no_debit.Enabled = false;
                btn_validate.Enabled = false;

                label3.Enabled = true;
                label4.Enabled = false;
                txt_kembalian.Enabled = true;
                txt_cash.Enabled = true;

                button1.Enabled = false;
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (txt_no_debit.Text.Length==12)
            {
                pictureBox1.Visible = true;
                valid = true;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debit Card Number is Not Valid");
            }
          
        }

        private void txt_no_debit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_cash.Checked)
            {
                if (int.Parse(txt_cash.Text.ToString()) >= total)
                {
                    conn.Open();
                    SqlCommand updateHorder = new SqlCommand("UPDATE horder set status = 3  WHERE id_horder = " + id + "", conn);
                    updateHorder.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Pay amount is not enough !");
                }
            }
            else if (rb_debit.Checked)
            {
                if (valid)
                {
                    conn.Open();
                    SqlCommand updateHorder = new SqlCommand("UPDATE horder set status = 3  WHERE id_horder = " + id + "", conn);
                    updateHorder.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Debit Card Number is Not Valid");
                }
            }

        
        }

        private void txt_cash_TextChanged(object sender, EventArgs e)
        {
            int kembalian = 0;

            if (txt_cash.Text.Length>0)
            {
                kembalian = int.Parse(txt_cash.Text.ToString()) - total;

                if (kembalian > 0)
                {
                    button1.Enabled = true;
                    txt_kembalian.Text = "Rp " + kembalian.ToString("#,##0.00");
                }

            }
            else
            {
                txt_kembalian.Text ="";
            }
          
        }
    }
}
