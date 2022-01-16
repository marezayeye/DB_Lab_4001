
namespace OS_Lab_4001
{
    partial class Books_form
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
            this.components = new System.ComponentModel.Container();
            this.remove_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.eddit_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.back_dashboard_button = new System.Windows.Forms.Button();
            this.lend_button = new System.Windows.Forms.Button();
            this.scale_button = new System.Windows.Forms.Button();
            this.membership_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.book_name_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.book_dataGridView = new System.Windows.Forms.DataGridView();
            this.books_name_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Athour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.library_DBDataSet = new OS_Lab_4001.Library_DBDataSet();
            this.libraryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Red;
            this.remove_button.Location = new System.Drawing.Point(12, 16);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(75, 31);
            this.remove_button.TabIndex = 0;
            this.remove_button.Text = "حذف";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_button.Location = new System.Drawing.Point(93, 16);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 32);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "اضافه";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // eddit_button
            // 
            this.eddit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.eddit_button.Location = new System.Drawing.Point(93, 54);
            this.eddit_button.Name = "eddit_button";
            this.eddit_button.Size = new System.Drawing.Size(75, 32);
            this.eddit_button.TabIndex = 3;
            this.eddit_button.Text = "ویرایش";
            this.eddit_button.UseVisualStyleBackColor = false;
            this.eddit_button.Click += new System.EventHandler(this.eddit_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.search_button.Location = new System.Drawing.Point(12, 53);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 32);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "جستجو";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // back_dashboard_button
            // 
            this.back_dashboard_button.BackColor = System.Drawing.Color.Aqua;
            this.back_dashboard_button.Location = new System.Drawing.Point(1232, 13);
            this.back_dashboard_button.Name = "back_dashboard_button";
            this.back_dashboard_button.Size = new System.Drawing.Size(75, 34);
            this.back_dashboard_button.TabIndex = 5;
            this.back_dashboard_button.Text = "بازگشت";
            this.back_dashboard_button.UseVisualStyleBackColor = false;
            this.back_dashboard_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // lend_button
            // 
            this.lend_button.BackColor = System.Drawing.Color.Aqua;
            this.lend_button.Location = new System.Drawing.Point(1232, 134);
            this.lend_button.Name = "lend_button";
            this.lend_button.Size = new System.Drawing.Size(75, 29);
            this.lend_button.TabIndex = 6;
            this.lend_button.Text = "امانات";
            this.lend_button.UseVisualStyleBackColor = false;
            this.lend_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // scale_button
            // 
            this.scale_button.BackColor = System.Drawing.Color.Aqua;
            this.scale_button.Location = new System.Drawing.Point(1232, 93);
            this.scale_button.Name = "scale_button";
            this.scale_button.Size = new System.Drawing.Size(75, 35);
            this.scale_button.TabIndex = 7;
            this.scale_button.Text = "دسته بندی";
            this.scale_button.UseVisualStyleBackColor = false;
            this.scale_button.Click += new System.EventHandler(this.scale_button_Click);
            // 
            // membership_button
            // 
            this.membership_button.BackColor = System.Drawing.Color.Aqua;
            this.membership_button.Location = new System.Drawing.Point(1232, 53);
            this.membership_button.Name = "membership_button";
            this.membership_button.Size = new System.Drawing.Size(75, 34);
            this.membership_button.TabIndex = 8;
            this.membership_button.Text = "اعضا";
            this.membership_button.UseVisualStyleBackColor = false;
            this.membership_button.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(181, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 90;
            this.label11.Text = "برچسب";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 79);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 22);
            this.textBox5.TabIndex = 89;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(181, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 88;
            this.label10.Text = "دسته بندی";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 51);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(158, 22);
            this.textBox6.TabIndex = 87;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(645, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 86;
            this.label12.Text = "سال چاپ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(476, 110);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(158, 22);
            this.textBox7.TabIndex = 85;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(181, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 84;
            this.label13.Text = "موجودی";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 107);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(158, 22);
            this.textBox8.TabIndex = 83;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(427, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 17);
            this.label14.TabIndex = 82;
            this.label14.Text = "مکان";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(258, 54);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(158, 22);
            this.textBox9.TabIndex = 81;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(427, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 17);
            this.label15.TabIndex = 80;
            this.label15.Text = "ناشر";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(427, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 17);
            this.label16.TabIndex = 79;
            this.label16.Text = "مترجم";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(645, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 17);
            this.label17.TabIndex = 78;
            this.label17.Text = "بارکد";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.Location = new System.Drawing.Point(645, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 17);
            this.label18.TabIndex = 77;
            this.label18.Text = "نویسنده";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Location = new System.Drawing.Point(63, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 17);
            this.label19.TabIndex = 76;
            this.label19.Text = "نام کتاب";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(476, 82);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(158, 22);
            this.textBox10.TabIndex = 75;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(258, 110);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(158, 22);
            this.textBox11.TabIndex = 74;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(258, 82);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(158, 22);
            this.textBox12.TabIndex = 73;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(476, 54);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(158, 22);
            this.textBox13.TabIndex = 72;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // book_name_search
            // 
            this.book_name_search.Location = new System.Drawing.Point(12, 122);
            this.book_name_search.Name = "book_name_search";
            this.book_name_search.Size = new System.Drawing.Size(158, 22);
            this.book_name_search.TabIndex = 71;
            this.book_name_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Location = new System.Drawing.Point(378, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 191);
            this.panel1.TabIndex = 91;
            // 
            // book_dataGridView
            // 
            this.book_dataGridView.AllowUserToAddRows = false;
            this.book_dataGridView.AllowUserToDeleteRows = false;
            this.book_dataGridView.AutoGenerateColumns = false;
            this.book_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.books_name_data,
            this.barcode,
            this.Athour,
            this.year,
            this.location,
            this.translator,
            this.publisher,
            this.category,
            this.tags,
            this.brrowed});
            this.book_dataGridView.DataSource = this.library_DBDataSet;
            this.book_dataGridView.Location = new System.Drawing.Point(174, 16);
            this.book_dataGridView.Name = "book_dataGridView";
            this.book_dataGridView.ReadOnly = true;
            this.book_dataGridView.RowHeadersWidth = 51;
            this.book_dataGridView.RowTemplate.Height = 24;
            this.book_dataGridView.Size = new System.Drawing.Size(1052, 298);
            this.book_dataGridView.TabIndex = 92;
            this.book_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.book_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // books_name_data
            // 
            this.books_name_data.DataPropertyName = "bName";
            this.books_name_data.HeaderText = "نام کتاب";
            this.books_name_data.MinimumWidth = 6;
            this.books_name_data.Name = "books_name_data";
            this.books_name_data.ReadOnly = true;
            this.books_name_data.Width = 125;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "bID";
            this.barcode.HeaderText = "بارکد";
            this.barcode.MinimumWidth = 6;
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 125;
            // 
            // Athour
            // 
            this.Athour.DataPropertyName = "bAuthor";
            this.Athour.HeaderText = "نویسنده";
            this.Athour.MinimumWidth = 6;
            this.Athour.Name = "Athour";
            this.Athour.ReadOnly = true;
            this.Athour.Width = 125;
            // 
            // year
            // 
            this.year.DataPropertyName = "bYear";
            this.year.HeaderText = "سال چاپ";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Width = 125;
            // 
            // location
            // 
            this.location.DataPropertyName = "Book_Location";
            this.location.HeaderText = "مکان";
            this.location.MinimumWidth = 6;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Width = 125;
            // 
            // translator
            // 
            this.translator.DataPropertyName = "bTranslator";
            this.translator.HeaderText = "مترجم";
            this.translator.MinimumWidth = 6;
            this.translator.Name = "translator";
            this.translator.ReadOnly = true;
            this.translator.Width = 125;
            // 
            // publisher
            // 
            this.publisher.DataPropertyName = "bPublisher";
            this.publisher.HeaderText = "ناشر";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Width = 125;
            // 
            // category
            // 
            this.category.DataPropertyName = "bCategory";
            this.category.HeaderText = "دسته بندی";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // tags
            // 
            this.tags.DataPropertyName = "bTags";
            this.tags.HeaderText = "برچسب";
            this.tags.MinimumWidth = 6;
            this.tags.Name = "tags";
            this.tags.ReadOnly = true;
            this.tags.Width = 125;
            // 
            // brrowed
            // 
            this.brrowed.DataPropertyName = "bBorrowd";
            this.brrowed.HeaderText = "موجودی";
            this.brrowed.MinimumWidth = 6;
            this.brrowed.Name = "brrowed";
            this.brrowed.ReadOnly = true;
            this.brrowed.Width = 125;
            // 
            // library_DBDataSet
            // 
            this.library_DBDataSet.DataSetName = "Library_DBDataSet";
            this.library_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryDBDataSetBindingSource
            // 
            this.libraryDBDataSetBindingSource.DataSource = this.library_DBDataSet;
            this.libraryDBDataSetBindingSource.Position = 0;
            // 
            // Books_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1319, 530);
            this.Controls.Add(this.book_dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.book_name_search);
            this.Controls.Add(this.membership_button);
            this.Controls.Add(this.scale_button);
            this.Controls.Add(this.lend_button);
            this.Controls.Add(this.back_dashboard_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.eddit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.remove_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Books_form";
            this.Text = "کتاب ها";
            this.Load += new System.EventHandler(this.Books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button eddit_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button back_dashboard_button;
        private System.Windows.Forms.Button lend_button;
        private System.Windows.Forms.Button scale_button;
        private System.Windows.Forms.Button membership_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox book_name_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView book_dataGridView;
        private System.Windows.Forms.BindingSource libraryDBDataSetBindingSource;
        private Library_DBDataSet library_DBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn books_name_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Athour;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn translator;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn brrowed;
    }
}