using Nhom5.Controller.traothuong;
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
    public partial class MinhChungHSG : Form
    {
        public MinhChungHSG()
        {
            InitializeComponent();
        }
        Form parent_Form;
        Color color;
        int idnk;
        int iddip;
        int namhoc;
        Image image = null;
        public void getForm_ColorRef(Form form, Color color)
        {
            this.parent_Form = form;
            this.color = color;
        }
        private void MinhChungHSG_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent_Form.Invoke((MethodInvoker)(() => this.parent_Form.Enabled = true));
        }

        private void MinhChungHSG_VisibleChanged(object sender, EventArgs e)
        {
            AutoChangeColor.changeColorFuncScreen2(this, color, new List<String>() { "Button", "Panel" });
        }

        private void upAnhBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                image = Image.FromFile(selectedFile);
                // Tiếp tục xử lý tập tin hình ảnh đã chọn
                //Console.WriteLine(image);
                
            }
        }

        public void getHSG(int idnk, int iddip, int namhoc)
        {
            this.idnk = idnk;
            this.iddip = iddip;
            this.namhoc = namhoc;
            nhan_khau HSG = HocSinhGioiUCCtrl.xemHSG(idnk);
            if(this.InvokeRequired)
                Invoke((MethodInvoker)delegate
                {
                    namHocLabel.Text = namhoc.ToString();
                    IDLabel.Text = idnk.ToString();
                    tenLabel.Text = HSG.hoTen;
                    //Console.WriteLine(1);
                });
            else
            {
                namHocLabel.Text = namhoc.ToString();
                IDLabel.Text = idnk.ToString();
                tenLabel.Text = HSG.hoTen;
                //Console.WriteLine(2);
            }

        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            int res = 0;
            if(truongHocTextBox.Text.Trim()==""|| !Int32.TryParse(lopTextBox.Text, out res)
                || thanhTichComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
                return;
            }
            string minhchung = image != null ? "MC" : "";
            HocSinhGioiUCCtrl.minhChung_themHSG(
                iddip,
                idnk,
                truongHocTextBox.Text.Trim(),
                lopTextBox.Text.Trim(),
                thanhTichComboBox.SelectedIndex+1,
                minhchung,
                minhchung!="");
            this.Close();
        }
    }
}
