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
    public partial class new_lend_form : Form
    {
        private SqlConnection new_lend_con;
        SqlCommand new_lend_cmd;
        SqlDataReader new_lend_dr;
        int new_lend_book_id;
        int lend_duration;
        string lend_user_id;
        public new_lend_form()
        {
            InitializeComponent();
            new_lend_con = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;     //testing gitignore rule
            lend_form s = new lend_form();
            s.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_lend_cmd = new SqlCommand();
            new_lend_book_id = int.Parse(textBox1.Text);
            new_lend_con.Open();
            new_lend_cmd.CommandText = "Select * From tblBook Where bID = '" + new_lend_book_id + "' And bBorrowd > 0";
            new_lend_cmd.Connection = new_lend_con;
            
            new_lend_dr = new_lend_cmd.ExecuteReader();
            
            if (new_lend_dr.Read())
                {
                MessageBox.Show("کتاب موجود است ، می توانید ادامه دهید");
                new_lend_con.Close();
            }
            else
                {
                MessageBox.Show("متاسفانه کتاب موجود نمی باشد");
                new_lend_con.Close();
            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void new_lend_form_Load(object sender, EventArgs e)
        {

        }
    }
}
