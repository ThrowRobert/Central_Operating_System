using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Central_Operating_System.commands
{
    class cmd_user : command
    {

        public void Execute(string[] args)
        {
           
            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("Server=" + mysql_connect_info.serverurl + "; Database=" + mysql_connect_info.db + "; Uid=" + mysql_connect_info.username + "; Pwd=" + mysql_connect_info.password + ";");
            con.Open();//fix MySQL

            /*if (MySql.Data.MySqlClient.MySqlConnection == true)//solve later
                Console.Out.Write("Logged in...");
            else
                Console.Out.Write("ERROR: Mismatch");*/
       }
      
    }
}
