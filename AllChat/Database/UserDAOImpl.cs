using AllChat.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllChat.Database
{
    class UserDAOImpl : UserDAO
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader resultSet;
        private string sqlString;

        public UserDAOImpl()
        {
            connection = Connection.getInstance.getConnection();
            command = new SqlCommand("", connection);
            sqlString = "";
        }

        public User UserDAO.GetUserByUserId(int userid)
        {
            try{
                string username = "";
                string userpass = "";

                User user = new User(userid, username, userpass);
                connection.Open();
                sqlString = "SELECT * FROM user WHERE user_id = @userid";
                command.CommandText = sqlString;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@userid", userid);
                resultSet = command.ExecuteReader();
                while (resultSet.Read())
                {
                    username = (string)resultSet["user_name"];
                    userpass = (string)resultSet["user_pass"];
                    user = new User(userid, username, userpass);
                }
                return user;
            }
            finally
            {
                if (resultSet != null)
                { resultSet.Close(); }
                if (connection != null)
                { connection.Close(); }
            }
        }
        public User UserDAO.getUserByUsername(string username)
        {
            try
            {
                int userid = 0;
                string userpass = "";

                User user = new User(userid, username, userpass);
                connection.Open();
                sqlString = "SELECT * FROM user WHERE user_name = @username";
                command.CommandText = sqlString;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@username", username);
                resultSet = command.ExecuteReader();
                while (resultSet.Read())
                {
                    userid = (int)resultSet["user_id"];
                    userpass = (string)resultSet["user_pass"];
                    user = new User(userid, username, userpass);
                }
                return user;
            }
            finally
            {
                if (resultSet != null)
                { resultSet.Close(); }
                if (connection != null)
                { connection.Close(); }
            }
        }
        public bool UserDAO.checkUserPass(string username, string userpass)
        {
            bool check = false;
            try
            {
                connection.Open();
                sqlString = "SELECT * FROM user WHERE user_name = @username";
                command.CommandText = sqlString;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@username", username);
                resultSet = command.ExecuteReader();
                while (resultSet.Read())
                {
                    check = resultSet["user_pass"] == userpass;
                }
                return check;
            }
            finally
            {
                if (resultSet != null)
                { resultSet.Close(); }
                if (connection != null)
                { connection.Close(); }
            }
        }
    }
}
