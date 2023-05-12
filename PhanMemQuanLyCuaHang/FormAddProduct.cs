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
    public partial class FormAddProduct : Form
    {
        public FormMain frmMain;
        public FormAddProduct(string[] categories)
        {
            
            InitializeComponent();
            comboBoxCategory.DataSource = categories.Where(item => item != null).ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
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
            this.frmMain.HandleAddProduct(product);
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
