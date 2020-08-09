using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FarmaciaPikachu
{
    class DataBase
    {
        private SQLiteConnection connection { get; set; }
        private SQLiteCommand command { get; set; }

        public DataBase() 
        {
            //Tip: Your sqlite database should be located in bin/Debug or bin/Release for usage
            this.connection = new SQLiteConnection("Data Source=farmaciapikachu.db;New=False;");
            this.openConnection();
        }

        private void openConnection() { this.connection.Open(); }

        public void closeConnection() { this.connection.Close(); }

        public SQLiteDataReader executeCommand(String command)
        {
            SQLiteDataReader result = null;
            this.command = this.connection.CreateCommand();
            this.command.CommandText = command;
            try { result = this.command.ExecuteReader(); }
            catch(Exception e) { Console.WriteLine(e.StackTrace); }
            return result;
        }
    }
}
