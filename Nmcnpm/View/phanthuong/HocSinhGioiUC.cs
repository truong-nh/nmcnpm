using Nhom5.Controller;
using Nhom5.Controller.traothuong;
using Nhom5.Utility;
using Nhom5.View.hokhau_nhankhau.nhankhau_function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using System.Windows.Forms;

namespace Nhom5.View.phanthuong
{
    public partial class HocSinhGioiUC : UserControl
    {
        public HocSinhGioiUC()
        {
            InitializeComponent();
            featureSearchBox.SelectedIndex = 0;
        }
        bool complete = false;
        public void HocSinhGioiUC_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() { "Button" });
            AutoChangeColor.changeSPanelScreen2(sender, searchSPanel);
            AutoChangeColor.changeSPanelScreen2(sender, reLoadSPanel);
        }

        private void taoDipBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new TaoDipTraoThuong(), 1);
        }

        private void xemChiTietBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int iddip = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                iddip = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                iddip = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            }
            ChiTietPhanThuong xemChiTiet = new ChiTietPhanThuong();
            OpenScreen.openFunctionForm(this, xemChiTiet, 1);
            xemChiTiet.getDipHSG(iddip);
        }

        private void chinhSuaBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int iddip = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                iddip = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                iddip = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                //Console.WriteLine(id);
            }
            ChinhSuaPhanThuong chinhSua = new ChinhSuaPhanThuong();
            OpenScreen.openFunctionForm(this, chinhSua, 1);
            chinhSua.getDipHSG(iddip);
        } 

        private void xemDanhSachBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int iddip = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                iddip = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                iddip = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                //Console.WriteLine(id);
            }
            DanhSachHSG danhSach = new DanhSachHSG();
            OpenScreen.openFunctionForm(this, danhSach, 1);
            danhSach.getDipHSG(iddip);

        }

        private void HocSinhGioiUC_Load(object sender, EventArgs e)
        {
            HocSinhGioiUCCtrl.load_HSG(dataGridView1);
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            searchSPanel_Click(sender, e);
        }

        private void searchSPanel_Click(object sender, EventArgs e)
        {
            HocSinhGioiUCCtrl.traCuuDipHSG(dataGridView1, featureSearchBox.Text, searchTextBox1.Text);
        }

        private void reLoadSPanel_Click(object sender, EventArgs e)
        {
            HocSinhGioiUCCtrl.load_HSG(dataGridView1);
        }

        private void reLoadPic_Click(object sender, EventArgs e)
        {
            reLoadSPanel_Click(sender, e);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            complete = false;
            if (e.ListChangedType == ListChangedType.Reset)
            {
                complete = true;
            }
        }
    }
}
