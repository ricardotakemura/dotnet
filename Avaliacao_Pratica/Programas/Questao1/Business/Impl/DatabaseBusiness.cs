using System;
using System.IO;
using System.Data.Common;
using Microsoft.Data.Sqlite;

namespace Questao1.Business.Impl
{
    public class DatabaseBusiness: IDatabaseBusiness
    {
        public void CreateDatabase()
        {
            if (!File.Exists("questao1.db")) 
            {
                File.Create("questao1.db");    
            }
            using (var conn = new SqliteConnection("Data Source=questao1.db")) 
            {
                if (File.Exists("App_Data/script.sql"))
                {
                    var script = File.ReadAllText("App_Data/script.sql");
                    using (var command = conn.CreateCommand())
                    {
                        conn.Open();
                        command.CommandText = script;
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }
    }
}
