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
        /// <summary>
        /// Dictionary for keeping track of registered commands
        /// </summary>
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
            }
        }

        ///TODO:
		///MOVE ALL THIS STUFF TO COMMAND CLASSES
		
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

        /// <summary>
        /// Initialize stuff here
        /// </summary>
        private static void Init()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            LoadCommands();
        }

		///<summary>Load all commands</summary>
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
