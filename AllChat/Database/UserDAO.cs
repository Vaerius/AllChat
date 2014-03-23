using AllChat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChat.Database
{
    interface UserDAO
    {
        public User GetUserByUserId(int userId);
        public User getUserByUsername(string username);
        public bool checkUserPass(string username, string userpass);
        public void RegisterUser(string userName, string userPass);
    }
}
