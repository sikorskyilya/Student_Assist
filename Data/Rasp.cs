using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
namespace Student_Assist.Data
{
    class Rasp
    {
        private const string DB_CONNECTION_NAME = "DefaultDB";
        public static string LoadConnectionString(string id = DB_CONNECTION_NAME) => ConfigurationManager.ConnectionStrings[id].ConnectionString;
        public string Day { get; set; }
        public string Time { get; set; }
        public string Place { get; set; }
        public string Subject { get; set; }
        public string Type { get; set; }
        public string Teacher { get; set; }
        public bool BODelivered { get; set; }
        public Rasp() { }
        public Rasp(string _day, string _time, string _place, string _subject, string _type, string _teacher)
        {
            this.Day = _day;
            this.Time = _time;
            this.Place = _place;
            this.Subject = _subject;
            this.Type = _type;
            this.Teacher = _teacher;
        }
        public static Rasp[] GetDataRas()
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Rasp>($"Select * from Rasp Where UserID = '2';").ToArray();
                return output;
            }
        }
    }
}
