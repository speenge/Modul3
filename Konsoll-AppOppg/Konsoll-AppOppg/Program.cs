using System;

namespace Konsoll_AppOppg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hva heter du?");
            string input = Console.ReadLine();
            Console.WriteLine($"Velkommen {input}");
            Console.ReadLine();
        }
    }
}
