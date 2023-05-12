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
    public partial class FormMain : Form
    {
        public bool isExit = true;
        public Product[] arrProducts = new Product[1000];
        public string[] arrCategories = new string[100];
        public void setCategoryToArray(string[] category)
        {
             arrCategories =category;
        }

        private void addProductToArray(Product product)
        {
            for (int i = 0; i < arrProducts.Length; i++)
            {
               if(arrProducts[i].code == null)
               {
                    arrProducts[i] = product;
                    return;
               }
            }
        }

        private void removeProductFromArray(string productCode)
        {
            for (int i = 0; i < arrProducts.Length; i++)
            {
                if (arrProducts[i].code == productCode)
                {
                    arrProducts[i].code = null;
                }
            }
        }

        public void addCategoryToArray(string category)
        {
            for (int i = 0; i < arrCategories.Length; i++)
            {
                if (arrCategories[i]== null)
                {
                    arrCategories[i] = category;
                    return;
                }
            }
        }

        public void removeCategoryFromArray(string category)
        {
            for (int i = 0; i < arrCategories.Length; i++)
            {
                if (arrCategories[i] == category)
                {
                    arrCategories[i] = null;
                }
            }
        }
        public FormMain()
        {
            InitializeComponent();
        }
/*        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }*/
 
        private void CategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddCategory f = new FormAddCategory(arrCategories);
            f.frmMain = this;
            f.ShowDialog();  
        }

        private void updateDatagrid()
        {
            // Xóa toàn bộ data đang có trên lưới
            dataGridView1.Rows.Clear();
            for (int i = 0; i < arrProducts.Length; i++)
            {
                if (arrProducts[i].code != null)
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = arrProducts[i].code;
                    newRow.Cells[1].Value = arrProducts[i].name;
                    newRow.Cells[2].Value = arrProducts[i].expireDate;
                    newRow.Cells[3].Value = arrProducts[i].company;
                    newRow.Cells[4].Value = arrProducts[i].productionYear;
                    newRow.Cells[5].Value = arrProducts[i].category;
                    dataGridView1.Rows.Add(newRow);
                }

            }
        }
        private bool checkExistingProduct(Product product)
        {
            for (int i = 0; i < arrProducts.Length; i++)
            {
                if (arrProducts[i].code == product.code)
                {
                    return true;
                }
            }
            return false;
        }
        public void HandleAddProduct(Product product)
        {
            if (checkExistingProduct(product))
            {
                MessageBox.Show("Mã mặt hàng đã tồn tại.");
            }
            else
            {
                addProductToArray(product);
                updateDatagrid();
            }
          
        }
        public void HandleEditProduct(Product product)
        {
            for (int i = 0; i < arrProducts.Length; i++)
            {
                if (arrProducts[i].code == product.code)
                {
                    arrProducts[i] = product;
                }
            }
             updateDatagrid();

        }
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                    this.removeProductFromArray(item.Cells[0].ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để xóa.");
            }
        }



        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow item = this.dataGridView1.SelectedRows[0];
                Product editProduct = new Product();
                editProduct.code = item.Cells[0].Value.ToString();
                editProduct.name = item.Cells[1].Value.ToString();
                editProduct.expireDate = item.Cells[2].Value.ToString();
                editProduct.company = item.Cells[3].Value.ToString();
                editProduct.productionYear = item.Cells[4].Value.ToString();
                editProduct.category = item.Cells[5].Value.ToString();
                FormEditProduct f = new FormEditProduct(editProduct);
                f.frmMain = this;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mặt hàng để sửa.");
            }
        }

        private void buttonSearchNameProduct_Click(object sender, EventArgs e)
        {
            string name = textBoxNameProductSearch.Text;
            for(int i=0; i<dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.Cells[1].Value.ToString().Contains(name))
                {
                    row.Visible = true;
                }
                else { row.Visible = false;}
            }    
        }

        private void buttonSearchCategory_Click(object sender, EventArgs e)
        {
            string name = textBoxCategorySearch.Text;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.Cells[5].Value.ToString().Contains(name))
                {
                    row.Visible = true;
                }
                else { row.Visible = false; }
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct f = new FormAddProduct(arrCategories);
            f.frmMain = this;
            f.ShowDialog();
        }

        private void buttonaddCategory_Click(object sender, EventArgs e)
        {
            string Cat = textBoxaddCategory.Text;
            if (Cat == "" )
            {
                MessageBox.Show("Vui lòng nhập loại hàng!");
            } else if (arrCategories.Contains(Cat))
            {
                MessageBox.Show("Loại hàng đã tồn tại.");
            }
            else
            {
                this.addCategoryToArray(Cat);
                listBoxCategory.DataSource = null;
                listBoxCategory.DataSource = this.arrCategories;
            }
        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategory.SelectedIndex < 0) return;

            var tmpValue = listBoxCategory.Items[listBoxCategory.SelectedIndex].ToString();
            FormEditValue formEditValue = new FormEditValue("Loại hàng:", tmpValue);
            formEditValue.value = tmpValue;
            formEditValue.ShowDialog();

            //TODO: inside "newRoomDisplayForm" set the value to the textbox
            // ie.: myValueTextBox.Text = this.value;

            if (formEditValue.DialogResult == DialogResult.OK)
            {
                // replace the selected item with the new value
                this.arrCategories[listBoxCategory.SelectedIndex] = formEditValue.value;
                listBoxCategory.DataSource = null;
                listBoxCategory.DataSource = this.arrCategories;
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategory.SelectedIndex < 0) return;
            string Cat = listBoxCategory.SelectedItem.ToString();
            this.removeCategoryFromArray(Cat);
            listBoxCategory.DataSource = null;
            listBoxCategory.DataSource = this.arrCategories.Where(item => item != null).ToArray();
        }
    }
}