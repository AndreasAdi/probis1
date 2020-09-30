using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public add_order()
        {
            InitializeComponent();
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
            label_total.Text = total.ToString();
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
            label_total.Text = total.ToString();
        }
    }
}
