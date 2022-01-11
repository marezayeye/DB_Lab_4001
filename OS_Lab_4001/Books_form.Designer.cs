
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
            this.remove_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.book_name_box = new System.Windows.Forms.TextBox();
            this.eddit_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.back_dashboard_button = new System.Windows.Forms.Button();
            this.lend_button = new System.Windows.Forms.Button();
            this.scale_button = new System.Windows.Forms.Button();
            this.membership_button = new System.Windows.Forms.Button();
            this.barcode_box = new System.Windows.Forms.TextBox();
            this.translator_name_box = new System.Windows.Forms.TextBox();
            this.publisher_name_box = new System.Windows.Forms.TextBox();
            this.athuur_name_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Red;
            this.remove_button.Location = new System.Drawing.Point(93, 16);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(75, 31);
            this.remove_button.TabIndex = 0;
            this.remove_button.Text = "حذف";
            this.remove_button.UseVisualStyleBackColor = false;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_button.Location = new System.Drawing.Point(12, 15);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 32);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "اضافه";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // book_name_box
            // 
            this.book_name_box.Location = new System.Drawing.Point(12, 102);
            this.book_name_box.Name = "book_name_box";
            this.book_name_box.Size = new System.Drawing.Size(158, 22);
            this.book_name_box.TabIndex = 2;
            this.book_name_box.Text = "نام کتاب";
            this.book_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_name_box.TextChanged += new System.EventHandler(this.book_name_box_TextChanged);
            // 
            // eddit_button
            // 
            this.eddit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.eddit_button.Location = new System.Drawing.Point(12, 53);
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
            this.search_button.Location = new System.Drawing.Point(93, 53);
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
            this.back_dashboard_button.Location = new System.Drawing.Point(1118, 30);
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
            this.lend_button.Location = new System.Drawing.Point(1118, 151);
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
            this.scale_button.Location = new System.Drawing.Point(1118, 110);
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
            this.membership_button.Location = new System.Drawing.Point(1118, 70);
            this.membership_button.Name = "membership_button";
            this.membership_button.Size = new System.Drawing.Size(75, 34);
            this.membership_button.TabIndex = 8;
            this.membership_button.Text = "اعضا";
            this.membership_button.UseVisualStyleBackColor = false;
            this.membership_button.Click += new System.EventHandler(this.button8_Click);
            // 
            // barcode_box
            // 
            this.barcode_box.Location = new System.Drawing.Point(12, 216);
            this.barcode_box.Name = "barcode_box";
            this.barcode_box.Size = new System.Drawing.Size(158, 22);
            this.barcode_box.TabIndex = 9;
            this.barcode_box.Text = "بارکد";
            this.barcode_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // translator_name_box
            // 
            this.translator_name_box.Location = new System.Drawing.Point(12, 188);
            this.translator_name_box.Name = "translator_name_box";
            this.translator_name_box.Size = new System.Drawing.Size(158, 22);
            this.translator_name_box.TabIndex = 10;
            this.translator_name_box.Text = "مترجم";
            this.translator_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.translator_name_box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // publisher_name_box
            // 
            this.publisher_name_box.Location = new System.Drawing.Point(12, 158);
            this.publisher_name_box.Name = "publisher_name_box";
            this.publisher_name_box.Size = new System.Drawing.Size(158, 22);
            this.publisher_name_box.TabIndex = 11;
            this.publisher_name_box.Text = "ناشر";
            this.publisher_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.publisher_name_box.TextChanged += new System.EventHandler(this.publisher_name_box_TextChanged);
            // 
            // athuur_name_box
            // 
            this.athuur_name_box.Location = new System.Drawing.Point(12, 130);
            this.athuur_name_box.Name = "athuur_name_box";
            this.athuur_name_box.Size = new System.Drawing.Size(158, 22);
            this.athuur_name_box.TabIndex = 12;
            this.athuur_name_box.Text = "نویسنده";
            this.athuur_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(181, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "نام کتاب";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(181, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "نویسنده";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(181, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "بارکد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(181, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "مترجم";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(181, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "ناشر";
            // 
            // Books_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1219, 753);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.athuur_name_box);
            this.Controls.Add(this.publisher_name_box);
            this.Controls.Add(this.translator_name_box);
            this.Controls.Add(this.barcode_box);
            this.Controls.Add(this.membership_button);
            this.Controls.Add(this.scale_button);
            this.Controls.Add(this.lend_button);
            this.Controls.Add(this.back_dashboard_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.eddit_button);
            this.Controls.Add(this.book_name_box);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.remove_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Books_form";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox book_name_box;
        private System.Windows.Forms.Button eddit_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button back_dashboard_button;
        private System.Windows.Forms.Button lend_button;
        private System.Windows.Forms.Button scale_button;
        private System.Windows.Forms.Button membership_button;
        private System.Windows.Forms.TextBox barcode_box;
        private System.Windows.Forms.TextBox translator_name_box;
        private System.Windows.Forms.TextBox publisher_name_box;
        private System.Windows.Forms.TextBox athuur_name_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}