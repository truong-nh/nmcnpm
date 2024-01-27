using Nhom5.Controller.trao_thuong;
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
    public partial class ChinhSuaDip : FunctionForm
    {
        public ChinhSuaDip()
        {
            InitializeComponent();
        }
        int iddip;
        public void getDipDacBiet(int iddip)
        {
            this.iddip = iddip;
            dip_dac_biet dipDB = DipDacBietUCCtrl.xemDipDacBiet(iddip);
            Invoke((MethodInvoker)delegate
            {
                iDDipTextBox.Text = dipDB.idDip.ToString();
                namLabel.Text = dipDB.nam.ToString();
            });
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            int res;
            if(tenDipTextBox.Text.Trim()==""
                || doTuoi1TextBox.Text.Trim()=="" || !Int32.TryParse(tien1TextBox.Text, out res)
                || doTuoi1TextBox.Text.Trim() == "" || !Int32.TryParse(tien2TextBox.Text, out res)
                || doTuoi1TextBox.Text.Trim() == "" || !Int32.TryParse(tien3TextBox.Text, out res))
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
                return;
            }
            DipDacBietUCCtrl.chinhSuaDipDacBiet(
                iddip,
                tenDipTextBox.Text.Trim(),
                doTuoi1TextBox.Text.Trim(),
                Int32.Parse(tien1TextBox.Text),
                doTuoi2TextBox.Text.Trim(),
                Int32.Parse(tien2TextBox.Text),
                doTuoi3TextBox.Text.Trim(),
                Int32.Parse(tien3TextBox.Text),
                moTaTextBox.Text
                );
            this.Close();
        }
    }
}
