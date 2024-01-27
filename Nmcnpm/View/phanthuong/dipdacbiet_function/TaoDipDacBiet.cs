using Nhom5.Controller.trao_thuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.hokhau_nhankhau.nhankhau_function
{
    public partial class TaoDipDacBiet : FunctionForm
    {
        public TaoDipDacBiet()
        {
            InitializeComponent();
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            int res;
            if(dipTextBox.Text.Trim()=="" || !Int32.TryParse(namTextBox.Text, out res) 
                || phanQua1TextBox.Text.Trim()=="" || !Int32.TryParse(tien1TextBox.Text, out res)
                || phanQua2TextBox.Text.Trim() == "" || !Int32.TryParse(tien2TextBox.Text, out res)
                || phanQua3TextBox.Text.Trim() == "" || !Int32.TryParse(tien3TextBox.Text, out res))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
                return;
            }
            DipDacBietUCCtrl.taoDipDacBiet(
                dipTextBox.Text.Trim(),
                Int32.Parse(namTextBox.Text),
                phanQua1TextBox.Text,
                Int32.Parse(tien1TextBox.Text),
                phanQua2TextBox.Text,
                Int32.Parse(tien2TextBox.Text),
                phanQua3TextBox.Text,
                Int32.Parse(tien3TextBox.Text),
                moTaTextBox.Text
                );
            this.Close();
        }
    }
}
