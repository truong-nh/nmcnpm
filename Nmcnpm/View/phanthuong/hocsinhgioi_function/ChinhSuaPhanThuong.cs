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
    public partial class ChinhSuaPhanThuong : FunctionForm
    {
        public ChinhSuaPhanThuong()
        {
            InitializeComponent();
        }
        int iddip;
        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getDipHSG(int iddip)
        {
            this.iddip = iddip;
            dip_hoc_sinh_gioi dipHSG = HocSinhGioiUCCtrl.xemDipHSG(iddip);
            Invoke((MethodInvoker)delegate
            {
                namHocLabel.Text = dipHSG.nam.ToString();
            });
        }
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            int res = 0;
            if (!Int32.TryParse(namHocLabel.Text.Trim(), out res)
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
            HocSinhGioiUCCtrl.chinhSuaHSG(iddip,
                phanQua1TextBox.Text,
                Int32.Parse(tien1TextBox.Text.Trim()),
                phanQua2TextBox.Text,
                Int32.Parse(tien2TextBox.Text.Trim()),
                phanQua3TextBox.Text,
                Int32.Parse(tien3TextBox.Text.Trim()),
                moTaTextBox.Text
                );
            this.Close();
        }
    }
}
