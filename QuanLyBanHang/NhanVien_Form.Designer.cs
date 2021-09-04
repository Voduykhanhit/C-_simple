namespace QuanLyBanHang
{
    partial class NhanVien_Form
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
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_DiaChiNV = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoaiNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_GioiTinhNV = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_SuaNV = new System.Windows.Forms.Button();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.btn_khoitaoNV = new System.Windows.Forms.Button();
            this.btn_ThoatNV = new System.Windows.Forms.Button();
            this.dtp_NamSinhNV = new System.Windows.Forms.DateTimePicker();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(88, 42);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(135, 20);
            this.txt_TenNV.TabIndex = 0;
            // 
            // txt_DiaChiNV
            // 
            this.txt_DiaChiNV.Location = new System.Drawing.Point(88, 98);
            this.txt_DiaChiNV.Name = "txt_DiaChiNV";
            this.txt_DiaChiNV.Size = new System.Drawing.Size(135, 20);
            this.txt_DiaChiNV.TabIndex = 0;
            // 
            // txt_SoDienThoaiNV
            // 
            this.txt_SoDienThoaiNV.Location = new System.Drawing.Point(311, 98);
            this.txt_SoDienThoaiNV.Name = "txt_SoDienThoaiNV";
            this.txt_SoDienThoaiNV.Size = new System.Drawing.Size(146, 20);
            this.txt_SoDienThoaiNV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại";
            // 
            // cb_GioiTinhNV
            // 
            this.cb_GioiTinhNV.FormattingEnabled = true;
            this.cb_GioiTinhNV.Location = new System.Drawing.Point(311, 45);
            this.cb_GioiTinhNV.Name = "cb_GioiTinhNV";
            this.cb_GioiTinhNV.Size = new System.Drawing.Size(146, 21);
            this.cb_GioiTinhNV.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_NhanVien);
            this.groupBox1.Location = new System.Drawing.Point(9, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 256);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(6, 19);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.Size = new System.Drawing.Size(696, 231);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhanVien_CellContentClick);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Location = new System.Drawing.Point(21, 146);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemNV.TabIndex = 4;
            this.btn_ThemNV.Text = "Thêm ";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.Location = new System.Drawing.Point(102, 146);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaNV.TabIndex = 4;
            this.btn_SuaNV.Text = "Sửa";
            this.btn_SuaNV.UseVisualStyleBackColor = true;
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.Location = new System.Drawing.Point(183, 146);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaNV.TabIndex = 4;
            this.btn_XoaNV.Text = "Xoá";
            this.btn_XoaNV.UseVisualStyleBackColor = true;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // btn_khoitaoNV
            // 
            this.btn_khoitaoNV.Location = new System.Drawing.Point(264, 146);
            this.btn_khoitaoNV.Name = "btn_khoitaoNV";
            this.btn_khoitaoNV.Size = new System.Drawing.Size(75, 23);
            this.btn_khoitaoNV.TabIndex = 4;
            this.btn_khoitaoNV.Text = "Khởi tạo";
            this.btn_khoitaoNV.UseVisualStyleBackColor = true;
            this.btn_khoitaoNV.Click += new System.EventHandler(this.btn_khoitaoNV_Click);
            // 
            // btn_ThoatNV
            // 
            this.btn_ThoatNV.Location = new System.Drawing.Point(345, 146);
            this.btn_ThoatNV.Name = "btn_ThoatNV";
            this.btn_ThoatNV.Size = new System.Drawing.Size(75, 23);
            this.btn_ThoatNV.TabIndex = 4;
            this.btn_ThoatNV.Text = "Thoát";
            this.btn_ThoatNV.UseVisualStyleBackColor = true;
            this.btn_ThoatNV.Click += new System.EventHandler(this.btn_ThoatNV_Click);
            // 
            // dtp_NamSinhNV
            // 
            this.dtp_NamSinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NamSinhNV.Location = new System.Drawing.Point(529, 45);
            this.dtp_NamSinhNV.Name = "dtp_NamSinhNV";
            this.dtp_NamSinhNV.Size = new System.Drawing.Size(112, 20);
            this.dtp_NamSinhNV.TabIndex = 5;
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Location = new System.Drawing.Point(521, 98);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(120, 20);
            this.txt_MaNhanVien.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã NV";
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Location = new System.Drawing.Point(426, 146);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_Timkiem.TabIndex = 8;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // NhanVien_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 443);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_MaNhanVien);
            this.Controls.Add(this.dtp_NamSinhNV);
            this.Controls.Add(this.btn_ThoatNV);
            this.Controls.Add(this.btn_khoitaoNV);
            this.Controls.Add(this.btn_XoaNV);
            this.Controls.Add(this.btn_SuaNV);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_GioiTinhNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DiaChiNV);
            this.Controls.Add(this.txt_SoDienThoaiNV);
            this.Controls.Add(this.txt_TenNV);
            this.Name = "NhanVien_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien_Form";
            this.Load += new System.EventHandler(this.NhanVien_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_DiaChiNV;
        private System.Windows.Forms.TextBox txt_SoDienThoaiNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_GioiTinhNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_SuaNV;
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_khoitaoNV;
        private System.Windows.Forms.Button btn_ThoatNV;
        private System.Windows.Forms.DateTimePicker dtp_NamSinhNV;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Timkiem;
    }
}