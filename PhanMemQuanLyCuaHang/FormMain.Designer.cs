
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mã = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comlum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchgroupBox = new System.Windows.Forms.GroupBox();
            this.buttonSearchCategory = new System.Windows.Forms.Button();
            this.buttonSearchNameProduct = new System.Windows.Forms.Button();
            this.textBoxCategorySearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameProductSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SearchgroupBox.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuStripItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // AddMenuStripItem
            // 
            this.AddMenuStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryToolStripMenuItem,
            this.ProductToolStripMenuItem1});
            resources.ApplyResources(this.AddMenuStripItem, "AddMenuStripItem");
            this.AddMenuStripItem.Name = "AddMenuStripItem";
            // 
            // CategoryToolStripMenuItem
            // 
            this.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem";
            resources.ApplyResources(this.CategoryToolStripMenuItem, "CategoryToolStripMenuItem");
            this.CategoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem1_Click);
            // 
            // ProductToolStripMenuItem1
            // 
            this.ProductToolStripMenuItem1.Name = "ProductToolStripMenuItem1";
            resources.ApplyResources(this.ProductToolStripMenuItem1, "ProductToolStripMenuItem1");
            this.ProductToolStripMenuItem1.Click += new System.EventHandler(this.ProductToolStripMenuItem1_Click);
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
            this.SearchgroupBox.Enter += new System.EventHandler(this.SearchgroupBox_Enter);
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
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.SearchgroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SearchgroupBox.ResumeLayout(false);
            this.SearchgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mã;
        private System.Windows.Forms.DataGridViewTextBoxColumn comlum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddMenuStripItem;
        private System.Windows.Forms.GroupBox SearchgroupBox;
        private System.Windows.Forms.TextBox textBoxCategorySearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameProductSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchNameProduct;
        private System.Windows.Forms.Button buttonSearchCategory;
        private System.Windows.Forms.ToolStripMenuItem CategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
    }
}

