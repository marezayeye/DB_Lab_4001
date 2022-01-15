
namespace OS_Lab_4001
{
    partial class remove_books_form
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
            this.back_dashboard_button = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Red;
            this.remove_button.Location = new System.Drawing.Point(139, 154);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(75, 31);
            this.remove_button.TabIndex = 1;
            this.remove_button.Text = "حذف";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // back_dashboard_button
            // 
            this.back_dashboard_button.BackColor = System.Drawing.Color.Aqua;
            this.back_dashboard_button.Location = new System.Drawing.Point(258, 30);
            this.back_dashboard_button.Name = "back_dashboard_button";
            this.back_dashboard_button.Size = new System.Drawing.Size(75, 34);
            this.back_dashboard_button.TabIndex = 6;
            this.back_dashboard_button.Text = "بازگشت";
            this.back_dashboard_button.UseVisualStyleBackColor = false;
            this.back_dashboard_button.Click += new System.EventHandler(this.back_dashboard_button_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(150, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 17);
            this.label19.TabIndex = 77;
            this.label19.Text = "نام کتاب";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(124, 114);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 22);
            this.name_box.TabIndex = 78;
            this.name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // remove_books_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 281);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.back_dashboard_button);
            this.Controls.Add(this.remove_button);
            this.Name = "remove_books_form";
            this.Text = "حذف کتاب";
            this.Load += new System.EventHandler(this.remove_books_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button back_dashboard_button;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox name_box;
    }
}