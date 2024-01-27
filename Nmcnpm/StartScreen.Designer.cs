
namespace Nhom5
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signUpUC1 = new Nhom5.View.login_signup.SignUpUC();
            this.loginUC1 = new Nhom5.View.login_signup.LoginUC();
            this.resetPassUC1 = new Nhom5.View.login_signup.ResetPassUC();
            this.forgetPassUC1 = new Nhom5.View.login_signup.ForgetPassUC();
            this.SuspendLayout();
            // 
            // signUpUC1
            // 
            this.signUpUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.signUpUC1.Location = new System.Drawing.Point(362, 0);
            this.signUpUC1.Name = "signUpUC1";
            this.signUpUC1.Size = new System.Drawing.Size(900, 673);
            this.signUpUC1.TabIndex = 1;
            // 
            // loginUC1
            // 
            this.loginUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.loginUC1.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginUC1.ForeColor = System.Drawing.Color.White;
            this.loginUC1.Location = new System.Drawing.Point(362, 0);
            this.loginUC1.Name = "loginUC1";
            this.loginUC1.Size = new System.Drawing.Size(900, 673);
            this.loginUC1.TabIndex = 0;
            // 
            // resetPassUC1
            // 
            this.resetPassUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.resetPassUC1.Location = new System.Drawing.Point(362, 0);
            this.resetPassUC1.Name = "resetPassUC1";
            this.resetPassUC1.Size = new System.Drawing.Size(900, 673);
            this.resetPassUC1.TabIndex = 3;
            // 
            // forgetPassUC1
            // 
            this.forgetPassUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.forgetPassUC1.Location = new System.Drawing.Point(362, 0);
            this.forgetPassUC1.Name = "forgetPassUC1";
            this.forgetPassUC1.Size = new System.Drawing.Size(900, 673);
            this.forgetPassUC1.TabIndex = 2;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.resetPassUC1);
            this.Controls.Add(this.forgetPassUC1);
            this.Controls.Add(this.signUpUC1);
            this.Controls.Add(this.loginUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân khẩu";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartScreen_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private View.login_signup.LoginUC loginUC1;
        private View.login_signup.SignUpUC signUpUC1;
        private View.login_signup.ForgetPassUC forgetPassUC1;
        private View.login_signup.ResetPassUC resetPassUC1;
    }
}