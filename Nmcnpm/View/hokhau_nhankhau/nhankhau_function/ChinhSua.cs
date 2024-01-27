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
    public partial class ChinhSua : FunctionForm
    {
        public ChinhSua()
        {
            
            InitializeComponent();
            
        }
        int ID = 0;
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
            var nghenghiep = ngheNghiepTextbox.Text.Trim();
            var noilamviec = noiLamViecTextBox.Text.Trim();
            var cmnd = cmndTextBox.Text.Trim();
            var ngaycap = ngayCapDateTime.Value;
            var chuyendenngay = chuyenDenDateTime.Value;
            var noithuongtrutruoc = noiTruocKhiChuyenDenTextBox.Text.Trim();
            var trangthai = trangThaiTextBox.Text.Trim();
            if(trangthai.ToLower() == "Tạm vắng".ToLower())
            {
                MessageBox.Show("Hãy đăng kí tạm vắng cho nhân khẩu");
                return;
            }    
            else if (trangthai.ToLower() == "Tạm trú".ToLower())
            {
                MessageBox.Show("Hãy đăng kí tạm trú cho nhân khẩu");
                return;
            }
            else if(trangthai.ToLower() == "Đã chuyển đi".ToLower())
            {
                MessageBox.Show("Hãy đăng kí chuyển hộ khẩu nhân khẩu");
                return;
            }
            else if (trangThaiTextBox.Text.ToLower() == "Đã qua đời".ToLower())
            {
                MessageBox.Show("Hãy đăng kí khai tử cho nhân khẩu");
                return;
            }    
                bool ok = NhanKhauUCCtrl.chinhSuaNhanKhau(
                ID,
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
            if(ok)
                this.Close();
            else
                MessageBox.Show("Chưa điền hết các thông tin phù hợp");
        }
        public async void getNhan_Khau(int id)
        {
            ID = id;
            var NK = await Task.Run(() => NhanKhauUCCtrl.xemNhanKhau(id));
            Invoke((MethodInvoker)delegate
            {
                tenTextBox.Text = NK.hoTen;
                biDanhTextBox.Text = NK.biDanh;
                quocTichTextBox.Text = NK.quocTich;
                ngheNghiepTextbox.Text = NK.ngheNghiep;
                ngaySinhDateTime.Value = NK.ngaySinh;
                noiLamViecTextBox.Text = NK.noiLamViec;
                noiSinhTextBox.Text = NK.noiSinh;
                cmndTextBox.Text = NK.cmnd;
                gioiTinhComboBox.SelectedIndex = NK.gioiTinh.ToLower() == "nam" ? 0 : 1;
                ngayCapDateTime.Value = (DateTime)(NK.ngayCap == null ? DateTime.Now:NK.ngayCap);
                nguyenQuanTextBox.Text = NK.nguyenQuan.ToString();
                danTocTextBox.Text = NK.danToc;
                tonGiaoTextBox.Text = NK.tonGiao;
                trangThaiTextBox.Text = NK.trangThai;
                if (trangThaiTextBox.Text.ToLower() == "Đã qua đời".ToLower())
                {
                    trangThaiTextBox.Enabled = false;
                }
            });
        }

        private void ChinhSua_Load(object sender, EventArgs e)
        {
        }
    }
}
