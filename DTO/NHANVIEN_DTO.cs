using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NHANVIEN_DTO
    {
        private int _maNhanVien;

        public int MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        private string _tenNhanVien;

        public string TenNhanVien
        {
            get { return _tenNhanVien; }
            set { _tenNhanVien = value; }
        }
        private string _gioiTinh;

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        private DateTime _namSinh;

        public DateTime NamSinh
        {
            get { return _namSinh; }
            set { _namSinh = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private int _soDienThoai;

        public int SoDienThoai
        {
            get { return _soDienThoai; }
            set { _soDienThoai = value; }
        }
        public NHANVIEN_DTO(string tennhanvien, string gioitinh, DateTime namsinh, string diachi, int sodienthoai) {
            TenNhanVien = tennhanvien;
            GioiTinh = gioitinh;
            NamSinh = namsinh;
            DiaChi = diachi;
            SoDienThoai = sodienthoai;
        } 
    }
}
