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
    class TextBookViewModel
    {
        private const string DB_CONNECTION_NAME = "DefaultDB";
        public static string LoadConnectionString(string id = DB_CONNECTION_NAME) => ConfigurationManager.ConnectionStrings[id].ConnectionString;
        public static string UserText(string UserId, int i)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<string>($"SELECT UserId From TextBook Where UserId = '{UserId}';");
                if (output.Count() == 0)
                {
                    using (SQLiteConnection connection1 = new SQLiteConnection(LoadConnectionString()))
                    {
                        var output1 = connection.Query<string>($"Insert into TextBook(UserId) Values ('{UserId}');");
                    }
                } else if (output.Count() == 1)
                        {
                    switch (i)
                    {
                        case 1:
                            {
                                output = connection.Query<string>($"SELECT ifnull(L1, 'Внесите свою первую запись') FROM TextBook Where UserId = '{UserId}';");
                                return output.ElementAt(0).ToString();
                            }
                        case 2:
                            {
                                output = connection.Query<string>($"SELECT ifnull(L2,'Внесите свою первую запись') FROM TextBook Where UserId = '{UserId}';");
                                return output.ElementAt(0).ToString();
                            }
                        case 3:
                            {
                                output = connection.Query<string>($"SELECT ifnull(LK,'Внесите свою первую запись') FROM TextBook Where UserId = '{UserId}';");
                                return output.ElementAt(0).ToString();
                            }
                        case 4:
                            {
                                output = connection.Query<string>($"SELECT ifnull(PractZ,'Внесите свою первую запись') FROM TextBook Where UserId = '{UserId}';");
                                return output.ElementAt(0).ToString();
                            }
                        case 5:
                            {
                                output = connection.Query<string>($"SELECT ifnull(CourcePr,'Внесите свою первую запись') FROM TextBook Where UserId = '{UserId}';");
                                return output.ElementAt(0).ToString();
                            }
                        case 6:
                            {
                                output = connection.Query<string>($"SELECT ifnull(Import,'Внесите свою первую запись') FROM TextBook Where UserId = '{UserId}';");
                                return output.ElementAt(0).ToString();
                            }
                    }
                }
                return "";
            }

        }
        public static void SaveText(string UserId, string L1, string L2, string LK, string PractZ, string CourcePr, string Import)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<string>($"UPDATE TextBook SET L1 = '{L1}', L2 = '{L2}',  LK = '{LK}', PractZ = '{PractZ}', CourcePr = '{CourcePr}', Import = '{Import}' WHERE UserId = '{UserId}';");
            }
        }
    }
}
