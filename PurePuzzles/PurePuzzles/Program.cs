using System;

namespace PurePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.Write(mark(i)+nl());
            }

            Console.Write(nl());

            for (int i = 0; i < 5; i++)
            {
                Console.Write(mark(5)+nl());
            }

            Console.Write(nl());
            
            for (int i = 0; i < 8; i++){
                int a = i * i -2;
                Console.Write(mark(a) + nl());
                
            }
            

        }
        static string mark(int val)
        {
            string RetString = "";
            char mark = '#';
            for (int i = 0; i < val; i++)
            {
                RetString += mark;
            }
            return RetString;
        }
        static string nl()
        {
            return "\n";
        }
    }
}
