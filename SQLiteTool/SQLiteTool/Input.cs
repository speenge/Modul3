using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTool
{
    public class Input
    {
        public string HelpText = @"ctrl + Q -> quits
E -> make new entry
R -> read entries
H -> help"; 
        public bool HandleInput()
        {
            var UserInput = Console.ReadKey();
            if (UserInput.Key == ConsoleKey.Q && (UserInput.Modifiers & ConsoleModifiers.Control) != 0) return true;
            if (UserInput.Key == ConsoleKey.E) { SendData.Entry(); }
            if (UserInput.Key == ConsoleKey.R) { ReadData.Entry(); }
            if (UserInput.Key == ConsoleKey.H) { Console.WriteLine(HelpText); }
            if (UserInput.Key == ConsoleKey.D) { DeleteData.Delete(); }


            return false;
        }
    }
}
