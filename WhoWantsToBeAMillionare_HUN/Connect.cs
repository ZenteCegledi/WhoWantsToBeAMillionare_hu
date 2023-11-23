using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionare_HUN
{
    static class Connect
    {
        internal static MySqlConnection conn;
        public static void initDB()
        {
            // Csatlakozás
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "mypass";
            builder.Database = "loim";

            conn = new MySqlConnection(builder.ToString());
        }
    }
}
