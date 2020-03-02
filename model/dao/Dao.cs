using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace ExpenseManager.model.dao
{
    class Dao
    {
        private const string _connStr = "" +
            "server=localhost;" +
            "user=root;" +
            "database=expense_manager;" +
            "port=3306;" +
            "password=#cRIaeC&Q&i6kt!$O6Cp";
        public MySqlConnection conn = null;
        private static Dao _singleton;
        public static Dao GetDao()
        {
            if (_singleton == null)
            {
                _singleton = new Dao();
            }
            return _singleton;
        }
        private Dao()
        {
            try
            {
                this.conn = new MySqlConnection(_connStr);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
