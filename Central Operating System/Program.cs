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
                if (input == "HELP" || input == "help" || input == "Help")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Commands in CtOS:");
                    Console.WriteLine(" HELP =Shows all the commands. \n TIME =Shows current time. \n USR =Show users in the database. \n ERS =Shows current users. \n NOTEPAD =Enter notepad mod. \n EXITT =Exit notepad mod.");
                }
                //!!_Reminders_!!
                //Remember to add Log on in Help desc.
                //Make a functional log on system.
                //Make an dynamic user database.
                if (input == "TIME" || input == "time" || input == "Time")
                {
                    Console.Clear();
                    DateTime date = DateTime.Now;
                        Console.WriteLine("{0}", date);
                }
                if (input == "NOTEPAD" || input == "notepad" || input == "Notepad")               
                {
                    Console.Clear();
                    for (; true; )
                    {
                        string a = Console.ReadLine();
                        if (a == "EXITT" || a == "exitt" || a == "Exitt") break;
                    }
                }
                if (input == "ERS" || input == "ers" || input == "Ers")
                {
                    Console.Clear();
                    WriteCopyright();
                    Console.WriteLine("Type help to get the list.");
                }
                if (input == "USER" || input == "user" || input == "User")
                {
                    Console.Clear();
                    WriteCopyright();
                    Console.WriteLine("");
                    Console.WriteLine("User is CtOS - Currently log on as Guest (Permissions = N/A)");
                    Console.WriteLine("");
                    Console.WriteLine("- Kvamren \n- AnLa061095 \n- Jenjen1324");
                }
                if (input == "NEW USER" || input == "new user" || input == "New User")
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

                    using (StreamWriter sw = new StreamWriter(File.Create("C:\\CtOS\\log.txt")))//FIND the error
                    {
                        sw.WriteLine(username);
                        sw.WriteLine(password);
                        sw.Close();
                    }

                    Console.WriteLine("User Created...");
                    Console.Read();

                }
                if (input.Equals("log on", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.Clear();
                    WriteCopyright();
                    Console.WriteLine("");                 
                    
                   string username, password, username1,password1 = string.Empty;

                    Console.Write("Enter username: ");
                    username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();

                    using (StreamReader sr = new StreamReader(File.Open("C:\\CtOS\\log.txt", FileMode.Open))) //FIND the error
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
                        Console.WriteLine("Invalid match!");
                    }

                }
                if (input == "Name_it_here" || input == "Name_sub_here" || input == "Name_tryn_here")
                {
                  
                }
                if (input == "Name_it_here" || input == "Name_sub_here" || input == "Name_tryn_here")
                {
                    
                }
                
            }
        }

        private static string GetInput()
        {
            Console.WriteLine("");
            Console.Write("§:>");
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
