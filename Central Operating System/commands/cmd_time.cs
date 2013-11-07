using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Operating_System.commands
{
    class cmd_time : command
    {
        public void Execute(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Current time: {0}", date.TimeOfDay);
        }
    }
}
