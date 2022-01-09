
namespace OS_Lab_4001
{
    partial class lend_return_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_familyname = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.familyname = new System.Windows.Forms.TextBox();
            this.birthday = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "عضویت جدید";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "جست و جو";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "جستجو";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "کد عضویت";
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(551, 43);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(142, 22);
            this.user_id.TabIndex = 5;
            this.user_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "نام خانوادگی";
            // 
            // user_familyname
            // 
            this.user_familyname.Location = new System.Drawing.Point(551, 117);
            this.user_familyname.Name = "user_familyname";
            this.user_familyname.Size = new System.Drawing.Size(142, 22);
            this.user_familyname.TabIndex = 8;
            this.user_familyname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(571, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "جست و جو";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(12, 92);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 47);
            this.button5.TabIndex = 12;
            this.button5.Text = "حذف عضویت";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(571, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 41);
            this.button6.TabIndex = 13;
            this.button6.Text = "بازگشت به داشبورد";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "آدرس";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "تاریخ تولد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "جنسیت";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "نام خانوادگی";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "نام";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(216, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(142, 22);
            this.name.TabIndex = 19;
            // 
            // familyname
            // 
            this.familyname.Location = new System.Drawing.Point(216, 43);
            this.familyname.Name = "familyname";
            this.familyname.Size = new System.Drawing.Size(142, 22);
            this.familyname.TabIndex = 20;
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(216, 97);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(142, 22);
            this.birthday.TabIndex = 22;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(216, 151);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(142, 22);
            this.address.TabIndex = 23;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(216, 71);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(142, 22);
            this.gender.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "شماره تلفن";
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(216, 125);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(142, 22);
            this.phonenumber.TabIndex = 26;
            // 
            // lend_return_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.address);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.familyname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.user_familyname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "lend_return_form";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.lend_return_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user_familyname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox familyname;
        private System.Windows.Forms.TextBox birthday;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phonenumber;
    }
}