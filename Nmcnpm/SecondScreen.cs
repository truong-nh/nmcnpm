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

namespace Nhom5
{
    public partial class SecondScreen : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        public Button CurrentButton { get => currentButton; set => currentButton = value; }

        public SecondScreen()
        {
            InitializeComponent();
            hideAllUC();
            random = new Random();
            this.Activated += SecondScreen_Activated;
        }
        private void SecondScreen_Load(object sender, EventArgs e)
        {
            HandleTextBox.HandleTextBox_Load(this);
            foreach (Control control in this.Controls)
                if (control is UserControl)
                {
                    ButtonPaint.RoundedBtn_Load(control);
                }
        }
        private void SecondScreen_Activated(object sender, EventArgs e)
        {
            try
            {
                homeUC1.HomeUC_VisibleChanged(homeUC1, e);
                hoKhauUC1.HoKhauUC_VisibleChanged(hoKhauUC1, e);
                nhanKhauUC1.NhanKhauUC_VisibleChanged(nhanKhauUC1, e);
                hocSinhGioiUC1.HocSinhGioiUC_VisibleChanged(hocSinhGioiUC1, e);
                dipDacBiet1.DipDacBiet_VisibleChanged(dipDacBiet1, e);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void change_lblTitle(String text)
        {
            lblTitle.Text = text;
            lblTitle.Location = new Point() {
                X = (panelTitleBar.Width - lblTitle.Size.Width) / 2,
                Y = (panelTitleBar.Height - lblTitle.Size.Height) / 2
                };
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    //
                    change_lblTitle(currentButton.Text);
                   
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        #region button click
        private void homeBtn_Click(object sender, EventArgs e)
        {
            hideAllUC();
            ActivateButton(sender);
            homeUC1.Show();
        }
        private void nhanKhauBtn_Click(object sender, EventArgs e)
        {
            hideAllUC();
            ActivateButton(sender);
            nhanKhauUC1.Show();
        }
        private void hoKhauBtn_Click(object sender, EventArgs e)
        {
            hideAllUC();
            ActivateButton(sender);
            hoKhauUC1.Show();
        }
        private void phanThuongBtn_Click(object sender, EventArgs e)
        {
            hideAllUC();
            ActivateButton(sender);
            quanLyPhanThuong1.Show();
        }

        #endregion
        private void hideAllUC()
        {
            foreach (Control UC in this.Controls)
            {
                if (UC.GetType().BaseType == typeof(UserControl))
                {
                    UC.Hide();
                }
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            OpenScreen.openAnotherScreen(this, new StartScreen(), 0);
        }

        public void open_HocSinhGioiUC()
        {
            hideAllUC();
            this.hocSinhGioiUC1.Show();
        }

        public void open_DipDacBiet()
        {

            hideAllUC();
            this.dipDacBiet1.Show();
        }

        
    }
}
