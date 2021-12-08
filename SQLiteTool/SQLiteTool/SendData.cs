using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTool
{
    public class SendData
    {
        public static void Entry()
        {
            Console.Clear();
            Database db = new();
            SQLiteCommand cmd = new(db.sqlConnect);
            db.OpenConnection();
            var data = Console.ReadLine();
            
            cmd.CommandText = $"INSERT INTO posts (Content) Values('{data}')";
            var result = cmd.ExecuteNonQuery();
            Console.WriteLine($"{result} entry added.\n");
            db.CloseConnection();
        }
    }
}
