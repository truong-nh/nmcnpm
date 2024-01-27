using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom5.Controller.login_signup;

namespace Nhom5.View.login_signup
{
    public partial class SignUpUC : UserControl
    {
        public SignUpUC()
        {
            InitializeComponent();
            userNameText.LostFocus += UserNameText_LostFocus;
            userNameText.GotFocus += UserNameText_GotFocus;
            passwordText.LostFocus += PasswordText_LostFocus;
            passwordText.GotFocus += PasswordText_GotFocus;
            repeatPasswordText.LostFocus += repeatPasswordText_LostFocus;
            repeatPasswordText.GotFocus += repeatPasswordText_GotFocus;

        }

        private void repeatPasswordText_GotFocus(object sender, EventArgs e)
        {
            if (this.repeatPasswordText.Text == "Repeat password")
                this.repeatPasswordText.Text = "";
            repeatPasswordText.PasswordChar = '\u25CF';
        }

        private void repeatPasswordText_LostFocus(object sender, EventArgs e)
        {
            if (this.repeatPasswordText.Text == "")
            {
                this.repeatPasswordText.Text = "Repeat password";
                repeatPasswordText.PasswordChar = '\0';
            }
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

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (!Login_SignUpCtrl.checkExistTK(userNameText.Text))
            {  
                if(passwordText.Text != repeatPasswordText.Text)
                {
                    validateLabel.Show();
                }
                else 
                {
                    // thêm tài khoản mật khẩu vào csdl
                    Login_SignUpCtrl.addTK_MK(userNameText.Text, passwordText.Text);
                    // chuyển đến màn hình login
                    var startScreenForm = this.Parent as StartScreen;
                    startScreenForm.changeToLogin();
                    //
                    MessageBox.Show("Đăng kí thành công");
                }
            }
            else
            {
                announcementLabel.Show();
            }    
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            var startScreenForm = this.Parent as StartScreen;
            startScreenForm.changeToLogin();
        }

        private void SignUpUC_VisibleChanged(object sender, EventArgs e)
        {
            validateLabel.Hide();
            announcementLabel.Hide();
        }
    }
}
