using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffieDispenser
{
    class MoneyHandler
    {
        private static int _Currency;

        public static void Insert()
        {
            int.TryParse(Console.ReadLine(), out int res);
           switch (res)
            {
                case 1:
                case 5:
                case 10:
                case 20:
                    _Currency += res;
                    break;
                default:
                    Console.WriteLine("Valid options are \"1 ,5, 10 or 20\"");
                    break;

            }
        }

        public static int GetBalance()
        {
            return _Currency;
        }

        public static void ReturnBalanse()
        {
            Console.WriteLine($"Returned {_Currency}kr");
            _Currency = 0;
        }
    }
}
