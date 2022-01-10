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

namespace OS_Lab_4001
{
    public partial class category_form : Form
    {
        private SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public category_form()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
        }

        //add new catego
        private void button3_Click(object sender, EventArgs e)
        {

        }

        //search
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // these code are test and not connected tp DB
            //string SearchedText = textBox2.Text;
            //List<string> test = new List<string>()
            //{
            //    "one","two","three"
            //};
            //this.dataGridView1.DataSource = test.Contains(SearchedText.ToLower());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //exit to dashboard
        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dashboard d = new dashboard();
            d.Visible = true;
        }

        private void lend_form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void category_form_Load(object sender, EventArgs e)
        {
            // these code are test and not connected tp DB
            //List<string> test = new List<string>()
            //{
            //    "one","two","three"
            //};
            //this.dataGridView1.DataSource = test;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
