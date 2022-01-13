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
    public partial class add_new_books_form : Form
    {
        private SqlConnection cont;
        SqlCommand cmd;
        SqlDataReader dr;

        public add_new_books_form()
        {
            InitializeComponent();
            cont = new SqlConnection("Data Source=(local);Initial Catalog=Library_DB;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cont.Open();
            cmd.Connection = cont;
            cmd.CommandText = "insert into tblBook values('"+barcode_box.Text+"','"+book_name_box.Text+"','"+athur_name_box.Text+"','"+year_box.Text+"','"+category_box.Text+"','"+tag_box.Text+ "','"+borrow_box.Text+ "','"+location_box.Text+"','"+publisher_name_box.Text+"','"+translator_name_box.Text+"')";
            cmd.ExecuteNonQuery();
            cont.Close();
            MessageBox.Show("کتاب مورد نظر با موفقیت ثبت شد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Books_form cf = new Books_form();
            cf.Visible = true;
        }

        private void eddit_book_form_Load(object sender, EventArgs e)
        {

        }

        private void publisher_name_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//(bID,bName,bAuthor,bYear,bCategory,bTaggs,bBorrowed,bLocation,bPublisher,bTranslator)
