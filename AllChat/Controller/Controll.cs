using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AllChat.Controller
{
    public class Controll
    {
        private Login login;

        public Controll()
        {
            login = Login.getLogin;
        }

        public void DoLogin(string username, string userpass)
        {
            login.DoLogin(username, userpass);
        }
    }
}
