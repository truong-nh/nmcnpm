using Nhom5.Controller.traothuong;
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
    public partial class DanhSachHSG : FunctionForm
    {
        public DanhSachHSG()
        {
            InitializeComponent();
            featureSearchBox.SelectedIndex = 0;
        }
        bool complete = false;
        private void dongBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int iddip;
        public void getDipHSG(int iddip)
        {
            this.iddip = iddip;
            dip_hoc_sinh_gioi dipHSG = HocSinhGioiUCCtrl.xemDipHSG(iddip);
            Invoke((MethodInvoker)delegate
            {
                namHocLabel.Text = dipHSG.nam.ToString();
            });
            HocSinhGioiUCCtrl.load_HSGTrongDip(dataGridView1, iddip);
            HocSinhGioiUCCtrl.load_HSGChuaDK(dataGridView2, iddip);
        }
        private void themMinhChungBtn_Click(object sender, EventArgs e)
        {
            if (!complete)
                return;
            int idnk = 0;
            if (dataGridView2.SelectedRows.Count > 0)
            {
                idnk = Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            }
            else
            {
                idnk = Int32.Parse(dataGridView2.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            }
            #region open form
            MinhChungHSG minhChung = new MinhChungHSG();
            minhChung.getForm_ColorRef(this, this.themMinhChungBtn.BackColor);
            void runSecondScreen()
            {
                Application.Run(minhChung);
            }
            Thread th = new Thread(runSecondScreen);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            #endregion
            minhChung.getHSG(idnk, iddip, Int32.Parse(namHocLabel.Text));
            this.Enabled = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            HocSinhGioiUCCtrl.traCuu_HSGTrongDip(dataGridView1, featureSearchBox.Text, searchTextBox1.Text, iddip);
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            HocSinhGioiUCCtrl.load_HSGTrongDip(dataGridView1, iddip);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            complete = false;
            if (e.ListChangedType == ListChangedType.Reset)
            {
                complete = true;
            }
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            complete = false;
            if (e.ListChangedType == ListChangedType.Reset)
            {
                complete = true;
            }
        }

        private void searchBtn2_Click(object sender, EventArgs e)
        {
            HocSinhGioiUCCtrl.traCuu_HSGChuaDK(dataGridView2, featureSearchBox2.Text, searchTextBox2.Text, iddip);
        }

        private void reloadBtn2_Click(object sender, EventArgs e)
        {
            HocSinhGioiUCCtrl.load_HSGChuaDK(dataGridView2, iddip);
        }
    }
}
