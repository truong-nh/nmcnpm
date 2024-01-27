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
    public partial class TachHoKhau : FunctionForm
    {
        public TachHoKhau()
        {
            InitializeComponent();
            
        }
        Dictionary<string, string> idnk_qh = new Dictionary<string, string>();

        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        private void TachHoKhau_Load(object sender, EventArgs e)
        {
            table1.Columns.Add("Mã nhân khẩu", typeof(int));
            table1.Columns.Add("Họ tên", typeof(string));
            table1.Columns.Add("Ngày sinh", typeof(DateTime));
            table1.Columns.Add("Quan hệ với chủ hộ", typeof(string));
            table2.Columns.Add("Mã nhân khẩu", typeof(int));
            table2.Columns.Add("Họ tên", typeof(string));
            table2.Columns.Add("Ngày sinh", typeof(DateTime));
            table2.Columns.Add("Quan hệ với chủ hộ", typeof(string));
            //table.Rows.RemoveAt(0);
            dataGridView1.DataSource = table1;
            dataGridView2.DataSource = table2; 
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        public void getChu_Ho(int idchuho)
        {
            ChuHo chuHo = HoKhauUCCtrl.xemHoKhau_ChuHo(idchuho);
            Invoke((MethodInvoker)delegate
            {
                maChuHoLabel.Text = chuHo.maChuHo.ToString();
                maHoKhauLabel.Text = chuHo.maHoKhau.ToString();
                tenChuHoLabel.Text = chuHo.hoTen;
            });

        }

        public void getThanh_Vien(int idhokhau)
        {
            HoKhauUCCtrl.chinhSuaHoKhau_CopyThanhVienToTable(table1, Int32.Parse(maHoKhauLabel.Text));
            foreach (DataRow row in table1.Rows)
            {
                idnk_qh[row["Mã nhân khẩu"].ToString()] = row["Quan hệ với chủ hộ"].ToString();
            }
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if (diaChiTextBox.Text.Trim() == "" || tinhTextBox.Text.Trim() == ""
                || phuongTextBox.Text.Trim() == "" || quanTextBox.Text.Trim() ==""
                || dataGridView2.Rows.Count==0)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
                return;
            }
            HoKhauUCCtrl.tach_XoaHoKhau(table2);
            DataTable dt = (DataTable)dataGridView2.DataSource;
            int idhokhau = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int idnhankhau = Int32.Parse(dt.Rows[i]["Mã nhân khẩu"].ToString());
                string quanhe = dt.Rows[i]["Quan hệ với chủ hộ"].ToString();
                string trangthai = "thường trú";
                if (i == 0)
                {
                    idhokhau = HoKhauUCCtrl.themMoi_themChuHo(
                        idnhankhau,
                        tinhTextBox.Text.Trim(),
                        quanTextBox.Text.Trim(),
                        phuongTextBox.Text.Trim(),
                        diaChiTextBox.Text.Trim(),
                        ngayDateTime.Value,
                        trangthai);
                    //Console.WriteLine(idhokhau);
                }
                else
                {
                    HoKhauUCCtrl.themMoi_themThanhVien(idhokhau, idnhankhau, quanhe);
                }
            }
            this.Close();
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switchRightBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            DataGridViewRow selectedRow = dataGridView1.SelectedCells[0].OwningRow;
            DataRow dr = table2.NewRow();
            dr["Mã nhân khẩu"] = selectedRow.Cells[0].Value;
            dr["Họ tên"] = selectedRow.Cells[1].Value;
            dr["Ngày sinh"] = selectedRow.Cells[2].Value;
            dr["Quan hệ với chủ hộ"] = quanHeTextBox.Text.Trim();
            if (table2.Rows.Count == 0)
            {
                dr["Quan hệ với chủ hộ"] = "Chủ hộ";
            }
            else
                if (quanHeTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền quan hệ với chủ hộ");
                return;
            }
            table2.Rows.Add(dr);
            var rowsToDelete = table1.AsEnumerable().AsQueryable()
                      .Where(p => p.Field<int>("Mã nhân khẩu") ==Int32.Parse(dr["Mã nhân khẩu"].ToString()))
                      .ToList();
            foreach (DataRow row in rowsToDelete)
            {
                row.Delete();
            }
            table1.AcceptChanges();
        }

        private void switchLeftBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
                return;
            DataGridViewRow selectedRow = dataGridView2.SelectedCells[0].OwningRow;
            DataRow dr = table1.NewRow();
            dr["Mã nhân khẩu"] = selectedRow.Cells[0].Value;
            dr["Họ tên"] = selectedRow.Cells[1].Value;
            dr["Ngày sinh"] = selectedRow.Cells[2].Value;
            dr["Quan hệ với chủ hộ"] = idnk_qh[dr["Mã nhân khẩu"].ToString()];
            
            table1.Rows.Add(dr);
            var rowsToDelete = table2.AsEnumerable().AsQueryable()
                      .Where(p => p.Field<int>("Mã nhân khẩu") == Int32.Parse(dr["Mã nhân khẩu"].ToString()))
                      .ToList();
            foreach (DataRow row in rowsToDelete)
            {
                row.Delete();
            }
            table2.AcceptChanges();
        }
    }
}
