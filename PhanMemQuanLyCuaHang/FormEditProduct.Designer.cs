
namespace PhanMemQuanLyCuaHang
{
    partial class FormEditProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxproductionYear = new System.Windows.Forms.TextBox();
            this.textBoxcompany = new System.Windows.Forms.TextBox();
            this.textBoxexpireDate = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelcategory = new System.Windows.Forms.Label();
            this.labelproductionYear = new System.Windows.Forms.Label();
            this.labelcompany = new System.Windows.Forms.Label();
            this.labelexpireDate = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelcode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxproductionYear);
            this.groupBox1.Controls.Add(this.textBoxcompany);
            this.groupBox1.Controls.Add(this.textBoxexpireDate);
            this.groupBox1.Controls.Add(this.textBoxname);
            this.groupBox1.Controls.Add(this.textBoxCode);
            this.groupBox1.Controls.Add(this.labelcategory);
            this.groupBox1.Controls.Add(this.labelproductionYear);
            this.groupBox1.Controls.Add(this.labelcompany);
            this.groupBox1.Controls.Add(this.labelexpireDate);
            this.groupBox1.Controls.Add(this.labelname);
            this.groupBox1.Controls.Add(this.labelcode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(433, 150);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(212, 24);
            this.comboBoxCategory.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(515, 206);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.Location = new System.Drawing.Point(398, 206);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxproductionYear
            // 
            this.textBoxproductionYear.Location = new System.Drawing.Point(132, 150);
            this.textBoxproductionYear.Name = "textBoxproductionYear";
            this.textBoxproductionYear.Size = new System.Drawing.Size(182, 22);
            this.textBoxproductionYear.TabIndex = 10;
            // 
            // textBoxcompany
            // 
            this.textBoxcompany.Location = new System.Drawing.Point(433, 95);
            this.textBoxcompany.Name = "textBoxcompany";
            this.textBoxcompany.Size = new System.Drawing.Size(212, 22);
            this.textBoxcompany.TabIndex = 9;
            // 
            // textBoxexpireDate
            // 
            this.textBoxexpireDate.Location = new System.Drawing.Point(108, 94);
            this.textBoxexpireDate.Name = "textBoxexpireDate";
            this.textBoxexpireDate.Size = new System.Drawing.Size(206, 22);
            this.textBoxexpireDate.TabIndex = 8;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(433, 52);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(212, 22);
            this.textBoxname.TabIndex = 7;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(102, 47);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(212, 22);
            this.textBoxCode.TabIndex = 6;
            this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxCode_TextChanged);
            // 
            // labelcategory
            // 
            this.labelcategory.AutoSize = true;
            this.labelcategory.Location = new System.Drawing.Point(356, 155);
            this.labelcategory.Name = "labelcategory";
            this.labelcategory.Size = new System.Drawing.Size(71, 17);
            this.labelcategory.TabIndex = 5;
            this.labelcategory.Text = "Loại hàng";
            // 
            // labelproductionYear
            // 
            this.labelproductionYear.AutoSize = true;
            this.labelproductionYear.Location = new System.Drawing.Point(32, 153);
            this.labelproductionYear.Name = "labelproductionYear";
            this.labelproductionYear.Size = new System.Drawing.Size(94, 17);
            this.labelproductionYear.TabIndex = 4;
            this.labelproductionYear.Text = "Năm sản xuất";
            // 
            // labelcompany
            // 
            this.labelcompany.AutoSize = true;
            this.labelcompany.Location = new System.Drawing.Point(314, 97);
            this.labelcompany.Name = "labelcompany";
            this.labelcompany.Size = new System.Drawing.Size(113, 17);
            this.labelcompany.TabIndex = 3;
            this.labelcompany.Text = "Công ty sản xuất";
            // 
            // labelexpireDate
            // 
            this.labelexpireDate.AutoSize = true;
            this.labelexpireDate.Location = new System.Drawing.Point(33, 95);
            this.labelexpireDate.Name = "labelexpireDate";
            this.labelexpireDate.Size = new System.Drawing.Size(70, 17);
            this.labelexpireDate.TabIndex = 2;
            this.labelexpireDate.Text = "Hạn dùng";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(358, 52);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(69, 17);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Tên hàng";
            // 
            // labelcode
            // 
            this.labelcode.AutoSize = true;
            this.labelcode.Location = new System.Drawing.Point(32, 47);
            this.labelcode.Name = "labelcode";
            this.labelcode.Size = new System.Drawing.Size(63, 17);
            this.labelcode.TabIndex = 0;
            this.labelcode.Text = "Mã hàng";
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa mặt hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxproductionYear;
        private System.Windows.Forms.TextBox textBoxcompany;
        private System.Windows.Forms.TextBox textBoxexpireDate;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelcategory;
        private System.Windows.Forms.Label labelproductionYear;
        private System.Windows.Forms.Label labelcompany;
        private System.Windows.Forms.Label labelexpireDate;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelcode;
    }
}