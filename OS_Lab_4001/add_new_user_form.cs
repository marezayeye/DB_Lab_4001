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
   
    public partial class add_new_user_form : Form
    {
        private SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public add_new_user_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "insert into User(User_FirstName,User_LastName,User_Gender,User_Birthday,User_PhoneNumber,User_Address,User_RegisterationDate) values ('" + name.Text + "','" + familyname.Text + "','" + gender.Text + "','" + birthday.Text + "','" + phonenumber.Text + "','" + address.Text + "','"+registerdate.Text+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("عضویت با موفقیت انجام شد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            user_form lm = new user_form();
            lm.Visible = true;
        }

        private void add_new_user_form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
