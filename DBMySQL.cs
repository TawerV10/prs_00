using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prs_00
{
    class DBMySQL
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            string connectionString = $"server={host};user={username};database={database};password={password};";
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
