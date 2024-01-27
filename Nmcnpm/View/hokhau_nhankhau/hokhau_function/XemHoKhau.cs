using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom5.Controller.hokhau_nhankhau.hokhau;

namespace Nhom5.View.hokhau_nhankhau.hokhau_function
{
    public partial class XemHoKhau : FunctionForm
    {
        public XemHoKhau()
        {
            InitializeComponent();
        }

        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getChu_Ho(int idchuho)
        {
            ChuHo chuHo = HoKhauUCCtrl.xemHoKhau_ChuHo(idchuho);
            Invoke((MethodInvoker)delegate
            {
                maChuHoLabel.Text = chuHo.maChuHo.ToString();
                maHoKhauLabel.Text = chuHo.maHoKhau.ToString();
                diaChiLabel.Text = chuHo.diaChi;
                tinhLabel.Text = chuHo.tinhThanhPho;
                tenLabel.Text = chuHo.hoTen;
                phuongLabel.Text = chuHo.phuongXa;
                quanLabel.Text = chuHo.quanHuyen;
                trangThaiLabel.Text = chuHo.trangThai;
                ngayLabel.Text = chuHo.ngayTao.ToString();
            });
        }

        public void getThanh_Vien(int idhokhau)
        {
            HoKhauUCCtrl.xemHoKhau_ThanhVien(dataGridView1, idhokhau);
        }


    }
}
