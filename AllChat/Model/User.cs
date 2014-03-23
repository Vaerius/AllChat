using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChat.Model
{
    class User
    {
        private int userId;
        private string userName;
        private string userPass;

        public User(int userId, string userName, string userPass)
        {
            UserId = userId;
            UserName = userName;
            UserPass = userPass;
        }

        public int UserId
        {
            get { return userId; }
            private set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            private set { userName = value; }
        }
        public string UserPass
        {
            get { return userPass; }
            private set { userPass = value; }
        }

    }
}
