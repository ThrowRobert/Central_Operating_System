using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Operating_System.commands
{
    class help : command
    {
        public void Execute(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Commands in CtOS:");

            Console.WriteLine(" HELP =Shows all the commands.");
            Console.WriteLine(" TIME =Shows current time.");
            Console.WriteLine(" USER =Show users in the database.");
            Console.WriteLine(" CLS =Erase all data from display.");
            Console.WriteLine(" NEW USER =Guide you a new user.");
            Console.WriteLine(" LOG ON =Log on CtOS admin panel.");

            Console.WriteLine(" NOTEPAD =Enter notepad mod.");
            Console.WriteLine(" EXITT =Exit notepad mod.");
        }
    }
}
