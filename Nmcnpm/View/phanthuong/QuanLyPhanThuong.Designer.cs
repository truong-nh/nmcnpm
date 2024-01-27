
namespace Nhom5.View.phanthuong
{
    partial class QuanLyPhanThuong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dipDacBietBtn = new System.Windows.Forms.Button();
            this.hsgBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dipDacBietBtn
            // 
            this.dipDacBietBtn.BackColor = System.Drawing.Color.Gray;
            this.dipDacBietBtn.FlatAppearance.BorderSize = 0;
            this.dipDacBietBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dipDacBietBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dipDacBietBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dipDacBietBtn.Image = global::Nhom5.Properties.Resources.icons8_event_accepted_tentatively_100;
            this.dipDacBietBtn.Location = new System.Drawing.Point(586, 189);
            this.dipDacBietBtn.Name = "dipDacBietBtn";
            this.dipDacBietBtn.Size = new System.Drawing.Size(260, 190);
            this.dipDacBietBtn.TabIndex = 3;
            this.dipDacBietBtn.Text = "Phần thưởng dịp đặc biệt";
            this.dipDacBietBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dipDacBietBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dipDacBietBtn.UseVisualStyleBackColor = false;
            this.dipDacBietBtn.Click += new System.EventHandler(this.dipDacBietBtn_Click);
            // 
            // hsgBtn
            // 
            this.hsgBtn.BackColor = System.Drawing.Color.Gray;
            this.hsgBtn.FlatAppearance.BorderSize = 0;
            this.hsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsgBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hsgBtn.Image = global::Nhom5.Properties.Resources.icons8_student_center_100;
            this.hsgBtn.Location = new System.Drawing.Point(203, 189);
            this.hsgBtn.Name = "hsgBtn";
            this.hsgBtn.Size = new System.Drawing.Size(260, 190);
            this.hsgBtn.TabIndex = 2;
            this.hsgBtn.Text = "Phần thưởng học sinh giỏi";
            this.hsgBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsgBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hsgBtn.UseVisualStyleBackColor = false;
            this.hsgBtn.Click += new System.EventHandler(this.hsgBtn_Click);
            // 
            // QuanLyPhanThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.dipDacBietBtn);
            this.Controls.Add(this.hsgBtn);
            this.Name = "QuanLyPhanThuong";
            this.Size = new System.Drawing.Size(1048, 595);
            this.VisibleChanged += new System.EventHandler(this.QuanLyPhanThuong_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hsgBtn;
        private System.Windows.Forms.Button dipDacBietBtn;
    }
}
