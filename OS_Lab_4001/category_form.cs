using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Lab_4001
{
    public partial class category_form : Form
    {
        private SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public category_form()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
        }

    }
}
