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
        public int nl_book_id;
        public int nl_duration;
        public int nl_user_id;

        public new_lend_form()
        {
            InitializeComponent();
            new_lend_con = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_lend_cmd = new SqlCommand();
            nl_book_id = int.Parse(textBox1.Text);
            new_lend_con.Open();
            new_lend_cmd.CommandText = "Select * From tblBook Where bID = '" + nl_book_id + "' And bBorrowd < 1";
            new_lend_cmd.Connection = new_lend_con;

            new_lend_dr = new_lend_cmd.ExecuteReader();

            if (new_lend_dr.Read())
            {
                MessageBox.Show("کتاب موجود است ، می توانید ادامه دهید");
                append_button.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                monthCalendar1.Visible = true;
                label4.Visible = true;
                numericUpDown1.Visible = true;
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
            append_button.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            monthCalendar1.Visible = false;
            label4.Visible = false;
            numericUpDown1.Visible = false;
        }

        private void append_button_Click(object sender, EventArgs e)
        {
            //getting duration
            nl_duration = Convert.ToInt32(numericUpDown1.Value);
            public int nlc_duration { get { return nl_duration; } }
    }
            

        //getting date
        

                }
            }
        
