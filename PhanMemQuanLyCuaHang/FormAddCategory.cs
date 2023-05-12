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
    public partial class FormAddCategory : Form
    {
        public FormMain frmMain;
        public string[] categories;
        public FormAddCategory(string[] categories)
        {
            InitializeComponent();
            listBoxCategory.DataSource = categories;
            this.categories = categories;
        }
        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategory.SelectedIndex < 0) return;

            var tmpValue = listBoxCategory.Items[listBoxCategory.SelectedIndex].ToString();
            FormEditValue formEditValue = new FormEditValue("Loại hàng:",tmpValue);
            formEditValue.value = tmpValue;
            formEditValue.ShowDialog();

            //TODO: inside "newRoomDisplayForm" set the value to the textbox
            // ie.: myValueTextBox.Text = this.value;

            if (formEditValue.DialogResult == DialogResult.OK)
            {
                // replace the selected item with the new value
                this.categories[listBoxCategory.SelectedIndex]= formEditValue.value;
                listBoxCategory.DataSource = null;
                listBoxCategory.DataSource = this.categories;
                this.frmMain.setCategoryToArray(this.categories);
            }
        }

        private void buttonaddCategory_Click(object sender, EventArgs e)
        {
            string Cat = textBoxaddCategory.Text;
            this.frmMain.addCategoryToArray(Cat);
            this.categories = this.frmMain.arrCategories;
            listBoxCategory.DataSource = null;
            listBoxCategory.DataSource = this.categories;
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (listBoxCategory.SelectedIndex < 0) return;
            /*            this.categories[listBoxCategory.SelectedIndex] = null;
                        this.frmMain.setCategoryToArray(this.categories);
                        listBoxCategory.DataSource = null;
                        listBoxCategory.DataSource = this.categories.Where(item=> item !=null).ToArray();*/
            string Cat = listBoxCategory.SelectedItem.ToString();
            this.frmMain.removeCategoryFromArray(Cat);
            this.categories = this.frmMain.arrCategories;
            listBoxCategory.DataSource = null;
            listBoxCategory.DataSource = this.categories.Where(item => item != null).ToArray();
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
