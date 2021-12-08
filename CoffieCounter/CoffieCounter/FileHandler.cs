using System;
using System.IO;

namespace CoffieCounter
{
    class FileHandler
    {
        protected static string[] Location;
        protected static string WriteLocation;
        protected static readonly DateTime Now = DateTime.Now;

        public FileHandler()
        {
            Location = File.ReadAllLines("./config.txt");
            WriteLocation = Location[0];
        }
        public static void NoFile()
        {
            if (File.Exists(Location[0])) return;
            File.AppendAllText(WriteLocation, $" {Now}\tCups: 1");
        }

    }
}