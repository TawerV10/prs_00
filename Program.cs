using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prs_00
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting");
            MySqlConnection conn = DB.GetDBConnection();

            try
            {
                Console.WriteLine("opening");
                conn.Open();
                Console.WriteLine("succsess");
                Query(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            Console.Read();
        }

        private static void Query(MySqlConnection conn)
        {
            string sql = "select * from orders";

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"OrderID:{reader["order_id"].ToString()} - OrderDate:{reader["order_date"].ToString()}");
                    }
                }
            }
        }
    }
}
