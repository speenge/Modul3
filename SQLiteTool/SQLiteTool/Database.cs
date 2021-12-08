using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Numerics;

namespace SQLiteTool
{
    class Program
    {

        static void Main()
        {
            var input = new Input();
            Console.WriteLine(input.HelpText);
            while (!input.HandleInput()) input.HandleInput(); 
            //_ = new SendData();
            
        }
    }
}
