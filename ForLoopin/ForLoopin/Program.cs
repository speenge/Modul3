using System;

namespace ForLoopin
{
    class Program
    {
        private static string _space = " ";
        private static string _X = "X";

        static void Main(string[] args)
        {
            
            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Console.Write(_space);
                    if (i == j) j = 10;
                }
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(_X);
                    if (i == j) j = 5;
                }
                Console.Write("\n");
            }
        }
    }
}
