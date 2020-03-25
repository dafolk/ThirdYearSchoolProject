using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

using ExpenseManager.model.dao;

namespace ExpenseManager.model.service
{
    class UserService : IUserService
    {
        Dao dao = Dao.GetDao();
        MySqlCommand cmd;
        MySqlDataReader dataReader;
        private string query;

        public User GetUserByUsername(string username)
        {
            this.dao.conn.Open();

            query = "SELECT * FROM user WHERE username = @username;";

            cmd = new MySqlCommand(query, this.dao.conn);
            cmd.Parameters.AddWithValue("username", username);

            dataReader = cmd.ExecuteReader();

            User user = null;

            while (dataReader.Read())
            {
                user = new User(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2));
            }

            this.dao.conn.Close();

            return user;
        } 
    }
}
