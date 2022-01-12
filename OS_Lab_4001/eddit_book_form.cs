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
    public partial class eddit_book_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
        
        public eddit_book_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlConnection cmd = con.CreateCommand();
            SqlConnection cmd.CommandType = CommandType.Text;
            cmd.CommandText = "inser into tblBook values(' +barcode_box.Text+ ','" + book_name_box.Text+ "','" + athur_name_box.Text + "','+ year_box.Text+','" + category_box.Text + "','" + tag_box.Text + "','" + borrow_box.Text + "','" + location_box.Text + "','" + translator_name_box.Text + "','" + publisher_name_box.Text + "')";
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void eddit_book_form_Load(object sender, EventArgs e)
        {

        }
    }
}
