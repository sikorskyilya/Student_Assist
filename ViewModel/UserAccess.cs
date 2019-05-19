using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
namespace Student_Assist.ViewModel
{
    class UserAccess
    {
        private const string DB_CONNECTION_NAME = "DefaultDB";
        public static string LoadConnectionString(string id = DB_CONNECTION_NAME) => ConfigurationManager.ConnectionStrings[id].ConnectionString;
        public static string CheckUser(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Data.User>($"SELECT Id FROM UserAcc WHERE UserName = '{username}' AND UserPass = '{password}';");
                if (output.Count() == 1)
                {
                    return output.ElementAt(0).Id.ToString();
                }
                else
                    return "No";
            }

        }
        public static string Registration(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Data.User>($"Select * From UserAcc Where UserName = '{username}';");
                if (output.Count() == 0)
                {
                    connection.Query<Data.User>($"Insert into UserAcc(UserName, UserPass) Values ('{username}', '{password}');");
                    output = connection.Query<Data.User>($"Select * From UserAcc Where UserName = '{username}';");
                    return output.ElementAt(0).Id.ToString();
                }
                else
                {
                    return "Error";
                }
            }
        }
        public static void SaceAcc(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Query<Data.User>($"UPDATE UserAcc SET SaveAcc = 1 WHERE UserName = '{username}' AND UserPass = '{password}';");
            }
        }
        public static void DelSaceAcc()
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Query<Data.User>($"UPDATE UserAcc SET SaveAcc = 0 WHERE Id;");
            }
        }
        public static string CheckSaveAcc()
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Data.User>($"SELECT Id FROM UserAcc WHERE SaveAcc = 1;");
                if (output.Count() == 1)
                {
                    return output.ElementAt(0).Id.ToString();
                }
                else return "";
                
            }
            
        }
    }
    
}
