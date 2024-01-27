using Nhom5.Controller.trao_thuong;
using Nhom5.View.phanthuong;
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
    public partial class ChiTietDip : FunctionForm
    {
        public ChiTietDip()
        {
            InitializeComponent();
        }
        public void getDipDacBiet(int iddip)
        {
            dip_dac_biet dipDB = DipDacBietUCCtrl.xemDipDacBiet(iddip);
            Invoke((MethodInvoker)delegate
            {
                tenLabel.Text = dipDB.ten;
                namLabel.Text = dipDB.nam.ToString();
                qua1Label.Text = dipDB.phanQua05;
                qua2Label.Text = dipDB.phanQua614;
                qua3Label.Text = dipDB.phanQua1517;
                tien1Label.Text = dipDB.tien05.ToString();
                tien2Label.Text = dipDB.tien614.ToString();
                tien3Label.Text = dipDB.tien1517.ToString();
                moTaLabel.Text = dipDB.moTa;
            });
        }
        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
