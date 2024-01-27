using Nhom5.Controller.login_signup;
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

namespace Nhom5.View.login_signup
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
            userNameText.LostFocus += UserNameText_LostFocus;
            userNameText.GotFocus += UserNameText_GotFocus;
            passwordText.LostFocus += PasswordText_LostFocus;
            passwordText.GotFocus += PasswordText_GotFocus;
            announcementLabel.Hide();
        }

        private void PasswordText_GotFocus(object sender, EventArgs e)
        {
            if (this.passwordText.Text == "Enter password")
                this.passwordText.Text = "";
            passwordText.PasswordChar = '\u25CF';
        }

        private void PasswordText_LostFocus(object sender, EventArgs e)
        {
            if (this.passwordText.Text == "")
            {
                this.passwordText.Text = "Enter password";
                passwordText.PasswordChar = '\0';
            }
        }

        private void UserNameText_GotFocus(object sender, EventArgs e)
        {
            if (this.userNameText.Text == "Enter user name")
                this.userNameText.Text = "";
        }

        private void UserNameText_LostFocus(object sender, EventArgs e)
        {
            if (this.userNameText.Text == "")
                this.userNameText.Text = "Enter user name";
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as StartScreen;
            startScreenForm.changeToSignUp();
        }

        private void forgetPassLabel_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as StartScreen;
            startScreenForm.changeToForget();
        }

        private void resetPassLabel_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as StartScreen;
            startScreenForm.changeToReset();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool ok = Login_SignUpCtrl.checkTK_MK(userNameText.Text, passwordText.Text); ;

            if(ok) // đăng nhập hợp lệ
            {
                var startScreenForm = this.Parent as StartScreen;
                OpenScreen.openAnotherScreen(startScreenForm, new SecondScreen(), 0); // đóng form start, mở form second
            } 
            else
            {
                announcementLabel.Show();
            }    

        }

        private void LoginUC_VisibleChanged(object sender, EventArgs e)
        {
            announcementLabel.Hide();
        }
    }
}
