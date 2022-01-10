using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Lab_4001
{
    public partial class Books_form : Form
    {
        public Books_form()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dashboard d = new dashboard();
            d.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            lend_form l = new lend_form();
            l.Visible = true;
        }

        private void scale_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            category_form cf = new category_form();
            cf.Visible = true;
        }

        private void eddit_button_Click(object sender, EventArgs e)
        {

        }

        private void book_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisher_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
