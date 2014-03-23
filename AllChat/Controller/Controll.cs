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
            login = new Login();
            
        }

        public void DoLogin(string username, string userpass)
        {
            login.DoLogin(username, userpass);
        }
    }
}
