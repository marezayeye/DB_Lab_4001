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
        int lend_user_id;
        
        public new_lend_form()
        {
            InitializeComponent();
            new_lend_con = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;     
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

        private void append_button_Click(object sender, EventArgs e)
        {
            //Preparing Values 
            int lend_duration = Convert.ToInt32(numericUpDown1.Value);
            lend_user_id = Convert.ToInt32(textBox2.Text);
            new_lend_book_id = Convert.ToInt32(textBox1.Text);
            DateTime new_lend_date = monthCalendar1.SelectionStart;
            
            //Reseting Connection
            new_lend_con.Close();
            new_lend_con.Open();
            
            //Query Execution
            var appendquery = new SqlCommand("INSERT INTO tblLend (lUser,lDate,lDaycount,lReturned) VALUES (@uid,@date, @duration, 0)",new_lend_con);
            //new_lend_cmd.CommandText = "INSERT INTO tblLend (lLend_id,lUser,lDate,lDaycount,lReturned) VALUES (NULL,@lend_user_id,@new_lend_date, @lend_duration, 0)";
            appendquery.Parameters.Add(new SqlParameter("uid", lend_user_id));
            appendquery.Parameters.Add(new SqlParameter("date", new_lend_date));
            appendquery.Parameters.Add(new SqlParameter("duration", lend_duration));
            int append_success = appendquery.ExecuteNonQuery();
            if (append_success > 0)
            {
                MessageBox.Show("امانت با موفقیت ثبت شد ");
                

            }
            else
            {
                MessageBox.Show("ثبت امانت انجام نشد.");
            }
            


        }







        }
    }

