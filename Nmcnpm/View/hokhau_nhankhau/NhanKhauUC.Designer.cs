
namespace Nhom5.View.hokhau_nhankhau
{
    partial class NhanKhauUC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.themMoiBtn = new System.Windows.Forms.Button();
            this.dKTamVangBtn = new System.Windows.Forms.Button();
            this.dKTamTruBtn = new System.Windows.Forms.Button();
            this.khaiTuBtn = new System.Windows.Forms.Button();
            this.xemChiTietBtn = new System.Windows.Forms.Button();
            this.chinhSuaBtn = new System.Windows.Forms.Button();
            this.reLoadSPanel = new Nhom5.Utility.SPanel();
            this.reLoadPic = new System.Windows.Forms.PictureBox();
            this.searchSPanel = new Nhom5.Utility.SPanel();
            this.searchPic = new System.Windows.Forms.PictureBox();
            this.sPanel1 = new Nhom5.Utility.SPanel();
            this.searchTextBox1 = new Nhom5.Utility.WaterMarkTextBox();
            this.featureSearchBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.reLoadSPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reLoadPic)).BeginInit();
            this.searchSPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).BeginInit();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 130);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // themMoiBtn
            // 
            this.themMoiBtn.BackColor = System.Drawing.Color.Gray;
            this.themMoiBtn.FlatAppearance.BorderSize = 0;
            this.themMoiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themMoiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themMoiBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.themMoiBtn.Location = new System.Drawing.Point(829, 130);
            this.themMoiBtn.Name = "themMoiBtn";
            this.themMoiBtn.Size = new System.Drawing.Size(172, 59);
            this.themMoiBtn.TabIndex = 1;
            this.themMoiBtn.Text = "Thêm mới";
            this.themMoiBtn.UseVisualStyleBackColor = false;
            this.themMoiBtn.EnabledChanged += new System.EventHandler(this.themMoiBtn_EnabledChanged);
            this.themMoiBtn.Click += new System.EventHandler(this.themMoiBtn_Click);
            // 
            // dKTamVangBtn
            // 
            this.dKTamVangBtn.BackColor = System.Drawing.Color.Gray;
            this.dKTamVangBtn.FlatAppearance.BorderSize = 0;
            this.dKTamVangBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dKTamVangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dKTamVangBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dKTamVangBtn.Location = new System.Drawing.Point(829, 325);
            this.dKTamVangBtn.Name = "dKTamVangBtn";
            this.dKTamVangBtn.Size = new System.Drawing.Size(172, 59);
            this.dKTamVangBtn.TabIndex = 2;
            this.dKTamVangBtn.Text = "DK tạm vắng";
            this.dKTamVangBtn.UseVisualStyleBackColor = false;
            this.dKTamVangBtn.Click += new System.EventHandler(this.dKTamVangBtn_Click);
            // 
            // dKTamTruBtn
            // 
            this.dKTamTruBtn.BackColor = System.Drawing.Color.Gray;
            this.dKTamTruBtn.FlatAppearance.BorderSize = 0;
            this.dKTamTruBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dKTamTruBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dKTamTruBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dKTamTruBtn.Location = new System.Drawing.Point(829, 390);
            this.dKTamTruBtn.Name = "dKTamTruBtn";
            this.dKTamTruBtn.Size = new System.Drawing.Size(172, 59);
            this.dKTamTruBtn.TabIndex = 3;
            this.dKTamTruBtn.Text = "DK tạm trú";
            this.dKTamTruBtn.UseVisualStyleBackColor = false;
            this.dKTamTruBtn.Click += new System.EventHandler(this.dKTamTruBtn_Click);
            // 
            // khaiTuBtn
            // 
            this.khaiTuBtn.BackColor = System.Drawing.Color.Gray;
            this.khaiTuBtn.FlatAppearance.BorderSize = 0;
            this.khaiTuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.khaiTuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khaiTuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.khaiTuBtn.Location = new System.Drawing.Point(829, 455);
            this.khaiTuBtn.Name = "khaiTuBtn";
            this.khaiTuBtn.Size = new System.Drawing.Size(172, 59);
            this.khaiTuBtn.TabIndex = 4;
            this.khaiTuBtn.Text = "Khai tử";
            this.khaiTuBtn.UseVisualStyleBackColor = false;
            this.khaiTuBtn.Click += new System.EventHandler(this.khaiTuBtn_Click);
            // 
            // xemChiTietBtn
            // 
            this.xemChiTietBtn.BackColor = System.Drawing.Color.Gray;
            this.xemChiTietBtn.FlatAppearance.BorderSize = 0;
            this.xemChiTietBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xemChiTietBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xemChiTietBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.xemChiTietBtn.Location = new System.Drawing.Point(829, 195);
            this.xemChiTietBtn.Name = "xemChiTietBtn";
            this.xemChiTietBtn.Size = new System.Drawing.Size(172, 59);
            this.xemChiTietBtn.TabIndex = 4;
            this.xemChiTietBtn.Text = "Xem chi tiết";
            this.xemChiTietBtn.UseVisualStyleBackColor = false;
            this.xemChiTietBtn.Click += new System.EventHandler(this.xemChiTietBtn_Click);
            // 
            // chinhSuaBtn
            // 
            this.chinhSuaBtn.BackColor = System.Drawing.Color.Gray;
            this.chinhSuaBtn.FlatAppearance.BorderSize = 0;
            this.chinhSuaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chinhSuaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chinhSuaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chinhSuaBtn.Location = new System.Drawing.Point(829, 260);
            this.chinhSuaBtn.Name = "chinhSuaBtn";
            this.chinhSuaBtn.Size = new System.Drawing.Size(172, 59);
            this.chinhSuaBtn.TabIndex = 5;
            this.chinhSuaBtn.Text = "Chỉnh sửa";
            this.chinhSuaBtn.UseVisualStyleBackColor = false;
            this.chinhSuaBtn.Click += new System.EventHandler(this.chinhSuaBtn_Click);
            // 
            // reLoadSPanel
            // 
            this.reLoadSPanel.Controls.Add(this.reLoadPic);
            this.reLoadSPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reLoadSPanel.Location = new System.Drawing.Point(46, 70);
            this.reLoadSPanel.Name = "reLoadSPanel";
            this.reLoadSPanel.Size = new System.Drawing.Size(50, 50);
            this.reLoadSPanel.TabIndex = 13;
            this.reLoadSPanel.Click += new System.EventHandler(this.reLoadSPanel_Click);
            // 
            // reLoadPic
            // 
            this.reLoadPic.Image = global::Nhom5.Properties.Resources.icons8_update_left_rotation_50;
            this.reLoadPic.Location = new System.Drawing.Point(10, 10);
            this.reLoadPic.Name = "reLoadPic";
            this.reLoadPic.Size = new System.Drawing.Size(30, 30);
            this.reLoadPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reLoadPic.TabIndex = 0;
            this.reLoadPic.TabStop = false;
            this.reLoadPic.Click += new System.EventHandler(this.reLoadPic_Click);
            // 
            // searchSPanel
            // 
            this.searchSPanel.Controls.Add(this.searchPic);
            this.searchSPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchSPanel.Location = new System.Drawing.Point(686, 70);
            this.searchSPanel.Name = "searchSPanel";
            this.searchSPanel.Size = new System.Drawing.Size(50, 50);
            this.searchSPanel.TabIndex = 12;
            this.searchSPanel.Click += new System.EventHandler(this.searchSPanel_Click);
            // 
            // searchPic
            // 
            this.searchPic.Image = global::Nhom5.Properties.Resources.icons8_magnifying_glass_64;
            this.searchPic.Location = new System.Drawing.Point(10, 10);
            this.searchPic.Name = "searchPic";
            this.searchPic.Size = new System.Drawing.Size(30, 30);
            this.searchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchPic.TabIndex = 0;
            this.searchPic.TabStop = false;
            this.searchPic.Click += new System.EventHandler(this.searchPic_Click);
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sPanel1.Controls.Add(this.searchTextBox1);
            this.sPanel1.Controls.Add(this.featureSearchBox);
            this.sPanel1.Location = new System.Drawing.Point(283, 82);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sPanel1.Size = new System.Drawing.Size(397, 29);
            this.sPanel1.TabIndex = 7;
            // 
            // searchTextBox1
            // 
            this.searchTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTextBox1.BackColor = System.Drawing.Color.White;
            this.searchTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox1.Location = new System.Drawing.Point(10, 4);
            this.searchTextBox1.Name = "searchTextBox1";
            this.searchTextBox1.Size = new System.Drawing.Size(236, 20);
            this.searchTextBox1.TabIndex = 5;
            this.searchTextBox1.WaterMarkColor = System.Drawing.Color.DimGray;
            this.searchTextBox1.WaterMarkText = "Nhập dữ liệu tra cứu";
            // 
            // featureSearchBox
            // 
            this.featureSearchBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.featureSearchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.featureSearchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.featureSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featureSearchBox.FormattingEnabled = true;
            this.featureSearchBox.Items.AddRange(new object[] {
            "ID nhân khẩu",
            "Họ tên",
            "Giới tính",
            "CCCD/CMND",
            "Trạng thái"});
            this.featureSearchBox.Location = new System.Drawing.Point(265, 0);
            this.featureSearchBox.Name = "featureSearchBox";
            this.featureSearchBox.Size = new System.Drawing.Size(130, 26);
            this.featureSearchBox.TabIndex = 6;
            // 
            // NhanKhauUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.reLoadSPanel);
            this.Controls.Add(this.searchSPanel);
            this.Controls.Add(this.khaiTuBtn);
            this.Controls.Add(this.dKTamTruBtn);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.dKTamVangBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chinhSuaBtn);
            this.Controls.Add(this.xemChiTietBtn);
            this.Controls.Add(this.themMoiBtn);
            this.Name = "NhanKhauUC";
            this.Size = new System.Drawing.Size(1048, 595);
            this.Load += new System.EventHandler(this.NhanKhauUC_Load);
            this.VisibleChanged += new System.EventHandler(this.NhanKhauUC_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NhanKhauUC_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.reLoadSPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reLoadPic)).EndInit();
            this.searchSPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button themMoiBtn;
        private System.Windows.Forms.Button dKTamVangBtn;
        private System.Windows.Forms.Button dKTamTruBtn;
        private System.Windows.Forms.Button khaiTuBtn;
        private System.Windows.Forms.Button xemChiTietBtn;
        private Utility.WaterMarkTextBox searchTextBox1;
        private System.Windows.Forms.ComboBox featureSearchBox;
        private Utility.SPanel sPanel1;
        private System.Windows.Forms.Button chinhSuaBtn;
        private Utility.SPanel reLoadSPanel;
        private System.Windows.Forms.PictureBox reLoadPic;
        private Utility.SPanel searchSPanel;
        private System.Windows.Forms.PictureBox searchPic;
    }
}
