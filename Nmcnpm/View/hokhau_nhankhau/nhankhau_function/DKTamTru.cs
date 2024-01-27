using Nhom5.Controller.hokhau_nhankhau.nhankhau;
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

namespace Nhom5.View.hokhau_nhankhau.nhankhau_function
{
    public partial class DKTamTru : FunctionForm
    {
        public DKTamTru()
        {
            InitializeComponent();
        }
        int ID=0;
        public async void getNhan_Khau(int id)
        {
            ID = id;
            var NK = await Task.Run(() => Controller.hokhau_nhankhau.nhankhau.NhanKhauUCCtrl.xemNhanKhau(id));
            Invoke((MethodInvoker)delegate
            {
                tenLabel.Text = NK.hoTen;
                ngaySinhLabel.Text = NK.ngaySinh.ToString("dd/MM/yyyy");
            });
        }
        private void huyBtn_Click(object sender, EventArgs e)
        {
            HandleTextBox.xoaTextBox(this);
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            bool ok = NhanKhauUCCtrl.dangKiTamTru(
                ID,
                noiOTruocKiaTextBox.Text,
                noiTamTruTextBox.Text,
                fromDateTime.Value,
                toDateTime.Value,
                lyDoTextBox.Text
                );
            if (ok)
                this.Close();
            else
                MessageBox.Show("Chưa điền hết các thông tin phù hợp");
        }
    }
}
