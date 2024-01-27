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
    public partial class ThemMoiScreen : FunctionForm
    {
        public ThemMoiScreen()
        {
            InitializeComponent();
            gioiTinhComboBox.SelectedIndex = 0;
        }
        
        private void huyBtn_Click(object sender, EventArgs e)
        {
            HandleTextBox.xoaTextBox(this);
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            var hoten = tenTextBox.Text.Trim();
            var bidanh = biDanhTextBox.Text.Trim();
            var ngaysinh = ngaySinhDateTime.Value;
            var noisinh = noiSinhTextBox.Text.Trim();
            var gioitinh = gioiTinhComboBox.SelectedItem.ToString().Trim();
            var nguyenquan = nguyenQuanTextBox.Text.Trim();
            var dantoc = danTocTextBox.Text.Trim();
            var tongiao = tonGiaoTextBox.Text.Trim();
            var quoctich = quocTichTextBox.Text.Trim();
            var nghenghiep = ngheTextBox.Text.Trim();
            var noilamviec = noiLamViecTextBox.Text.Trim();
            var cmnd = cmndTextBox.Text.Trim();
            var ngaycap = ngayCapDateTime.Value;
            var chuyendenngay = chuyenDenDateTime.Value;
            var noithuongtrutruoc = noiThuongTruTruocTextBox.Text.Trim();
            String trangthai = trangThaiTextBox.Text.Trim();
            bool ok = NhanKhauUCCtrl.themNhanKhau(
                hoten,
                bidanh,
                ngaysinh,
                noisinh,
                gioitinh,
                nguyenquan,
                dantoc,
                tongiao,
                quoctich,
                nghenghiep,
                noilamviec,
                cmnd,
                ngaycap,
                chuyendenngay,
                noithuongtrutruoc,
                trangthai
                );
            if (ok)
                this.Close();
            else
                MessageBox.Show("Chưa điền hết các thông tin phù hợp");
        }
    }
}
