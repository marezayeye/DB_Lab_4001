using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Lab_4001
{
    public partial class new_lend_confirmation : Form
    {
        public new_lend_confirmation()
        {
            InitializeComponent();
        }

        private void new_lend_confirmation_Load(object sender, EventArgs e)
        {
            label6.Text = "book name";
            label7.Text = "firstname";
            label8.Text = "lastname";
            label9.Text = new_lend_form.nl_duration;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaring variables

            //

            
            
            //runnig queries and show a message










            MessageBox.Show("امانت با موفقیت ثبت شد");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
