using System;

namespace returverdiOppg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lag en konsoll app med to metoder. En metode skal returnere summen av to tall,
            //og en metode skal skrive setningen "Denne metoden returnerer ingenting" til konsollen. Kall på metodene fra main-metoden.
            Console.WriteLine( sum(3, 4));
            Console.WriteLine(nothing());
        }
        static int sum(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
        static string nothing()
        {
            string a = "Denne metoden returnerer ingenting";
            return a;
        }
    }
}
