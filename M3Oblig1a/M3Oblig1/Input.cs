using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace M3Oblig1
{
    class Input
    {
        public bool input()
        {
            
            string input = Console.ReadLine().ToLower();
            string[]  input1 = input.Split(" ");
            string ainput = input1[0];
            string val = "";
            if (input1.Length > 1) {val = input1[1];}
            switch (ainput)
            {
                case "hjelp":
                    HelpTxt.HelpText();
                    break;
                case "liste":
                    Console.Clear();
                    Liste.GetList(); 
                    break;
                case "vis":
                    Console.Clear();
                    Show.show(val);
                    break;
                case "avslutt":
                case "exit":
                    return false;

                default:
                    Console.Clear();
                    Console.WriteLine("ikke eksisterende komando prøv \"hjelp\"");
                    break;
            }
            
            for (int i = 0; i < input1.Length; i++)
            {
                int indexToRemove = i;
                input.Where((source, index) => index != indexToRemove).ToArray();
            }
            return true;
        }
        
    }
}
