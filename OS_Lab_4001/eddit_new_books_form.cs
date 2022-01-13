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
    public partial class eddit_new_books_form : Form
    {
        public eddit_new_books_form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Books_form d = new Books_form();
            d.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void book_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void add_new_books_form_Load(object sender, EventArgs e)
        {

        }
    }
}
