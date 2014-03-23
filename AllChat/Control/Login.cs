using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChat
{
    class Login
    {
        private static Login instance;
        private int userId;
        private string userName;
        private string userPass;

        private Login()
        {
            UserId = -1;
            UserName = "";
            UserPass = "";
        }

        public int UserId
        {
            get { return userId; }
            private set { userId = value; }
        }
        private string UserPass
        {
            get { return userPass; }
            set { userPass = value; }
        }

        public string UserName
        {
            get { return userName; }
            private set { userName = value; }
        }

        public static Login getLogin
        {
            get
            {
                if (instance == null)
                {
                    instance = new Login();
                }
                return instance;
            }
        }


    }
}
