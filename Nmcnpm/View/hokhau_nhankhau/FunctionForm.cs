using Nhom5.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.hokhau_nhankhau
{
    public partial class FunctionForm : Form
    {
        Form parentForm;
        public FunctionForm()
        {
            InitializeComponent();
        }
        private void FunctionForm_Load(object sender, EventArgs e)
        {
            HandleTextBox.HandleTextBox_Load(this);
            ButtonPaint.RoundedBtn_Load(this);
        }

        public Form parent_Form { get => parentForm; set => parentForm = value; }

        public void getFormRef(Form parentForm)
        {
            this.parent_Form = parentForm;
        }

        private void FunctionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent_Form.Invoke((MethodInvoker)(() => this.parent_Form.Enabled = true));
        }

        private void FunctionForm_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorFuncScreen(sender, e, new List<String>() { "Button", "Panel" });
        }

        private void FunctionForm_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }
        
    }
}
