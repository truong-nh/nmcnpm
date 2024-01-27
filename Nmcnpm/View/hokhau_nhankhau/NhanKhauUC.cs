using Nhom5.Controller.hokhau_nhankhau.nhankhau;
using Nhom5.Utility;
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
    public partial class NhanKhauUC : UserControl
    {
        bool complete = false;
        public NhanKhauUC()
        {
            InitializeComponent();
            featureSearchBox.SelectedIndex = 0;
        }
        #region change sPanel Color
        public void NhanKhauUC_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorScreen2(sender, e, new List<String>() {"Button"});
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
            NhanKhauUCCtrl.traCuuNhanKhau(dataGridView1, 
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
            //Console.WriteLine("click");
            NhanKhauUCCtrl.loadNhanKhau(this.dataGridView1);
        }

        private void reLoadPic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            SPanel sPanel = pic.Parent as SPanel;
            reLoadSPanel_Click(sPanel, e);

        }
        #endregion
        private void themMoiBtn_Click(object sender, EventArgs e)
        {
            if (!complete)
                return;
            ThemMoiScreen themMoiScreen = new ThemMoiScreen();
            OpenScreen.openFunctionForm(this, themMoiScreen, 1);
        }

        private void xemChiTietBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int id = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                id = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                //Console.WriteLine(id);
            }
            XemChiTiet xemChiTietScreen = new XemChiTiet();
            OpenScreen.openFunctionForm(this, xemChiTietScreen, 1);
            xemChiTietScreen.getNhan_Khau(id);
        }

        private void NhanKhauUC_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null; 
        }

        private void chinhSuaBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            ChinhSua chinhSuaScreen = new ChinhSua();
            OpenScreen.openFunctionForm(this, chinhSuaScreen, 1);
            int id = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                id = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            }
            chinhSuaScreen.getNhan_Khau(id);
        }

        private void dKTamVangBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int id = 0;
            string trangthai = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (dataGridView1.SelectedRows[0].Cells[5].Value != null)
                    trangthai = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            else
            {
                id = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                if (dataGridView1.SelectedCells[0].OwningRow.Cells[5].Value != null)
                    trangthai = dataGridView1.SelectedCells[0].OwningRow.Cells[5].Value.ToString();
            }
            if (trangthai == "Đã qua đời")
            {
                MessageBox.Show("Nhân khẩu đã qua đời");
                return;
            }
            DKTamVang tamVangScreen = new DKTamVang();
            OpenScreen.openFunctionForm(this, tamVangScreen, 1);
            
            tamVangScreen.getNhan_Khau(id);
        }

        private void dKTamTruBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;

            int id = 0;
            string trangthai = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if (dataGridView1.SelectedRows[0].Cells[5].Value != null)
                    trangthai = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            else
            {
                id = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                if (dataGridView1.SelectedCells[0].OwningRow.Cells[5].Value != null)
                    trangthai = dataGridView1.SelectedCells[0].OwningRow.Cells[5].Value.ToString();
            }
            if (trangthai == "Đã qua đời")
            {
                MessageBox.Show("Nhân khẩu đã qua đời");
                return;
            }
            DKTamTru dKTamTru = new DKTamTru();
            OpenScreen.openFunctionForm(this, dKTamTru, 1);
            dKTamTru.getNhan_Khau(id);
        }

        private void khaiTuBtn_Click(object sender, EventArgs e)
        {
            if (!complete || dataGridView1.Rows.Count == 0)
                return;
            int id = 0;
            string trangthai = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                if(dataGridView1.SelectedRows[0].Cells[5].Value!=null)
                trangthai = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            else
            {
                id = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                if (dataGridView1.SelectedCells[0].OwningRow.Cells[5].Value != null)
                    trangthai = dataGridView1.SelectedCells[0].OwningRow.Cells[5].Value.ToString();
            }
            if(trangthai.ToLower()=="Đã qua đời".ToLower())
            {
                MessageBox.Show("Nhân khẩu đã được khai tử");
                return;
            }    
            KhaiTu khaiTu = new KhaiTu(); 
            OpenScreen.openFunctionForm(this, khaiTu, 1);
            khaiTu.getNhan_Khau(id);
           
        }

        private void NhanKhauUC_Load(object sender, EventArgs e)
        {
            NhanKhauUCCtrl.loadNhanKhau(this.dataGridView1);
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
