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
    public partial class LichSuChuyenDi : FunctionForm
    {
        public LichSuChuyenDi()
        {
            InitializeComponent();
        }
        int idhokhau;
        public void getChu_Ho(int idnhankhau)
        {
            ChuHo chuHo = HoKhauUCCtrl.xemHoKhau_ChuHo(idnhankhau);
            Invoke((MethodInvoker)delegate
            {
                maChuHoLabel.Text = chuHo.maChuHo.ToString();
                tenLabel.Text = chuHo.hoTen;
                idhokhau = chuHo.maHoKhau;
            });
            HoKhauUCCtrl.load_LichSu(dataGridView1, idhokhau);
        }
        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
