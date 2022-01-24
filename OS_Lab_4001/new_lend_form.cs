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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_lend_cmd = new SqlCommand();
            new_lend_book_id = int.Parse(textBox1.Text);
            new_lend_con.Open();
            new_lend_cmd.CommandText = "Select * From tblBook Where bID = '" + new_lend_book_id + "' And bBorrowd < 1";
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
            var appendquery1 = new SqlCommand("INSERT INTO tblLend (lBook_id,lUser,lDate,lDaycount,lReturned) VALUES (@book,@uid,@date, @duration, 0)",new_lend_con);
            //new_lend_cmd.CommandText = "INSERT INTO tblLend (lLend_id,lUser,lDate,lDaycount,lReturned) VALUES (NULL,@lend_user_id,@new_lend_date, @lend_duration, 0)";
            appendquery1.Parameters.Add(new SqlParameter("book", new_lend_book_id));
            appendquery1.Parameters.Add(new SqlParameter("uid", lend_user_id));
            appendquery1.Parameters.Add(new SqlParameter("date", new_lend_date));
            appendquery1.Parameters.Add(new SqlParameter("duration", lend_duration));

            var appendquery2 = new SqlCommand("UPDATE tblUser SET = uBorrowedcount = uBorrowedcount + 1 WHERE uId = @uid");
            appendquery2.Parameters.Add(new SqlParameter("uid", lend_user_id));
            int append_success1 = appendquery1.ExecuteNonQuery();
            int append_success2 = appendquery2.ExecuteNonQuery();
            if ((append_success1 + append_success2) >=2 )
            {
                MessageBox.Show("امانت با موفقیت ثبت شد ");
                new_lend_con.Close();
                this.Visible = false;
                
                

            }
            else
            {
                MessageBox.Show("ثبت امانت انجام نشد.");
                new_lend_con.Close();

            }
            


        }







        }
    }

