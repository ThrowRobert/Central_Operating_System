using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Central_Operating_System
{
    class Program //- Transmitting data - Application Health status... - Load Default settings...
    {
        static void Main(string[] args)
        {
            Init();
            Console.Clear();
            WriteCopyright();
            Console.WriteLine("Type help to get the list.");
            for (; true; )
            {
                string input = GetInput();
                
                if (input.Equals("help", StringComparison.InvariantCultureIgnoreCase))
                {
                    help();
                }
                //!!_Reminders_!!
                //Remember to add Log on in Help desc.
                //Make a functional log on system.
                //Make an dynamic user database.
                if (input.Equals("time", StringComparison.InvariantCultureIgnoreCase))
                {
                    time();
                }
                if (input.Equals("ers", StringComparison.InvariantCultureIgnoreCase))
                {
                    erase();
                }
                if (input.Equals("user", StringComparison.InvariantCultureIgnoreCase))
                {
                    user();
                }
                if (input.Equals("new user", StringComparison.InvariantCultureIgnoreCase))
                {
                    new_user();
                }
                if (input.Equals("log on", StringComparison.InvariantCultureIgnoreCase))
                //go find the command in command.cs
                //execute only that command no-other commands
                {
                    log_on();
                }
                if (input.Equals("notepad", StringComparison.InvariantCultureIgnoreCase))
                {
                    notepad();
                }
            }
        }

        private static void help()
        {
            Console.WriteLine("");
            Console.WriteLine("Commands in CtOS:");

            Console.WriteLine(" HELP =Shows all the commands.");
            Console.WriteLine(" TIME =Shows current time.");
            Console.WriteLine(" USR =Show users in the database.");
            Console.WriteLine(" ERS =Erase all data from display.");

            Console.WriteLine(" NOTEPAD =Enter notepad mod.");
            Console.WriteLine(" EXITT =Exit notepad mod.");
        }

        private static void log_on()
        {
            Console.Clear();
            WriteCopyright();
            Console.WriteLine("");

            string username, password, username1, password1 = string.Empty;

            Console.Write("Enter username: ");
            username = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();


            using (StreamReader sr = new StreamReader(File.Open("C:\\CtOS\\log.txt", FileMode.Open))) //Learn FileStream
            {
                username1 = sr.ReadLine();
                password1 = sr.ReadLine();
                sr.Close();
            }
            if (username == username1 && password == password1)
            {
                Console.WriteLine("Access granted!");
            }
            else
            {
                Console.WriteLine("Error, mismatch!");
            }
        }

        private static void erase()
        {
            Console.Clear();
            WriteCopyright();
            Console.WriteLine("Type help to get the list.");
        }

        private static void notepad()
        {
            Console.Clear();
            WriteCopyright();
            for (; true; )
            {
                string a = Console.ReadLine();
                if (a == "EXITT" || a == "exitt" || a == "Exitt") break;
            }
        }

        private static void new_user()
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

        private static void user()
        {
            Console.Clear();
            WriteCopyright();
            Console.WriteLine("");
            Console.WriteLine("User is CtOS - Currently log on as Guest (Permissions = N/A)");
            Console.WriteLine("");
            Console.WriteLine("- Kvamren \n- AnLa061095 \n- Jenjen1324");
        }

        private static void time()
        {
            Console.Clear();
            DateTime date = DateTime.Now;
            Console.WriteLine("{0}", date);
        }

        private static static GetInput()
        {
            Console.WriteLine("");
            Console.Write("USERNAME@CtOS:>"); //USERNAME is current login user.
            return Console.ReadLine();
        }

        private static void Init()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Security check enabled");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Load Default settings...");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Application Health status...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Application status: OK");
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Message encryption recognition active");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Operating system log on");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Integrated peripherals: Off");
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("Advanced BiOS features");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("Set Supervisor Password");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Transmitting data");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Connecting to world database...");
            System.Threading.Thread.Sleep(1000);
        }

        private static void WriteCopyright()
        {
            Console.WriteLine("Central Operating System (Northcode © 2013).");
        }
    }
}
