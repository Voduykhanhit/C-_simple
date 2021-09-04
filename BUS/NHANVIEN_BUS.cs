using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class NHANVIEN_BUS
    {
        public static DataTable DanhSachNhanVien(){
           return NHANVIEN_DAO.DanhSachNhanVien();
        }
        public static void ThemNhanVien(NHANVIEN_DTO nhanvien) 
        {
            NHANVIEN_DAO.ThemNhanVien(nhanvien);
        }
        public static void SuaNhanVien(NHANVIEN_DTO nhanvien,int manhanvien){ 
            NHANVIEN_DAO.SuaNhanVien(nhanvien,manhanvien);
        }
        public static void XoaNhanVien(int manhanvien)
        {
            NHANVIEN_DAO.XoaNhanVien(manhanvien);
        }
        public static DataTable TimKiemNhanVien(string tennhanvien) {
            return NHANVIEN_DAO.TimKiemNhanVien(tennhanvien);
        }
    }
}
