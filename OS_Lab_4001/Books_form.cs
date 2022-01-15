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

namespace OS_Lab_4001
{
    public partial class Books_form : Form
    {
        private SqlConnection cont;

        public Books_form()
        {
            InitializeComponent();
            cont = new SqlConnection("Data Source=(local);Initial Catalog=Library_DB;Integrated Security=True");
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
            this.Visible = false;
            user_form o = new user_form();
            o.Visible = true;
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
            this.Visible = false;
            eddit_new_books_form cf = new eddit_new_books_form();
            cf.Visible = true;
        }

        private void book_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisher_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            cont.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM tblBook", cont);// Where bName='" + book_name_search + "'
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            book_dataGridView.DataSource = dtbl;
            cont.Close();
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

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            add_new_books_form cf = new add_new_books_form();
            cf.Visible = true;
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            remove_books_form cf = new remove_books_form();
            cf.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
