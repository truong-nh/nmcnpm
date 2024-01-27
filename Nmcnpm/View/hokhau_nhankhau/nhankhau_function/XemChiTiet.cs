using Nhom5.Controller.hokhau_nhankhau.nhankhau;
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
    public partial class XemChiTiet : FunctionForm
    {
        public XemChiTiet()
        {
            InitializeComponent();
        }
        private void dongBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        public async void getNhan_Khau(int id)
        {
            var NK = await Task.Run(() => NhanKhauUCCtrl.xemNhanKhau(id));
            Invoke((MethodInvoker) delegate
            {
            tenLabel.Text = NK.hoTen;
            biDanhLabel.Text = NK.biDanh;
            quocTichLabel.Text = NK.quocTich;
            ngheNghiepLabel.Text = NK.ngheNghiep;
            ngaySinhLabel.Text = NK.ngaySinh.ToString();
            noiLamViecLabel.Text = NK.noiLamViec;
            noiSinhLabel.Text = NK.noiSinh;
            cmndLabel.Text = NK.cmnd;
            gioiTinhLabel.Text = NK.gioiTinh;
            ngayCapLabel.Text = NK.ngayCap.ToString();
            nguyenQuanLabel.Text = NK.nguyenQuan.ToString();
            danTocLabel.Text = NK.danToc;
            tonGiaoLabel.Text = NK.tonGiao;
            trangThaiLabel.Text = NK.trangThai;
            noiThuongTruTruocLabel.Text = NK.noiThuongTruTruoc;
            });
        }
    }
}
