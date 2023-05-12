
namespace PhanMemQuanLyCuaHang
{
    partial class FormAddCategory
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
            this.buttonaddCategory = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxaddCategory = new System.Windows.Forms.TextBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonaddCategory
            // 
            this.buttonaddCategory.Location = new System.Drawing.Point(12, 32);
            this.buttonaddCategory.Name = "buttonaddCategory";
            this.buttonaddCategory.Size = new System.Drawing.Size(127, 37);
            this.buttonaddCategory.TabIndex = 0;
            this.buttonaddCategory.Text = "Thêm loại hàng";
            this.buttonaddCategory.UseVisualStyleBackColor = true;
            this.buttonaddCategory.Click += new System.EventHandler(this.buttonaddCategory_Click);
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.Location = new System.Drawing.Point(12, 75);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(127, 37);
            this.buttonEditCategory.TabIndex = 1;
            this.buttonEditCategory.Text = "Sửa";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(12, 128);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(127, 37);
            this.buttonDeleteCategory.TabIndex = 2;
            this.buttonDeleteCategory.Text = "Xóa";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 185);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(127, 37);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxaddCategory
            // 
            this.textBoxaddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxaddCategory.Location = new System.Drawing.Point(167, 33);
            this.textBoxaddCategory.Name = "textBoxaddCategory";
            this.textBoxaddCategory.Size = new System.Drawing.Size(422, 36);
            this.textBoxaddCategory.TabIndex = 4;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 16;
            this.listBoxCategory.Location = new System.Drawing.Point(167, 75);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(422, 308);
            this.listBoxCategory.TabIndex = 5;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBoxCategory_SelectedIndexChanged);
            // 
            // FormAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 388);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.textBoxaddCategory);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonEditCategory);
            this.Controls.Add(this.buttonaddCategory);
            this.Name = "FormAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonaddCategory;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxaddCategory;
        private System.Windows.Forms.ListBox listBoxCategory;
    }
}