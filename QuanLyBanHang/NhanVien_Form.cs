using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyBanHang
{
    public partial class NhanVien_Form : Form
    {
        public NhanVien_Form()
        {
            InitializeComponent();
        }

        private void NhanVien_Form_Load(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = NHANVIEN_BUS.DanhSachNhanVien();
            dgv_NhanVien.Refresh();
        }

        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            string tennhanvien = txt_TenNV.Text;
            string gioitinh = cb_GioiTinhNV.Text;
            DateTime namsinh = DateTime.Parse(dtp_NamSinhNV.Text);
            string diachi = txt_DiaChiNV.Text;
            int sodienthoai = Convert.ToInt32(txt_SoDienThoaiNV.Text);
            NHANVIEN_DTO nhanvien  = new NHANVIEN_DTO(tennhanvien,gioitinh,namsinh,diachi,sodienthoai);
            NHANVIEN_BUS.ThemNhanVien(nhanvien);
            MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_NhanVien.DataSource = NHANVIEN_BUS.DanhSachNhanVien();

        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {
            int manhanvien = int.Parse(txt_MaNhanVien.Text);
            string tennhanvien = txt_TenNV.Text;
            string gioitinh = cb_GioiTinhNV.Text;
            DateTime namsinh = DateTime.Parse(dtp_NamSinhNV.Text);
            string diachi = txt_DiaChiNV.Text;
            int sodienthoai = Convert.ToInt32(txt_SoDienThoaiNV.Text);
            NHANVIEN_DTO nhanvien = new NHANVIEN_DTO(tennhanvien, gioitinh, namsinh, diachi, sodienthoai);
            NHANVIEN_BUS.SuaNhanVien(nhanvien, manhanvien);
            MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_NhanVien.DataSource = NHANVIEN_BUS.DanhSachNhanVien();
        }

        private void dgv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txt_MaNhanVien.DataBindings.Clear();
           cb_GioiTinhNV.DataBindings.Clear();
           dtp_NamSinhNV.DataBindings.Clear();
           txt_DiaChiNV.DataBindings.Clear();
           txt_SoDienThoaiNV.DataBindings.Clear();
           txt_TenNV.DataBindings.Clear();

           txt_MaNhanVien.DataBindings.Add(new Binding("Text", dgv_NhanVien.DataSource, "Mã nhân viên", true));
           cb_GioiTinhNV.DataBindings.Add(new Binding("Text", dgv_NhanVien.DataSource, "Giới tính", true));
           dtp_NamSinhNV.DataBindings.Add(new Binding("Text", dgv_NhanVien.DataSource, "Năm sinh", true));
           txt_DiaChiNV.DataBindings.Add(new Binding("Text", dgv_NhanVien.DataSource, "Địa chỉ", true));
           txt_SoDienThoaiNV.DataBindings.Add(new Binding("Text", dgv_NhanVien.DataSource, "Số điện thoại", true));
           txt_TenNV.DataBindings.Add(new Binding("Text", dgv_NhanVien.DataSource, "Tên nhân viên", true));
        }

        private void btn_khoitaoNV_Click(object sender, EventArgs e)
        {
            KhoiTao();
        }
        private void KhoiTao() {
            txt_MaNhanVien.Clear();
            txt_SoDienThoaiNV.Clear();
            dtp_NamSinhNV.ResetText();
            cb_GioiTinhNV.ResetText();
            txt_TenNV.Clear();
            txt_DiaChiNV.Clear();
            txt_MaNhanVien.DataBindings.Clear();
            cb_GioiTinhNV.DataBindings.Clear();
            dtp_NamSinhNV.DataBindings.Clear();
            txt_DiaChiNV.DataBindings.Clear();
            txt_SoDienThoaiNV.DataBindings.Clear();
            txt_TenNV.DataBindings.Clear();
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            int manhanvien = int.Parse(txt_MaNhanVien.Text);
            NHANVIEN_BUS.XoaNhanVien(manhanvien);
            dgv_NhanVien.DataSource = NHANVIEN_BUS.DanhSachNhanVien();
        }

        private void btn_ThoatNV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            string tennhanvien = txt_TenNV.Text;
            dgv_NhanVien.DataSource = NHANVIEN_BUS.TimKiemNhanVien(tennhanvien);
        }
        
    }
}
