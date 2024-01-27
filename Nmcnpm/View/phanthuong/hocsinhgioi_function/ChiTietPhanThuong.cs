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
    public partial class ChiTietPhanThuong : FunctionForm
    {
        public ChiTietPhanThuong()
        {
            InitializeComponent();
        }
        public void getDipHSG(int iddip)
        {
            dip_hoc_sinh_gioi dipHSG = HocSinhGioiUCCtrl.xemDipHSG(iddip);
            Invoke((MethodInvoker)delegate
            {
                namHocLabel.Text = dipHSG.nam.ToString();
                phanQua1Label.Text = dipHSG.phanQuaDacBiet;
                tien1Label.Text = dipHSG.tienDacBiet.ToString();
                phanQua2Label.Text = dipHSG.phanQuaGioi;
                tien2Label.Text = dipHSG.tienGioi.ToString();
                phanQua3Label.Text = dipHSG.phanQuaKha;
                tien3Label.Text = dipHSG.tienKha.ToString();
                moTaLabel.Text = dipHSG.moTa;
            });
        }

        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
