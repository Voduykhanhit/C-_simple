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
    public class USER_BUS
    {
        public static void Register(string username, string password)
        {
            USER_DAO.Register(username,password);
        }
        public static DataTable ListUser() {
            return USER_DAO.ListUser();
        }
        public static bool CheckLogin(string username, string password) {
            return USER_DAO.CheckLogin(username, password);
        }
    }
}
