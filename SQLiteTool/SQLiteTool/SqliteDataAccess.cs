using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SQLiteTool
{
    public class Database
    {
        public SQLiteConnection sqlConnect;
        public Database()
        {
            sqlConnect = new SQLiteConnection("Data Source=./database/test.db");
            if (!File.Exists("./database/test.db"))
            {
                SQLiteConnection.CreateFile("C:/Users/Ad/source/repos/SQLiteTool/SQLiteTool/bin/Debug/net5.0/database/test.db");
            }
            
            // C:\Users\Ad\source\repos\SQLiteTool\SQLiteTool
        }
        public void OpenConnection()
        {
            if (sqlConnect.State != System.Data.ConnectionState.Open)
            {
                sqlConnect.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnect.State != System.Data.ConnectionState.Closed)
            {
                sqlConnect.Close();
            } 
        }
    }
}
