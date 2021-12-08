using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaa
{
    public class Textor
    {
        public string Name;
        

        public Textor(string vari)
        {
            Name = vari;
        }

        public void PrintName()
        {
            Console.WriteLine(Name);
        }

        public void PrintText()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Runde nr: " + i);
            }
        }
    }
}
