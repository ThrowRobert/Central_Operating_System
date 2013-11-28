using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Central_Operating_System.commands;

namespace Central_Operating_System
{
    class Program //- Transmitting data - Application Health status... - Load Default settings...
    {
        public static Dictionary<string,command> cmds = new Dictionary<string,command>();

        static void Main(string[] args)
        {
            Init();
            Console.Clear();
            WriteCopyright();
            Console.WriteLine("Type help to get the list.");
            for (; true; )
            {
                string input = GetInput();
                string[] cmdargs = input.Split(' ');

                if (cmds.ContainsKey(cmdargs[0])) //Check if command is in command list
                {
                    cmds[cmdargs[0]].Execute(cmdargs.Skip(1).ToArray()); //Exec command
                }
                else
                {
                    Console.WriteLine("Command not recognized");
                }
                /*
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
                if (input.Equals("cls", StringComparison.InvariantCultureIgnoreCase))
                {
                    clear();
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
                */
            }
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

        private static string GetInput()
        {
            Console.WriteLine("");
            Console.Write("Username@ CtOS:>"); //USERNAME is current login user.
            return Console.ReadLine();
        }

        private static void Init()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Security check enabled");
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine("Load Default settings...");
            //System.Threading.Thread.Sleep(500);
            //Console.Clear();
            //Console.WriteLine("Application Health status...");
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine("Application status: OK");
            //System.Threading.Thread.Sleep(300);
            //Console.Clear();
            //Console.WriteLine("Message encryption recognition active");
            //System.Threading.Thread.Sleep(500);
            //Console.Clear();
            //Console.WriteLine("Operating system log on");
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine("Integrated peripherals: Off");
            //System.Threading.Thread.Sleep(200);
            //Console.WriteLine("Advanced BiOS features");
            //System.Threading.Thread.Sleep(300);
            //Console.WriteLine("Set Supervisor Password");
            //System.Threading.Thread.Sleep(500);
            //Console.Clear();
            LoadCommands();
            //Console.WriteLine("Transmitting data");
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine("Connecting to world database...");
            //System.Threading.Thread.Sleep(1000);
        }

        private static void LoadCommands()
        {
            Console.WriteLine("Loading console commands...");
            System.Threading.Thread.Sleep(1000);
            cmds.Add("help", new help());
            cmds.Add("time", new cmd_time());
            cmds.Add("cls", new cmd_clear());
            cmds.Add("info", new info());
            cmds.Add("user", new cmd_user());
            cmds.Add("new user", new cmd_nwusr());
            cmds.Add("notepad", new cmd_notepad());
        }

        public static void WriteCopyright()
        {
            Console.WriteLine("Central Operating System (Northcode © 2013).");
        }
    }
}
