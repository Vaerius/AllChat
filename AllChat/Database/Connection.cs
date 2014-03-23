using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChat.Database
{
    class Connection
    {
        SqlConnection connect;
        private static Connection instance;

        private Connection()
        {
            connect = new SqlConnection("Server=localhost;Database=allchat;Uid=root;");
        }

        public static Connection getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Connection();
                }
                return instance;
            }
        }

        public SqlConnection getConnection()
        {
            return connect;
        }
    }
}
