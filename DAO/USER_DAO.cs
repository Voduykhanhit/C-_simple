using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Security.Cryptography;
namespace DAO
{
    public class USER_DAO
    {
        public static void Register(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            DataProvider.Instance.ExecuteNonQuery("sp_Register", "@Users_name,@Users_password", new object[] {username, hasPass});
        }
        public static DataTable ListUser() {
            return DataProvider.Instance.ExcuteQuery("sp_ListUser", "");
        }
        public static bool CheckLogin(string username,string password) {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData) {
                hasPass += item; 
            }

            return DataProvider.Instance.ExcuteQuery("sp_checkLogin", "@Users_name,@Users_password", new object[] {username,hasPass}).Rows.Count > 0;
        }
    }
}
