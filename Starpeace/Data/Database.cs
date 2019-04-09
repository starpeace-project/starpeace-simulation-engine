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

        public object GetWorldSettings()
        {
            /**
             * This is a loader function used on engine startup and then at intervals
             * to ensure we are reflecting changes in the worlds setup for example
             * adjustments made as we test etc.
             */

            return new object();
        }
    }
}
