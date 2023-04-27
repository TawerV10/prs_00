using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prs_00
{
    class DB
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "DESKTOP-02UI208";
            int port = 3306;
            string database = "own_shcema";
            string username = "tawer";
            string pass = "@";

            return DBMySQL.GetDBConnection(host, port, database, username, pass);
        }
    }
}
