using Nhom5.Controller.hokhau_nhankhau.hokhau;
using Nhom5.Utility;
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
    public partial class ThemMoiHoKhau : FunctionForm
    {
        public ThemMoiHoKhau()
        {
            InitializeComponent();
            
        }
        
        private void ThemMoiHoKhau_Load(object sender, EventArgs e)
        {
            HoKhauUCCtrl.themMoi_load(dataGridView1);
            DataTable table = new DataTable();
            table.Columns.Add("Mã nhân khẩu", typeof(int));
            table.Columns.Add("Họ tên", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(DateTime));
            table.Columns.Add("Quan hệ với chủ hộ", typeof(string));
            //table.Rows.RemoveAt(0);
            dataGridView2.DataSource = table;
            dataGridView2.AllowUserToAddRows = false;
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

        private void switchLeftBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
                return;
            int selectedRow = dataGridView2.SelectedCells[0].RowIndex;
            DataTable dt = (DataTable)dataGridView2.DataSource;
            
            dt.Rows.RemoveAt(selectedRow);
            dt.AcceptChanges();
            if (dt.Rows.Count > 0)
                dt.Rows[0]["Quan hệ với chủ hộ"] = "Chủ hộ";
            dataGridView2.Refresh();
            HoKhauUCCtrl.themMoi_removeDT1(dataGridView1,
                dataGridView2);
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if(diaChiTextBox.Text.Trim() == "" || tinhTextBox.Text.Trim() == ""
                || quanTextBox.Text.Trim() == "" || phuongTextBox.Text.Trim() == ""
                || dataGridView2.Rows.Count==0)
            {
                MessageBox.Show("Điền đầy đủ các thông tin cần thiết");
                return;
            }
            DataTable dt = (DataTable)dataGridView2.DataSource;
            int idhokhau = 0;
            for (int i = 0; i<dt.Rows.Count; i++)
            {
                int idnhankhau = Int32.Parse(dt.Rows[i]["Mã nhân khẩu"].ToString());
                string quanhe = dt.Rows[i]["Quan hệ với chủ hộ"].ToString();
                string trangthai = "thường trú";
                if(i==0)
                {
                    idhokhau=HoKhauUCCtrl.themMoi_themChuHo(
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            HoKhauUCCtrl.traCuuHoKhau2(dataGridView1, featureSearchBox.SelectedItem.ToString(), 
                searchTextBox1.Text);
        }
    }
}
