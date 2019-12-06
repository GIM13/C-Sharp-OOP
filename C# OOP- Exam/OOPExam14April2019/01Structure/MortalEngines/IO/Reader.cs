using MortalEngines.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MortalEngines.IO
{
    public class Reader : IReader
    {
        public IList<ICommand> Commands { get; set; }

        public void ReadCommands(string command) 
        { 

        }
    }
}
