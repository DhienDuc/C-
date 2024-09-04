using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;

namespace SQLite
{
    internal class AccessSQLiteDB
    {
        public static List<PersonModel> LoadPersonn()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = con.Query<PersonModel>("select * from person", new DynamicParameters());
                return result.ToList();
            }
        }
        public static void InsertPerson(PersonModel person)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into person(name,family) values(@Name,@Family)", person);
            }
        }
        private static string LoadConnectionString(string id = "person")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
    
}
