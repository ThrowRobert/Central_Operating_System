using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Central_Operating_System
{
    class mysql
    {
        public static void consql()
        {
            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("Server=" + mysql_connect_info.serverurl + "; Database=" + mysql_connect_info.db + "; Uid=" + mysql_connect_info.username + "; Pwd=" + mysql_connect_info.password + ";");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user;", con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Username: {1}, Birthyear: {2}, Registered: {3}", reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3));
            }
            Console.ReadKey();
        }
    }
}
