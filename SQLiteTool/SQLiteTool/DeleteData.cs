using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTool
{
    class DeleteData
    {
        public static void Delete()
        {
            Console.Clear();
            Console.WriteLine("Delete entry by Id");
            Database db = new();
            SQLiteCommand cmd = new(db.sqlConnect);
            db.OpenConnection();
            int number;
            string amount = Console.ReadLine();
            if (Int32.TryParse(amount, out number))
            {
                cmd.CommandText = $"DELETE FROM posts WHERE Id = {number}";
                cmd.ExecuteNonQuery();
                Console.WriteLine("removed entry with Id " + number);
                db.CloseConnection();
            }
            else Console.WriteLine("Something went wrong :/");
        }
    }
}
