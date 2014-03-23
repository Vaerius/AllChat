using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChat.Model
{
    class User_Accounts
    {
        private int userId;
        private int accountId;

        public User_Accounts(int userId, int accountId)
        {
            UserId = userId;
            AccountId = accountId;
        }

        public int UserId
        {
            get { return userId; }
            private set { userId = value; }
        }
        public int AccountId
        {
            get { return accountId; }
            private set { accountId = value; }
        }
    }
}
