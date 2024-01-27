using Nhom5.Controller.hokhau_nhankhau.hokhau;
using Nhom5.Utility;
using Nhom5.View.hokhau_nhankhau.hokhau_function;
using Nhom5.View.hokhau_nhankhau.nhankhau_function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.View.hokhau_nhankhau
{
    public partial class HoKhauUC : UserControl
    {
        bool complete = false;
        public HoKhauUC()
        {
            InitializeComponent();
            featureSearchBox.SelectedIndex = 0;
        }
        #region change sPanel color
        public void HoKhauUC_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() { "Button" });
            AutoChangeColor.changeSPanelScreen2(sender, searchSPanel);
            AutoChangeColor.changeSPanelScreen2(sender, reLoadSPanel);
        }
        private void themMoiBtn_EnabledChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeSPanelScreen2(this, searchSPanel);
            AutoChangeColor.changeSPanelScreen2(this, reLoadSPanel);
        }
        #endregion
        #region SPanel click
        private void searchSPanel_Click(object sender, EventArgs e)
        {
            if (!complete)
                return;
            HoKhauUCCtrl.traCuuHoKhau(dataGridView1,
                featureSearchBox.SelectedItem.ToString(), searchTextBox1.Text);
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            SPanel sPanel = pic.Parent as SPanel;
            searchSPanel_Click(sPanel, e);
        }
        private void reLoadSPanel_Click(object sender, EventArgs e)
        {
            if (!complete)
                return;
            HoKhauUCCtrl.loadHoKhau(dataGridView1);
        }
        private void reLoadPic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            SPanel sPanel = pic.Parent as SPanel;
            reLoadSPanel_Click(sPanel, e);
        }

        #endregion
        private void HoKhauUC_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void themMoiBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openFunctionForm(this, new ThemMoiHoKhau(), 1);
        }

        private void xemChiTietBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;

            int idhokhau = 0;
            int idnhankhau = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            }
            else
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString());
                //Console.WriteLine(id);
            }
            XemHoKhau xemHoKhau = new XemHoKhau();
            OpenScreen.openFunctionForm(this, xemHoKhau, 1);
            xemHoKhau.getChu_Ho(idnhankhau);
            xemHoKhau.getThanh_Vien(idhokhau);
        }

        private void chinhSuaBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int idhokhau = 0;
            int idnhankhau = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            }
            else
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString());
                //Console.WriteLine(id);
            }
            ChinhSuaHoKhau chinhSuaHoKhau = new ChinhSuaHoKhau();
            OpenScreen.openFunctionForm(this, chinhSuaHoKhau, 1);
            chinhSuaHoKhau.getChu_Ho(idnhankhau);
            chinhSuaHoKhau.getThanh_Vien(idhokhau);
        }

        private void tachHoKhauBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int idhokhau = 0;
            int idnhankhau = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            }
            else
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString());
                //Console.WriteLine(id);
            }
            TachHoKhau tachHoKhau = new TachHoKhau();
            OpenScreen.openFunctionForm(this, tachHoKhau, 1);
            tachHoKhau.getChu_Ho(idnhankhau);
            tachHoKhau.getThanh_Vien(idhokhau);
        }
        
        private void chuyenKhauBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int idhokhau = 0;
            int idnhankhau = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            }
            else
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString());
                //Console.WriteLine(id);
            }
            ChuyenHoKhau chuyenHoKhau = new ChuyenHoKhau();
            OpenScreen.openFunctionForm(this, chuyenHoKhau, 1);
            chuyenHoKhau.getChu_Ho(idnhankhau);

        }

        private void lichSuBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int idhokhau = 0;
            int idnhankhau = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            }
            else
            {
                idhokhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                idnhankhau = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString());
                //Console.WriteLine(id);
            }
            LichSuChuyenDi lichsuHoKhau = new LichSuChuyenDi();
            OpenScreen.openFunctionForm(this, lichsuHoKhau, 1);
            lichsuHoKhau.getChu_Ho(idnhankhau);
        }

        private void HoKhauUC_Load(object sender, EventArgs e)
        {
            HoKhauUCCtrl.loadHoKhau(dataGridView1);
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
