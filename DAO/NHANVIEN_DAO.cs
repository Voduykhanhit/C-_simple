using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class NHANVIEN_DAO
    {
        
        public static DataTable DanhSachNhanVien(){
            return DataProvider.Instance.ExcuteQuery("sp_DanhSachNhanVien", "");
        }
        public static void ThemNhanVien(NHANVIEN_DTO nhanvien){

            DataProvider.Instance.ExecuteNonQuery("sp_ThemNhanVien",
                "@TenNhanVien,@GioiTinh,@NamSinh,@DiaChi,@SoDienThoai",
                new object[] { nhanvien.TenNhanVien, nhanvien.GioiTinh, nhanvien.NamSinh, nhanvien.DiaChi, nhanvien.SoDienThoai });
        }
        public static void SuaNhanVien(NHANVIEN_DTO nhanvien,int manhanvien) {
            DataProvider.Instance.ExecuteNonQuery("sp_SuaNhanVien",
                "@MaNhanVien,@TenNhanVien,@GioiTinh,@NamSinh,@DiaChi,@SoDienThoai",
                new object[] { manhanvien,nhanvien.TenNhanVien, nhanvien.GioiTinh, nhanvien.NamSinh, nhanvien.DiaChi, nhanvien.SoDienThoai });
          
        }
        public static void XoaNhanVien(int manhanvien)
        {
            DataProvider.Instance.ExecuteNonQuery("sp_XoaNhanVien",
                "@MaNhanVien",
                new object[] { manhanvien});
        }
        public static DataTable TimKiemNhanVien(string tennhanvien) {
            return DataProvider.Instance.ExcuteQuery("sp_TimKiemNhanVien",
               "@TenNhanVien",
               new object[] { tennhanvien });
        } 
    }
}
