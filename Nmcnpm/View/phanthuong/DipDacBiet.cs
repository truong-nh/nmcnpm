using Nhom5.Controller.trao_thuong;
using Nhom5.Utility;
using Nhom5.View.hokhau_nhankhau.nhankhau_function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.phanthuong
{
    public partial class DipDacBiet : UserControl
    {
        public DipDacBiet()
        {
            InitializeComponent();
        }
        bool complete = false;
        int iddip;
        public void DipDacBiet_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() { "Button" });
            AutoChangeColor.changeSPanelScreen2(sender, searchSPanel);
            AutoChangeColor.changeSPanelScreen2(sender, reLoadSPanel);
        }
        private void taoDipBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new TaoDipDacBiet(), 1);
        }

        private void xemChiTietBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                iddip = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                iddip = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            }

            ChiTietDip xemChiTiet = new ChiTietDip();
            OpenScreen.openFunctionForm(this, xemChiTiet, 1);
            xemChiTiet.getDipDacBiet(iddip);
        }

        private void chinhSuaBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                iddip = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                iddip = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            }

            ChinhSuaDip chinhSua = new ChinhSuaDip();
            OpenScreen.openFunctionForm(this, chinhSua, 1);
            chinhSua.getDipDacBiet(iddip);
        }

        private void xemDanhSachBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                iddip = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                iddip = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            }
            DanhSachDip danhSach = new DanhSachDip();
            OpenScreen.openFunctionForm(this, danhSach, 1);
            danhSach.getDipDacBiet(iddip);
        }

        private void DipDacBiet_Load(object sender, EventArgs e)
        {
            DipDacBietUCCtrl.load_Dip(dataGridView1);
        }

        private void reLoadPic_Click(object sender, EventArgs e)
        {
            reLoadSPanel_Click(sender, e);
        }

        private void reLoadSPanel_Click(object sender, EventArgs e)
        {
            DipDacBietUCCtrl.load_Dip(dataGridView1);
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            searchSPanel_Click(sender, e);
        }

        private void searchSPanel_Click(object sender, EventArgs e)
        {
            DipDacBietUCCtrl.traCuuDipDacBiet(dataGridView1, featureSearchBox.SelectedItem.ToString(), searchTextBox1.Text);
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
