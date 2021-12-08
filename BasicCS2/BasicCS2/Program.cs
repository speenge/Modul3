using System;

namespace BasicCS2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTextAndShowCharCounts(250);
        }

        private static int[] CountChars(string text, int range)
        {
            var counts = new int[range];
            //int[] counts2 = new int[]{1,2,3,4,5,6,7,8,9}  -   Sett startverdiene manuelt
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
            }
            return counts;
        }

        private static void ShowCounts(int range, int[] counts)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] == 0) continue;
                var character = (char)i;
                Console.WriteLine("\"" + character + "\" - " + counts[i]);
            }
        }
        private static void ReadTextAndShowCharCounts(int range)
        {
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                var counts = CountChars(text, range);
                ShowCounts(range, counts);
            }
        }
    }
}
