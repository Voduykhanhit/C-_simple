using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class USER_DTO
    {
        private int _user_id;

        public int User_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        private string _users_name;

        public string Users_name
        {
            get { return _users_name; }
            set { _users_name = value; }
        }
        private string _users_password;

        public string Users_password
        {
            get { return _users_password; }
            set { _users_password = value; }
        }
        private string _users_role;

        public string Users_role
        {
            get { return _users_role; }
            set { _users_role = value; }
        }
        public USER_DTO(string username, string password, string role) 
        {
            Users_name = username;
            Users_password = password;
            Users_role = role;
        }

    }
}
