using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLitte1
{
    public class SQLiteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var result = con.Query<PersonModel>("select * from Person", new DynamicParameters());
                return result.ToList();
            }
        }

        public static void SavePerson(PersonModel person) 
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("insert into person (Fistname, Lastname) values (@FirstName, @LastName)", person);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
