
namespace OS_Lab_4001
{
    partial class Category_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Add));
            this.backToCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddCategoryLBl = new System.Windows.Forms.TextBox();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToCategory
            // 
            this.backToCategory.Location = new System.Drawing.Point(11, 11);
            this.backToCategory.Margin = new System.Windows.Forms.Padding(2);
            this.backToCategory.Name = "backToCategory";
            this.backToCategory.Size = new System.Drawing.Size(120, 28);
            this.backToCategory.TabIndex = 25;
            this.backToCategory.Text = "بازشگت به لیست";
            this.backToCategory.UseVisualStyleBackColor = true;
            this.backToCategory.Click += new System.EventHandler(this.backToCategoryEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "نام دسته بندی کتاب";
            // 
            // AddCategoryLBl
            // 
            this.AddCategoryLBl.Location = new System.Drawing.Point(388, 41);
            this.AddCategoryLBl.Margin = new System.Windows.Forms.Padding(2);
            this.AddCategoryLBl.Name = "AddCategoryLBl";
            this.AddCategoryLBl.Size = new System.Drawing.Size(285, 20);
            this.AddCategoryLBl.TabIndex = 27;
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.addCategoryBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.addCategoryBtn.Location = new System.Drawing.Point(410, 85);
            this.addCategoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(90, 39);
            this.addCategoryBtn.TabIndex = 26;
            this.addCategoryBtn.Text = "ثبت دسته بندی جدید";
            this.addCategoryBtn.UseVisualStyleBackColor = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryEvent);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InfoText;
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(556, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddCategoryLBl);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.backToCategory);
            this.Name = "Category_Add";
            this.Text = "Category_Add";
            this.Load += new System.EventHandler(this.Category_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddCategoryLBl;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Button button1;
    }
}