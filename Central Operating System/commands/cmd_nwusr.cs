using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Operating_System.commands
{
    class cmd_nwusr : command
    {
        public void Execute(string[] args)
        {
            Console.Clear();
            WriteCopyright();
            Console.WriteLine("");
            Console.WriteLine("Now we create a new user");

            string username, password = string.Empty;

            Console.Write("Enter a username: ");
            username = Console.ReadLine();
            Console.Write("Enter a password: ");
            password = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(File.Create("C:\\CtOS\\log.txt")))
            {
                sw.WriteLine(username);
                sw.WriteLine(password);
                sw.Close();
            }

            Console.WriteLine("User Created...");
            Console.Read();
        }
    }
}
