using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
using System.Collections.ObjectModel;

namespace Student_Assist.ViewModel
{
    class HomeView
    {
        private const string DB_CONNECTION_NAME = "DefaultDB";
        public static string LoadConnectionString(string id = DB_CONNECTION_NAME) => ConfigurationManager.ConnectionStrings[id].ConnectionString;
        public ObservableCollection<Data.HomeDiagramm> PersonalData { get; set; }
        public HomeView(string _userid)
        {
            int result = 0;
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<string>($"Select Count from Progress Where UserID = '{_userid}';");
                if (output.Count() != 0)
                {
                    for (int i = 0; i < output.Count(); i++)
                        result += Int32.Parse(output.ElementAt(i).ToString());
                    result = result / output.Count();
                }
            }
            
            DateTime date1 = DateTime.Today;
            DateTime date2 = new DateTime(DateTime.Today.Year, 6, 14);
            PersonalData = new ObservableCollection<Data.HomeDiagramm>
            {
            new Data.HomeDiagramm {Name="До окончания семестра", Count = ((124 - date2.Subtract(date1).Days) * 100) /124 },
            new Data.HomeDiagramm {Name="Общий прогресс", Count = result },
            };
        }
        public HomeView() { }
        public string UserName(string _userid, string name, string surname)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<string>($"Select UserName from UserInfo Where UserID = '{_userid}';");
                if (output.Count() == 0)
                {
                    return "";
                }
                return output.ElementAt(0).ToString();
            }
        }
        public string UserSurname(string _userid, string name, string surname)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<string>($"Select UserSurname from UserInfo Where UserID = '{_userid}';");
                if (output.Count() == 0)
                {
                    return "";
                }
                return output.ElementAt(0).ToString();
            }
        }
        public string SaveInfo (string _userid, string name, string surname)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<string>($"Select * from UserInfo Where UserID = '{_userid}';");
                if (output.Count() == 0)
                {
                    connection.Query<string>($"Insert into UserInfo(UserID, UserName, UserSurname) Value('{_userid}', '{name}', '{surname}');");
                    return "ok";
                }
                else
                {
                    connection.Query<string>($"Update UserInfo SET UserName = '{name}', UserSurname = '{surname}' WHERE UserID = '{_userid}'; ");
                    return "ok";
                }
            }
        }
    }
}
