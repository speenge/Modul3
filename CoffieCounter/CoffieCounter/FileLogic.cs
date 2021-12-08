using System;
using System.IO;

namespace CoffieCounter
{
    class FileLogic : FileHandler
    {
        public static void AFile()
        {
            if (!File.Exists(Location[0])) return;
                var logCount = File.ReadAllLines(WriteLocation);
                var lastEntry = logCount[^1];
                var splitEntry = lastEntry.TrimStart().Replace("\t", " ").Split(" ");
                var lastAmount = splitEntry[^1];
                var timeEntry = splitEntry[0];
                DateFileLogic(lastAmount, timeEntry);
        }

        private static void DateFileLogic(string lastAmount, string timeEntry)
        {
            if (timeEntry == Now.ToString("MM/d/yyyy") && int.TryParse(lastAmount, out var amount))
            {
                File.AppendAllText(WriteLocation, $"\n {Now}\tCups: {Convert.ToString(amount + 1)}");
            }
            else
            {
                File.AppendAllText(WriteLocation, $"\n {Now}\tCups: 1");
            }
        }
    }
}
