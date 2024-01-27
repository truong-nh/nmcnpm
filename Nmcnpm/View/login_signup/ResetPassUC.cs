using Nhom5.Controller.login_signup;
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
    public partial class ResetPassUC : UserControl
    {
        public ResetPassUC()
        {
            InitializeComponent();
            userNameText.LostFocus += UserNameText_LostFocus;
            userNameText.GotFocus += UserNameText_GotFocus;
            passwordText.LostFocus += PasswordText_LostFocus;
            passwordText.GotFocus += PasswordText_GotFocus;
            repeatPasswordText.LostFocus += repeatPasswordText_LostFocus;
            repeatPasswordText.GotFocus += repeatPasswordText_GotFocus;
            newPassText.LostFocus += NewPassText_LostFocus;
            newPassText.GotFocus += NewPassText_GotFocus;
            announcementLabel.Hide();
            validateLabel.Hide();
        }

        private void NewPassText_GotFocus(object sender, EventArgs e)
        {
            if (this.newPassText.Text == "Enter new password")
                this.newPassText.Text = "";
            newPassText.PasswordChar = '\u25CF';
        }

        private void NewPassText_LostFocus(object sender, EventArgs e)
        {
            if (this.newPassText.Text == "")
            {
                this.newPassText.Text = "Enter new password";
                newPassText.PasswordChar = '\0';
            }
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
            if (this.passwordText.Text == "Enter old password")
                this.passwordText.Text = "";
            passwordText.PasswordChar = '\u25CF';
        }

        private void PasswordText_LostFocus(object sender, EventArgs e)
        {
            if (this.passwordText.Text == "")
            {
                this.passwordText.Text = "Enter old password";
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
            if (newPassText.Text != repeatPasswordText.Text)
            {
                validateLabel.Show();
                return;
            }
            if (Login_SignUpCtrl.checkTK_MK(userNameText.Text, passwordText.Text))
            {
                Login_SignUpCtrl.changeMK(userNameText.Text, newPassText.Text);
                MessageBox.Show("Đổi mật khẩu thành công");
                backLabel_Click(sender, e);
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

        private void ResetPassUC_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void ResetPassUC_VisibleChanged(object sender, EventArgs e)
        {
            validateLabel.Hide();
            announcementLabel.Hide();
        }
    }
}
