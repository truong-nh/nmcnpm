
namespace Nhom5.View.hokhau_nhankhau.nhankhau_function
{
    partial class DanhSachHSG
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dongBtn = new System.Windows.Forms.Button();
            this.sPanel1 = new Nhom5.Utility.SPanel();
            this.searchTextBox1 = new Nhom5.Utility.WaterMarkTextBox();
            this.featureSearchBox = new System.Windows.Forms.ComboBox();
            this.namHocLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.themMinhChungBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.reloadBtn2 = new System.Windows.Forms.Button();
            this.searchBtn2 = new System.Windows.Forms.Button();
            this.sPanel2 = new Nhom5.Utility.SPanel();
            this.searchTextBox2 = new Nhom5.Utility.WaterMarkTextBox();
            this.featureSearchBox2 = new System.Windows.Forms.ComboBox();
            this.panelTitleBar.SuspendLayout();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.sPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1182, 75);
            this.panelTitleBar.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(272, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(639, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Danh sách học sinh nhận thưởng học sinh giỏi";
            // 
            // dongBtn
            // 
            this.dongBtn.BackColor = System.Drawing.Color.Gray;
            this.dongBtn.FlatAppearance.BorderSize = 0;
            this.dongBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dongBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dongBtn.Location = new System.Drawing.Point(694, 568);
            this.dongBtn.Name = "dongBtn";
            this.dongBtn.Size = new System.Drawing.Size(140, 59);
            this.dongBtn.TabIndex = 16;
            this.dongBtn.Text = "Đóng";
            this.dongBtn.UseVisualStyleBackColor = false;
            this.dongBtn.Click += new System.EventHandler(this.dongBtn_Click);
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sPanel1.Controls.Add(this.searchTextBox1);
            this.sPanel1.Controls.Add(this.featureSearchBox);
            this.sPanel1.Location = new System.Drawing.Point(100, 182);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sPanel1.Size = new System.Drawing.Size(397, 29);
            this.sPanel1.TabIndex = 18;
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
            "ID dịp",
            "Họ tên",
            "Thành tích",
            "Trường",
            "Lớp"});
            this.featureSearchBox.Location = new System.Drawing.Point(265, 0);
            this.featureSearchBox.Name = "featureSearchBox";
            this.featureSearchBox.Size = new System.Drawing.Size(130, 26);
            this.featureSearchBox.TabIndex = 6;
            // 
            // namHocLabel
            // 
            this.namHocLabel.AutoSize = true;
            this.namHocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namHocLabel.Location = new System.Drawing.Point(175, 94);
            this.namHocLabel.Name = "namHocLabel";
            this.namHocLabel.Size = new System.Drawing.Size(45, 20);
            this.namHocLabel.TabIndex = 19;
            this.namHocLabel.Text = "2020";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Năm học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Danh sách học sinh nhận thưởng:";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Gray;
            this.searchBtn.BackgroundImage = global::Nhom5.Properties.Resources.icons8_magnifying_glass_64;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchBtn.Location = new System.Drawing.Point(513, 175);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(40, 40);
            this.searchBtn.TabIndex = 22;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.Gray;
            this.reloadBtn.BackgroundImage = global::Nhom5.Properties.Resources.icons8_update_left_rotation_50;
            this.reloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadBtn.FlatAppearance.BorderSize = 0;
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reloadBtn.Location = new System.Drawing.Point(54, 171);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(40, 40);
            this.reloadBtn.TabIndex = 23;
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // themMinhChungBtn
            // 
            this.themMinhChungBtn.BackColor = System.Drawing.Color.Gray;
            this.themMinhChungBtn.FlatAppearance.BorderSize = 0;
            this.themMinhChungBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themMinhChungBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themMinhChungBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.themMinhChungBtn.Location = new System.Drawing.Point(348, 570);
            this.themMinhChungBtn.Name = "themMinhChungBtn";
            this.themMinhChungBtn.Size = new System.Drawing.Size(172, 59);
            this.themMinhChungBtn.TabIndex = 24;
            this.themMinhChungBtn.Text = "Thêm minh chứng";
            this.themMinhChungBtn.UseVisualStyleBackColor = false;
            this.themMinhChungBtn.Click += new System.EventHandler(this.themMinhChungBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 216);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(511, 337);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(618, 216);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(511, 337);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(614, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Danh sách học sinh chưa đăng kí nhận thưởng:";
            // 
            // reloadBtn2
            // 
            this.reloadBtn2.BackColor = System.Drawing.Color.Gray;
            this.reloadBtn2.BackgroundImage = global::Nhom5.Properties.Resources.icons8_update_left_rotation_50;
            this.reloadBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadBtn2.FlatAppearance.BorderSize = 0;
            this.reloadBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBtn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reloadBtn2.Location = new System.Drawing.Point(621, 170);
            this.reloadBtn2.Name = "reloadBtn2";
            this.reloadBtn2.Size = new System.Drawing.Size(40, 40);
            this.reloadBtn2.TabIndex = 30;
            this.reloadBtn2.UseVisualStyleBackColor = false;
            this.reloadBtn2.Click += new System.EventHandler(this.reloadBtn2_Click);
            // 
            // searchBtn2
            // 
            this.searchBtn2.BackColor = System.Drawing.Color.Gray;
            this.searchBtn2.BackgroundImage = global::Nhom5.Properties.Resources.icons8_magnifying_glass_64;
            this.searchBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn2.FlatAppearance.BorderSize = 0;
            this.searchBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchBtn2.Location = new System.Drawing.Point(1080, 174);
            this.searchBtn2.Name = "searchBtn2";
            this.searchBtn2.Size = new System.Drawing.Size(40, 40);
            this.searchBtn2.TabIndex = 29;
            this.searchBtn2.UseVisualStyleBackColor = false;
            this.searchBtn2.Click += new System.EventHandler(this.searchBtn2_Click);
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.White;
            this.sPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sPanel2.Controls.Add(this.searchTextBox2);
            this.sPanel2.Controls.Add(this.featureSearchBox2);
            this.sPanel2.Location = new System.Drawing.Point(667, 181);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sPanel2.Size = new System.Drawing.Size(397, 29);
            this.sPanel2.TabIndex = 28;
            // 
            // searchTextBox2
            // 
            this.searchTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTextBox2.BackColor = System.Drawing.Color.White;
            this.searchTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox2.Location = new System.Drawing.Point(10, 4);
            this.searchTextBox2.Name = "searchTextBox2";
            this.searchTextBox2.Size = new System.Drawing.Size(236, 20);
            this.searchTextBox2.TabIndex = 5;
            this.searchTextBox2.WaterMarkColor = System.Drawing.Color.DimGray;
            this.searchTextBox2.WaterMarkText = "Nhập dữ liệu tra cứu";
            // 
            // featureSearchBox2
            // 
            this.featureSearchBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.featureSearchBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.featureSearchBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.featureSearchBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featureSearchBox2.FormattingEnabled = true;
            this.featureSearchBox2.Items.AddRange(new object[] {
            "ID nhân khẩu",
            "Họ tên"});
            this.featureSearchBox2.Location = new System.Drawing.Point(265, 0);
            this.featureSearchBox2.Name = "featureSearchBox2";
            this.featureSearchBox2.Size = new System.Drawing.Size(130, 26);
            this.featureSearchBox2.TabIndex = 6;
            // 
            // DanhSachHSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.reloadBtn2);
            this.Controls.Add(this.searchBtn2);
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.themMinhChungBtn);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namHocLabel);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.dongBtn);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DanhSachHSG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học sinh nhận thưởng";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.sPanel2.ResumeLayout(false);
            this.sPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button dongBtn;
        private Utility.SPanel sPanel1;
        private Utility.WaterMarkTextBox searchTextBox1;
        private System.Windows.Forms.ComboBox featureSearchBox;
        private System.Windows.Forms.Label namHocLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Button themMinhChungBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button reloadBtn2;
        private System.Windows.Forms.Button searchBtn2;
        private Utility.SPanel sPanel2;
        private Utility.WaterMarkTextBox searchTextBox2;
        private System.Windows.Forms.ComboBox featureSearchBox2;
    }
}