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
    public partial class lend_form : Form
    {
        SqlConnection lend_con = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
        SqlCommand lend_cmd;
        
        public lend_form()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            new_lend_form nlf = new new_lend_form();
            nlf.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("آیا از ثبت بازگشت مطمئن هستید؟","ثبت بازگشت امانت", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                int return_lend_id = Convert.ToInt32(textBox1.Text);
                int return_book_id = Convert.ToInt32(textBox2.Text);
                int return_user_id = Convert.ToInt32(textBox3.Text);

                using (var return_con = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True"))
                {
                    return_con.Open();

                    using (var command = return_con.CreateCommand())
                    {
                        command.CommandText = "UPDATE  tblLend SET lReturned = 1 WHERE lId = @lid;";
                        command.Parameters.Add(new SqlParameter("lid", return_lend_id));
                        command.ExecuteNonQuery();

                        command.CommandText = "UPDATE tblUser SET uBorrowedcount = uBorrowedcount + -1 WHERE uId = @uid;";
                        command.Parameters.Add(new SqlParameter("uid", return_user_id));
                        command.ExecuteNonQuery();

                        command.CommandText = "UPDATE tblBook SET bBorrowd = 0 WHERE bID = @bid;";
                        command.Parameters.Add(new SqlParameter("bid", return_book_id));
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("بازگشت کتاب با موفقیت ثبت شد");
                lend_dg.Refresh();
            }
            else
            {
                MessageBox.Show("عملیات به درخواست کاربر لغو شد");
            }
            
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dashboard d = new dashboard();
            d.Visible = true;
        }

        private void lend_form_Load(object sender, EventArgs e)
        {
            //Showing values in DataGrid on Form Load Event
            lend_con.Open();
            SqlDataAdapter lend_da = new SqlDataAdapter("SELECT * FROM tblLend", lend_con);
            DataTable lend_dt = new DataTable();
            lend_da.Fill(lend_dt);
            lend_dg.DataSource = lend_dt;
            lend_dg.Refresh();
            lend_con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int lend_search_field3 = Convert.ToInt32(textBox3.Text);
            lend_con.Open();
            SqlDataAdapter lend_da = new SqlDataAdapter("SELECT * FROM tblLend WHERE lUser = ' " + lend_search_field3 + " ' ", lend_con);
            DataTable lend_dt = new DataTable();
            lend_da.Fill(lend_dt);
            lend_dg.DataSource = lend_dt;
            lend_con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lend_search_field1 = Convert.ToInt32(textBox1.Text);
            lend_con.Open();
            SqlDataAdapter lend_da = new SqlDataAdapter("SELECT * FROM tblLend WHERE lLend_id = ' " + lend_search_field1 + " ' ", lend_con);
            DataTable lend_dt = new DataTable();
            lend_da.Fill(lend_dt);
            lend_dg.DataSource = lend_dt;
            lend_con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lend_search_field2 = Convert.ToInt32(textBox2.Text);
            lend_con.Open();
            SqlDataAdapter lend_da = new SqlDataAdapter("SELECT * FROM tblLend WHERE lBook_id = ' " + lend_search_field2 + " ' ", lend_con);
            DataTable lend_dt = new DataTable();
            lend_da.Fill(lend_dt);
            lend_dg.DataSource = lend_dt;
            lend_con.Close();

        }

        private void lend_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int lend_id = Convert.ToInt32(lend_dg.SelectedCells[0].Value.ToString());
            try
            {
                lend_cmd = new SqlCommand();
                lend_con.Open();
                lend_cmd.Connection = lend_con;
                lend_cmd.CommandType = CommandType.Text;
                lend_cmd.CommandText = "SELECT * FROM tblLend WHERE lId =" + lend_id + "";
                lend_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(lend_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {

                    textBox1.Text = dr["lId"].ToString();
                    textBox2.Text = dr["lBook"].ToString();
                    textBox3.Text = dr["lUser"].ToString();
                }
                lend_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lend_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lend_id = Convert.ToInt32(lend_dg.SelectedCells[0].Value.ToString());
            try
            {
                lend_cmd = new SqlCommand();
                lend_con.Open();
                lend_cmd.Connection = lend_con;
                lend_cmd.CommandType = CommandType.Text;
                lend_cmd.CommandText = "SELECT * FROM tblLend WHERE lId =" + lend_id + "";
                lend_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(lend_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    
                    textBox1.Text = dr["lLend_id"].ToString();
                    textBox2.Text = dr["lBook_id"].ToString();
                    textBox3.Text = dr["lUser"].ToString();
                }
                lend_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lend_dg_SelectionChanged(object sender, EventArgs e)
        {
            if (lend_dg.SelectedCells.Count > 0)
            {
                int selectedrowindex = lend_dg.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = lend_dg.Rows[selectedrowindex];
                textBox1.Text = Convert.ToString(selectedRow.Cells["lLend_id"].Value);
                textBox2.Text = Convert.ToString(selectedRow.Cells["lBook_id"].Value);
                textBox3.Text = Convert.ToString(selectedRow.Cells["lUser"].Value);
            }
        }
    }
}
