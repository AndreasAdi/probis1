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
    public partial class add_order : Form
    {
        
        private Form currentChildForm;
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Cafe.mdf;Integrated Security=True;MultipleActiveResultSets=true;Connect Timeout=30";
        SqlConnection conn;
        SqlDataReader readerInsertdetail;
        public add_order()
        {
            InitializeComponent();
            conn = new SqlConnection(connection);
        }

        private void add_order_Load(object sender, EventArgs e)
        {
            var topLeftHeaderCell = dataGridView_order.TopLeftHeaderCell;
            OpenChildForm(new Coffee(this));
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void jFlatButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Coffee(this));
        }

        private void jFlatButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new beverage(this));
        }

        private void jFlatButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new desert(this));
        }

        private void jFlatButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new snack(this));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_order_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView_order.Rows)
            {
                int harga = int.Parse(row.Cells[2].Value.ToString());
                int qty = int.Parse(row.Cells[1].Value.ToString());
                int subtotal = harga * qty;
                total += subtotal;

            }
            label_total.Text = total.ToString("#,##0.00");
        }

        private void dataGridView_order_Validated(object sender, EventArgs e)
        {
  
        }

        private void dataGridView_order_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView_order.Rows)
            {
                int harga = int.Parse(row.Cells[2].Value.ToString());
                int qty = int.Parse(row.Cells[1].Value.ToString());
                int subtotal = harga * qty;
                total += subtotal;

            }
            label_total.Text = total.ToString("#,##0.00");
        }

        private void jFlatButton5_Click(object sender, EventArgs e)
        {
            conn.Open();
            //MessageBox.Show(Coffee.catatan);
            //MessageBox.Show(DateTime.Now.ToShortDateString());
            string justDigits = new string(label_total.Text.Where(char.IsDigit).ToArray());
            int total = int.Parse(justDigits);
            //MessageBox.Show(total.ToString());
            SqlCommand insertHeaderOrder = new SqlCommand("Insert into horder(jumlah_harga,tanggal,status,catatan) values(" + total + ",PARSE('" + DateTime.Now.ToShortDateString() + "' as date USING 'AR-LB'),0,'"+Coffee.catatan+"')", conn);
            SqlDataReader reader = insertHeaderOrder.ExecuteReader();
            reader.Close();
            SqlDataAdapter adp_IdHorder = new SqlDataAdapter("select id_horder from horder order by id_horder desc", conn);
            DataSet dset = new DataSet();
            adp_IdHorder.Fill(dset);
            //MessageBox.Show(dset.Tables[0].Rows[0].ItemArray[0].ToString());
            int id_horder = int.Parse(dset.Tables[0].Rows[0].ItemArray[0].ToString());
            conn.Close();
            conn.Open();
            foreach (DataGridViewRow row in dataGridView_order.Rows)
            {
                int jumlahOrder= int.Parse(row.Cells[1].Value.ToString());
                string nama = row.Cells[0].Value.ToString();
                SqlDataAdapter adp_IdMenu = new SqlDataAdapter("Select id_menu from menu where nama= '" + nama + "'", conn);
                DataSet dsetIdMenu = new DataSet();
                adp_IdMenu.Fill(dsetIdMenu);
                int id_menu =int.Parse(dsetIdMenu.Tables[0].Rows[0].ItemArray[0].ToString());
                SqlCommand insertDetailOrder = new SqlCommand("Insert into dorder(id_horder,id_menu,jumlah_order)values("+id_horder+","+id_menu+","+jumlahOrder+")", conn);
                readerInsertdetail = insertDetailOrder.ExecuteReader();
            }
            readerInsertdetail.Close();
            conn.Close();
            MessageBox.Show("Berhasil add order !");
            this.Close();
        }

        private void add_order_FormClosing(object sender, FormClosingEventArgs e)
        {
            openform(new Form_kasir());
        }

        private void openform(Form f)
        {
            f.Show();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jFlatButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
