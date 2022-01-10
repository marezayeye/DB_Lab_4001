
namespace OS_Lab_4001
{
    partial class Form3
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.athuur_name_box = new System.Windows.Forms.TextBox();
            this.publisher_name_box = new System.Windows.Forms.TextBox();
            this.translator_name_box = new System.Windows.Forms.TextBox();
            this.barcode_box = new System.Windows.Forms.TextBox();
            this.book_name_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(268, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "ناشر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(268, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "مترجم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(268, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "بارکد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(268, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "نویسنده";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(268, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "نام کتاب";
            // 
            // athuur_name_box
            // 
            this.athuur_name_box.Location = new System.Drawing.Point(99, 84);
            this.athuur_name_box.Name = "athuur_name_box";
            this.athuur_name_box.Size = new System.Drawing.Size(158, 22);
            this.athuur_name_box.TabIndex = 22;
            this.athuur_name_box.Text = "نویسنده";
            this.athuur_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // publisher_name_box
            // 
            this.publisher_name_box.Location = new System.Drawing.Point(99, 112);
            this.publisher_name_box.Name = "publisher_name_box";
            this.publisher_name_box.Size = new System.Drawing.Size(158, 22);
            this.publisher_name_box.TabIndex = 21;
            this.publisher_name_box.Text = "ناشر";
            this.publisher_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // translator_name_box
            // 
            this.translator_name_box.Location = new System.Drawing.Point(99, 142);
            this.translator_name_box.Name = "translator_name_box";
            this.translator_name_box.Size = new System.Drawing.Size(158, 22);
            this.translator_name_box.TabIndex = 20;
            this.translator_name_box.Text = "مترجم";
            this.translator_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // barcode_box
            // 
            this.barcode_box.Location = new System.Drawing.Point(99, 170);
            this.barcode_box.Name = "barcode_box";
            this.barcode_box.Size = new System.Drawing.Size(158, 22);
            this.barcode_box.TabIndex = 19;
            this.barcode_box.Text = "بارکد";
            this.barcode_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // book_name_box
            // 
            this.book_name_box.Location = new System.Drawing.Point(99, 56);
            this.book_name_box.Name = "book_name_box";
            this.book_name_box.Size = new System.Drawing.Size(158, 22);
            this.book_name_box.TabIndex = 18;
            this.book_name_box.Text = "نام کتاب";
            this.book_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_name_box.TextChanged += new System.EventHandler(this.book_name_box_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(136, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "ذخیره";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(366, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 29;
            this.button2.Text = "بازگشت";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "افزودن کتاب جدید";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 259);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.athuur_name_box);
            this.Controls.Add(this.publisher_name_box);
            this.Controls.Add(this.translator_name_box);
            this.Controls.Add(this.barcode_box);
            this.Controls.Add(this.book_name_box);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox athuur_name_box;
        private System.Windows.Forms.TextBox publisher_name_box;
        private System.Windows.Forms.TextBox translator_name_box;
        private System.Windows.Forms.TextBox barcode_box;
        private System.Windows.Forms.TextBox book_name_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}