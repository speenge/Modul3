using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IndexFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string  str= "test string of testings";
            var index = 0;
            var WordLength = str.Length;

            List<int> a = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                    var tmp = str[i];
                if (tmp == ' ')
                {
                    a.Add(i);
                }
            }

            List<int> wcount = new List<int>();
            foreach (var b in a)
            {
                wcount.Add(b - index);
                index = b + 1;
            }
            wcount.Add(WordLength - index);
            Console.WriteLine(WordLength);
            foreach (var sa in wcount)
            {
                Console.WriteLine(sa);
            }
        }
    }
}
