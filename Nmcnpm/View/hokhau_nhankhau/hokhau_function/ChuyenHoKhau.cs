using Nhom5.Controller.hokhau_nhankhau.hokhau;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.hokhau_nhankhau.hokhau_function
{
    public partial class ChuyenHoKhau : FunctionForm
    {
        public ChuyenHoKhau()
        {
            InitializeComponent();
        }

        private void ChuyenHoKhau_Load(object sender, EventArgs e)
        {

        }

        public void getChu_Ho(int idnhankhau)
        {
            ChuHo chuHo = HoKhauUCCtrl.xemHoKhau_ChuHo(idnhankhau);
            Invoke((MethodInvoker)delegate
            {
                maHoKhauLabel.Text = chuHo.maHoKhau.ToString();
                tenChuHoLabel.Text = chuHo.hoTen;
                diaChiHienTaiLabel.Text = chuHo.hoTen;
            });
        }
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if(diaChiChuyenDenTextBox.Text.Trim()==""
                || tinhTextBox.Text.Trim() == ""
                || quanTextBox.Text.Trim() == ""
                || phuongTextBox.Text.Trim()== "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
                return;
            }
            HoKhauUCCtrl.chuyenHoKhau(
                Int32.Parse(maHoKhauLabel.Text),
                diaChiChuyenDenTextBox.Text.Trim(),
                 tinhTextBox.Text.Trim(),
                 phuongTextBox.Text.Trim(),
                 quanTextBox.Text.Trim(),
                 ngayDateTime.Value,
                 ghiChuTextBox.Text.Trim()
                );
            this.Close();
        }
        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
