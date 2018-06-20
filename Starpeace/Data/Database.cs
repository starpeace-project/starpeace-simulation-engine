using System;
using System.Collections.Generic;
using Starpeace.Data;
using Starpeace.Data.Models;
using Insight.Database;
using MySql.Data;

namespace Starpeace.Data
{
    public class Database
    {
        public MySql.Data.MySqlClient.MySqlConnection connection;

        public Database()
        {
            string connection_string = new MySQLConnection("localhost", "sptest", "root", "local").ConnectionString();
            connection = new MySql.Data.MySqlClient.MySqlConnection(connection_string);
        }

        public IList<User> GetUsers()
        {
            return connection.QuerySql<User>("SELECT * FROM user");
        }
    }
}
