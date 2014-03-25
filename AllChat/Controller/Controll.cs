using AllChat.Database;
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
        private Dbase dbase;

        public Controll()
        {
            login = new Login();
            dbase = Dbase.getInstance();
        }

        public void RegisterNewUser(string username, string userpass)
        {
            if (CheckIllegalCharacters(username) && CheckIllegalCharacters(userpass))
            {
                dbase.RegisterNewUser(username, userpass);
            }
            else
            {
                throw new Exception("Invalid characters found.");
            }

        }

        public bool CheckUserExist(string username)
        {
            if (dbase.getUserByUsername(username).UserName == username)
            {
                return true;
            }
            return false;
        }

        public void DoLogin(string username, string userpass)
        {
            if (CheckIllegalCharacters(username) && CheckIllegalCharacters(userpass))
            {
                login.DoLogin(username, userpass);
            }
            else
            {
                throw new Exception("Invalid characters found.");
            }

        }

        private bool CheckIllegalCharacters(string s)
        {
            string toCheck = s.ToLower();
            string[] illegalChars = {"'", "&", "\"", "(", "§", "è", "!", "ç", "à", ")", "-", "$", "^", "¨", "ù",
                                    "µ", ",", ":", ";", "=", "~", "+", "/", ".", "?", "<", ">", "\\", "@", "#",
                                    "^", "{", "}", "[", "]", "´", "`", "€", "/", "*", "+" , "ê", "â", "û", "ô",
                                    "î", "ä", "ë", "ü", "ï", "ö", "á", "é", "ú", "í", "ó", "è", "ù", "ì", "ò",
                                    "ã", "ñ", "õ"};
            for (int i = 0; i < illegalChars.Length; i++)
            {
                if (toCheck.Contains(illegalChars[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
