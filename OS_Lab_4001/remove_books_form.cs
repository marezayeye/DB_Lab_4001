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
    public partial class remove_books_form : Form
    {
        private SqlConnection cont;
        SqlCommand cmd;
        SqlDataReader dr;

        public remove_books_form()
        {
            InitializeComponent();
            cont = new SqlConnection("Data Source=(local);Initial Catalog=Library_DB;Integrated Security=True");
        }

        private void remove_books_form_Load(object sender, EventArgs e)
        {
            
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cont.Open();
            cmd.Connection = cont;
            DialogResult dialog = MessageBox.Show("آیا از حذف این کتاب مطمئن هستید؟", "حذف کتاب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                cmd.CommandText = "DELETE FROM tblbook WHERE bName=('"+name_box+"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("کتاب مورد نظر با موفقیت حذف شد");
            }
            else
            {
                MessageBox.Show("کتاب مورد نظر حذف نشد");
            }
            cont.Close();
        }

        private void back_dashboard_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Books_form cf = new Books_form();
            cf.Visible = true;
        }
    }
}
