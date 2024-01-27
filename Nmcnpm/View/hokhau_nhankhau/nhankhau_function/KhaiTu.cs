using Nhom5.Controller.hokhau_nhankhau.nhankhau;
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
    public partial class KhaiTu : FunctionForm
    {
        public KhaiTu()
        {
            InitializeComponent();
        }
        int ID = 0;
        int ID_NguoiKhai = 0;
        private bool complete = false;
        public async void getNhan_Khau(int id)
        {
            ID = id;
            var NK = await Task.Run(() => NhanKhauUCCtrl.xemNhanKhau(id));   
            Invoke((MethodInvoker)delegate
            {
                tenNguoiMatLabel.Text = NK.hoTen;
                ngaySinhNguoiMatLabel.Text = NK.ngaySinh.ToString("dd/mm/yyyy");
            });
            
            NhanKhauUCCtrl.loadNguoiKhaiBao(dataGridView1, ID);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_NguoiKhai = Int32.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            tenNguoiKhaiBaoLabel.Text = dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString();
            ngaySinhNguoiKhaiBaoLabel.Text = dataGridView1.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            cmndLabel.Text = dataGridView1.SelectedCells[0].OwningRow.Cells[4].Value.ToString();
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if (!complete)
                return;
            bool ok = NhanKhauUCCtrl.khaiTu_ThemBangKhaiTu(
                ID,
                ID_NguoiKhai,
                ngayKhaiBaoDateTime.Value,
                ngayMatDateTime.Value,
                lyDoTextBox.Text
                );
            if(!ok)
            {
                MessageBox.Show("Điền đầy đủ thông tin cần thiết");
                return;
            }    
            else
            {
                NhanKhauUCCtrl.khaiTu_XoaBangLienQuan(ID);
                this.Close();
            }    
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            complete = false;
            if (e.ListChangedType == ListChangedType.Reset)
            {
                complete = true;
            }
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
