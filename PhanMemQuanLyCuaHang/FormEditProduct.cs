using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyCuaHang
{
    public partial class FormEditProduct : Form
    {
        public FormMain frmMain;
        public FormEditProduct(Product product)
        {
            InitializeComponent();
            textBoxCode.Text = product.code;
            textBoxname.Text = product.name;
            textBoxexpireDate.Text = product.expireDate;
            textBoxcompany.Text = product.company;
            textBoxproductionYear.Text = product.productionYear;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.code = textBoxCode.Text;
            product.category = comboBoxCategory.Text;
            product.company = textBoxcompany.Text;
            product.name = textBoxname.Text;
            product.expireDate = textBoxexpireDate.Text;
            product.productionYear = textBoxproductionYear.Text;
            this.frmMain.HandleEditProduct(product);
        }
    }
}
