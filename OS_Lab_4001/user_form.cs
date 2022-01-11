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
    public partial class user_form : Form
    {
        private SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public user_form()
        {
            InitializeComponent();
        }

        private void user_form_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dashboard d = new dashboard();
            d.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            add_new_user_form mf = new add_new_user_form();
            mf.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void user_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from User where User_id='" + user_id.Text + "' ";
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            con.Open();
            cmd.CommandText = "select * from User where User_LastName='" +user_familyname.Text+ "' ";
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
        }

        private void user_familyname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
