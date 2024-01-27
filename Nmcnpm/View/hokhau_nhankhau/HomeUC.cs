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
using Nhom5.Controller.hokhau_nhankhau.homeUC;

namespace Nhom5.View.hokhau_nhankhau
{
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
           
        }
        public void HomeUC_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                nhanKhauLabel.Text = HomeUCCtrl.layNhanKhau().ToString();
                hoKhauLabel.Text = HomeUCCtrl.layHoKhau().ToString();
                tamTruLabel.Text = HomeUCCtrl.layTamTru().ToString();
                tamVangLabel.Text = HomeUCCtrl.layTamVang().ToString();
                foreach (Control panel in this.Controls)
                {
                    if (panel.GetType() == typeof(SPanel))
                    {
                        AutoChangeColor.changeSPanelScreen2(sender, panel as SPanel);
                    }
                }
            }    
        }
    }
}
