﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Operating_System.commands
{
    class info : command
    {
        public void Execute(string[] args)
        {
            Program.WriteCopyright();
        }
    }
}
