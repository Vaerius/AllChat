using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChat.Model
{
    public class Account
    {
        private int accountId;
        private string accountName;
        private string accountPass;
        private string accountKind; //kind = Facebook, Skype, Twitter, ...

        public Account(int accountId, string accountName, string accountPass, string accountKind)
        {
            AccountId = accountId;
            AccountName = accountName;
            AccountPass = accountPass;
            AccountKind = accountKind;
        }

        public int AccountId
        {
            get { return accountId; }
            private set { accountId = value; }
        }

        public string AccountName
        {
            get { return accountName; }
            private set { accountName = value; }
        }
        public string AccountPass
        {
            get { return accountPass; }
            private set { accountPass = value; }
        }

        public string AccountKind
        {
            get { return accountKind; }
            private set { accountKind = value; }
        }
    }
}
