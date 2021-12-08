using System;

namespace PrintArgsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var Argument in args)
            {
                Console.Write(Argument + " ");
            }
        }
    }
}
