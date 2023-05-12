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
    public partial class FormEditValue : Form
    {
        public string value;
        public FormEditValue(string strLabel,string tmpValue)
        {
            InitializeComponent();
            label1.Text = strLabel;
            textBoxEditValue.Text = tmpValue;
            // Ref. https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.form.dialogresult?view=windowsdesktop-7.0
            // Make button1's dialog result OK.
            buttonOk.DialogResult = DialogResult.OK;
            // Make button2's dialog result Cancel.
            buttonCancel.DialogResult = DialogResult.Cancel;

            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the accept button of the form to button1.
            this.AcceptButton = buttonOk;
            // Set the cancel button of the form to button2.
            this.CancelButton = buttonCancel;
            // Set the start position of the form to the center of the screen.
            this.ControlBox = false;
        }

        private void textBoxEditValue_TextChanged(object sender, EventArgs e)
        {
            this.value = this.textBoxEditValue.Text;
        }
    }
}
