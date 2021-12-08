using System;
using System.Data.SQLite;

namespace SQLiteTool
{
    internal class ReadData
    {
        internal static void Entry()
        {
            Console.Clear();
            Console.WriteLine("Read x rows from posts");
            Console.WriteLine("Leave blank for all");
            Database db = new();
            db.OpenConnection();
            int number;
            string amount = Console.ReadLine();
            if (Int32.TryParse(amount, out number))
            {
                var stm = $"SELECT * FROM posts LIMIT {number}";
                Read(stm, db);
            }
            else
            {
                var stm = $"SELECT * FROM posts";
                Read(stm,db);
            }
        }

        internal static void Read(string stm, Database db)
        {
            SQLiteCommand cmd = new(stm, db.sqlConnect);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)}");
            }
        }

    }
}