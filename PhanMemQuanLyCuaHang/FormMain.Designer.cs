
namespace PhanMemQuanLyCuaHang
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mã = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comlum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchgroupBox = new System.Windows.Forms.GroupBox();
            this.buttonSearchCategory = new System.Windows.Forms.Button();
            this.buttonSearchNameProduct = new System.Windows.Forms.Button();
            this.textBoxCategorySearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameProductSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.textBoxaddCategory = new System.Windows.Forms.TextBox();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonaddCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SearchgroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mã,
            this.comlum2,
            this.column3,
            this.Column4,
            this.Column5,
            this.Column6});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // Mã
            // 
            resources.ApplyResources(this.Mã, "Mã");
            this.Mã.Name = "Mã";
            this.Mã.ReadOnly = true;
            // 
            // comlum2
            // 
            resources.ApplyResources(this.comlum2, "comlum2");
            this.comlum2.Name = "comlum2";
            this.comlum2.ReadOnly = true;
            // 
            // column3
            // 
            resources.ApplyResources(this.column3, "column3");
            this.column3.Name = "column3";
            this.column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // SearchgroupBox
            // 
            this.SearchgroupBox.Controls.Add(this.buttonSearchCategory);
            this.SearchgroupBox.Controls.Add(this.buttonSearchNameProduct);
            this.SearchgroupBox.Controls.Add(this.textBoxCategorySearch);
            this.SearchgroupBox.Controls.Add(this.label4);
            this.SearchgroupBox.Controls.Add(this.label3);
            this.SearchgroupBox.Controls.Add(this.textBoxNameProductSearch);
            this.SearchgroupBox.Controls.Add(this.label1);
            resources.ApplyResources(this.SearchgroupBox, "SearchgroupBox");
            this.SearchgroupBox.Name = "SearchgroupBox";
            this.SearchgroupBox.TabStop = false;
            // 
            // buttonSearchCategory
            // 
            resources.ApplyResources(this.buttonSearchCategory, "buttonSearchCategory");
            this.buttonSearchCategory.Name = "buttonSearchCategory";
            this.buttonSearchCategory.UseVisualStyleBackColor = true;
            this.buttonSearchCategory.Click += new System.EventHandler(this.buttonSearchCategory_Click);
            // 
            // buttonSearchNameProduct
            // 
            resources.ApplyResources(this.buttonSearchNameProduct, "buttonSearchNameProduct");
            this.buttonSearchNameProduct.Name = "buttonSearchNameProduct";
            this.buttonSearchNameProduct.UseVisualStyleBackColor = true;
            this.buttonSearchNameProduct.Click += new System.EventHandler(this.buttonSearchNameProduct_Click);
            // 
            // textBoxCategorySearch
            // 
            resources.ApplyResources(this.textBoxCategorySearch, "textBoxCategorySearch");
            this.textBoxCategorySearch.Name = "textBoxCategorySearch";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxNameProductSearch
            // 
            resources.ApplyResources(this.textBoxNameProductSearch, "textBoxNameProductSearch");
            this.textBoxNameProductSearch.Name = "textBoxNameProductSearch";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonDeleteProduct
            // 
            resources.ApplyResources(this.buttonDeleteProduct, "buttonDeleteProduct");
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            resources.ApplyResources(this.buttonEditProduct, "buttonEditProduct");
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAddProduct);
            this.tabPage1.Controls.Add(this.SearchgroupBox);
            this.tabPage1.Controls.Add(this.buttonEditProduct);
            this.tabPage1.Controls.Add(this.buttonDeleteProduct);
            this.tabPage1.Controls.Add(this.dataGridView1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            resources.ApplyResources(this.buttonAddProduct, "buttonAddProduct");
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxCategory);
            this.tabPage2.Controls.Add(this.textBoxaddCategory);
            this.tabPage2.Controls.Add(this.buttonDeleteCategory);
            this.tabPage2.Controls.Add(this.buttonEditCategory);
            this.tabPage2.Controls.Add(this.buttonaddCategory);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxCategory, "listBoxCategory");
            this.listBoxCategory.Name = "listBoxCategory";
            // 
            // textBoxaddCategory
            // 
            resources.ApplyResources(this.textBoxaddCategory, "textBoxaddCategory");
            this.textBoxaddCategory.Name = "textBoxaddCategory";
            // 
            // buttonDeleteCategory
            // 
            resources.ApplyResources(this.buttonDeleteCategory, "buttonDeleteCategory");
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonEditCategory
            // 
            resources.ApplyResources(this.buttonEditCategory, "buttonEditCategory");
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.UseVisualStyleBackColor = true;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonaddCategory
            // 
            resources.ApplyResources(this.buttonaddCategory, "buttonaddCategory");
            this.buttonaddCategory.Name = "buttonaddCategory";
            this.buttonaddCategory.UseVisualStyleBackColor = true;
            this.buttonaddCategory.Click += new System.EventHandler(this.buttonaddCategory_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SearchgroupBox.ResumeLayout(false);
            this.SearchgroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mã;
        private System.Windows.Forms.DataGridViewTextBoxColumn comlum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox SearchgroupBox;
        private System.Windows.Forms.TextBox textBoxCategorySearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameProductSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchNameProduct;
        private System.Windows.Forms.Button buttonSearchCategory;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.TextBox textBoxaddCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonaddCategory;
    }
}

