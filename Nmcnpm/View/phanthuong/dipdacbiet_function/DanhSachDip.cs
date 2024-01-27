using Nhom5.Controller.trao_thuong;
using Nhom5.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.hokhau_nhankhau.nhankhau_function
{
    public partial class DanhSachDip : FunctionForm
    {
        public DanhSachDip()
        {
            InitializeComponent();
        }
        int iddip;
        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getDipDacBiet(int iddip)
        {
            this.iddip = iddip;
            dip_dac_biet dipDB = DipDacBietUCCtrl.xemDipDacBiet(iddip);
            Invoke((MethodInvoker)delegate
            {
                dipLabel.Text = dipDB.ten;
                namLabel.Text = dipDB.nam.ToString();
            });
            DipDacBietUCCtrl.load_DanhSachDip(dataGridView1, iddip);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            DipDacBietUCCtrl.load_DanhSachDip(dataGridView1, iddip);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DipDacBietUCCtrl.traCuuDanhSachDip(dataGridView1, featureSearchBox.SelectedItem.ToString(), searchTextBox1.Text, iddip);
        }
    }
}
