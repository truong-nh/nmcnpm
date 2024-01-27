using Nhom5.Controller;
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

namespace Nhom5.View.hokhau_nhankhau.nhankhau_function
{
    public partial class ChinhSuaHoKhau: FunctionForm
    {
        public ChinhSuaHoKhau()
        {
            InitializeComponent();
        }
        private void ChinhSuaHoKhau_Load(object sender, EventArgs e)
        {
            HoKhauUCCtrl.themMoi_load(dataGridView1);
            DataTable table = new DataTable();
            table.Columns.Add("Mã nhân khẩu", typeof(int));
            table.Columns.Add("Họ tên", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(DateTime));
            table.Columns.Add("Quan hệ với chủ hộ", typeof(string));
            //table.Rows.RemoveAt(0);
            dataGridView2.DataSource = table;
            
        }
        public void getChu_Ho(int idchuho)
        {
            ChuHo chuHo = HoKhauUCCtrl.xemHoKhau_ChuHo(idchuho);
            Invoke((MethodInvoker)delegate
            {
                maChuHoLabel.Text = chuHo.maChuHo.ToString();
                maHoKhauLabel.Text = chuHo.maHoKhau.ToString();
                diaChiLabel.Text = chuHo.diaChi;
                tinhLabel.Text = chuHo.tinhThanhPho;
                tenChuHoLabel.Text = chuHo.hoTen;
                phuongLabel.Text = chuHo.phuongXa;
                quanLabel.Text = chuHo.quanHuyen;
            });
            
        }

        public void getThanh_Vien(int idhokhau)
        {
            DataTable table = (DataTable)dataGridView2.DataSource;
            HoKhauUCCtrl.chinhSuaHoKhau_CopyThanhVienToTable(table, idhokhau);
        }
        
        private void switchRightBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            DataGridViewRow selectedRow = dataGridView1.SelectedCells[0].OwningRow;
            DataTable dt = (DataTable)dataGridView2.DataSource;
            DataRow dr = dt.NewRow();
            dr["Mã nhân khẩu"] = selectedRow.Cells[0].Value;
            dr["Họ tên"] = selectedRow.Cells[1].Value;
            dr["Ngày sinh"] = selectedRow.Cells[2].Value;
            dr["Quan hệ với chủ hộ"] = quanHeTextBox.Text.Trim();
            if (dt.Rows.Count == 0)
            {
                dr["Quan hệ với chủ hộ"] = "Chủ hộ";
            }
            else
                if (quanHeTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền quan hệ với chủ hộ");
                return;
            }
            dt.Rows.Add(dr);
            dataGridView2.Refresh();
            HoKhauUCCtrl.themMoi_removeDT1(dataGridView1,
                dataGridView2);
        }
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if(quanHeTextBox.Text.Trim()=="")
            {
                MessageBox.Show("Điền đầy đủ các thông tin cần thiết");
                return;
            }
            DataTable dt = (DataTable)dataGridView2.DataSource;
            int idhokhau = Int32.Parse(maHoKhauLabel.Text);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int idnhankhau = Int32.Parse(dt.Rows[i]["Mã nhân khẩu"].ToString());
                string quanhe = dt.Rows[i]["Quan hệ với chủ hộ"].ToString();
                HoKhauUCCtrl.chinhSua_themThanhVien(idhokhau, idnhankhau, quanhe);
            }
            this.Close();
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
