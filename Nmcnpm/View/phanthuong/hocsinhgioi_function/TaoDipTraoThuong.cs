using Nhom5.Controller.traothuong;
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
    public partial class TaoDipTraoThuong : FunctionForm
    {
        public TaoDipTraoThuong()
        {
            InitializeComponent();
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            int res = 0;
            if (!Int32.TryParse(namHocTextBox.Text.Trim(), out res) 
                || phanQua1TextBox.Text.Trim() == ""
                || !Int32.TryParse(tien1TextBox.Text.Trim(), out res)
                || phanQua2TextBox.Text.Trim() == ""
                || !Int32.TryParse(tien1TextBox.Text.Trim(), out res)
                || phanQua3TextBox.Text.Trim() == ""
                || !Int32.TryParse(tien1TextBox.Text.Trim(), out res))
            {
                MessageBox.Show("Hãy điền đầy đủ chính xác thông tin");
                return;
            }
            HocSinhGioiUCCtrl.taoDipHSG(
                Int32.Parse(namHocTextBox.Text.Trim()),
                phanQua1TextBox.Text.Trim(),
                Int32.Parse(tien1TextBox.Text.Trim()),
                phanQua2TextBox.Text.Trim(),
                Int32.Parse(tien2TextBox.Text.Trim()),
                phanQua3TextBox.Text.Trim(),
                Int32.Parse(tien3TextBox.Text.Trim()),
                moTaTextBox.Text
                );
            this.Close();
        }
    }
}
