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
    public partial class Form_kasir : Form
    {
        public Form_kasir()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void openform(Form f)
        {
            Hide();
            f.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openform(new add_order());     
 
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_list_order_Click(object sender, EventArgs e)
        {
            openform(new listorder());
        }
    }
}
