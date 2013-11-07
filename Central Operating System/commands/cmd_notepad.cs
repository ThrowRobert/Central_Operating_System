using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Operating_System.commands
{
    class cmd_notepad : command
    {
        public void Execute(string[] args)
        {
            Console.Clear();
            Program.WriteCopyright();
            Console.WriteLine("Type 'exitt||EXITT||Exitt' to exit Notepad mode.");
            for (; true; )
            {
                string a = Console.ReadLine();
                if (a == "EXITT" || a == "exitt" || a == "Exitt") break;
            }
        }
    }
}
