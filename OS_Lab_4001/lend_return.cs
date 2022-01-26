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
    public partial class lend_return : Form
    {
        public lend_return()
        {
            InitializeComponent();
        }

        SqlConnection lr_con = new SqlConnection("Data Source =.; Initial Catalog = Library_DB; Integrated Security = True");
        SqlCommand lr_cmd = new SqlCommand();
        SqlDataReader lr_dr;
        private void lend_return_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lr_cmd = new SqlCommand();
            int lr_lend_id = int.Parse(textBox1.Text);
            lr_con.Open();
            lr_cmd.CommandText = "SELECT * FROM tblLend WHERE lId = '" + textBox1.Text + "' AND lReturned = 0 ";
            lr_cmd.Connection = lr_con;

            if (lr_dr.Read())
            {
                MessageBox.Show("کد امانت معتبر است. می توانید ادامه دهید");
                button1.Visible = true;
                button2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label4.Visible = true;
                lr_con.Close();
            }
            else 
            {
                MessageBox.Show("امانت نامعتبر. این کد قبلا بازگشت داده شده یا اشتباه است.");
                lr_con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getting book id 

            //getting user id

            //runnig tblLend query
            
            //running tblUser query

            //running tblBook query
        }
    }
}
