using System;

namespace CoffieDispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Current balance" + MoneyHandler.GetBalance());
                Console.WriteLine("\"I\" to insert money");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "I" or "i":
                        MoneyHandler.Insert();
                        break;
                    case "R" or "r":
                        MoneyHandler.ReturnBalanse();
                        break;
                    case "Q" or "q":
                        return;
                }
            }
        }
    }
}
