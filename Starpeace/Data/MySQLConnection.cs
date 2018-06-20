namespace Starpeace.Data
{
    public class MySQLConnection
    {
        readonly string server_host;
        readonly string database_name;
        readonly string database_username;
        readonly string database_password;

        public MySQLConnection(string server = null, string 
                               db_name = null, string db_username = null, 
                               string db_password = "")
        {
            server_host = server;
            database_name = db_name;
            database_username = db_username;
            database_password = db_password;
        }

        public string ConnectionString()
        {
            return "Data Source=" + server_host + ";Database=" + 
                database_name + ";User Id=" + database_username + ";Password=" + 
                database_password + ";";
        }
    }
}
