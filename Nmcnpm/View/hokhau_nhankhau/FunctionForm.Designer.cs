
namespace Nhom5.View.hokhau_nhankhau
{
    partial class FunctionForm
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
            this.SuspendLayout();
            // 
            // FunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FunctionForm";
            this.Text = "FunctionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FunctionForm_FormClosed);
            this.Load += new System.EventHandler(this.FunctionForm_Load);
            this.VisibleChanged += new System.EventHandler(this.FunctionForm_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FunctionForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}