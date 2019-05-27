using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
namespace Student_Assist.ViewModel
{
    class Progress
    {
        private const string DB_CONNECTION_NAME = "DefaultDB";
        public static string LoadConnectionString(string id = DB_CONNECTION_NAME) => ConfigurationManager.ConnectionStrings[id].ConnectionString;
        public ObservableCollection<Data.Progr> Data { get; set; }
        public Progress(string _userid) {
            ViewModelProgr(_userid);
        }
        public Progress() {}
        public void ViewModelProgr(string _userid)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Data.Progr>($"Select * from Progress Where UserID = '{_userid}';").ToArray();
                Data = new ObservableCollection<Data.Progr>();
                for(int i =0; i< output.Count(); i++)
                {
                    Data.Add(output.ElementAt(i));
                }
             }
        }
        
        public string AddPr(string UserID, int Count, string Name)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (connection.Query<Data.Rasp>($"Select * from Progress Where Name = '{Name}' AND UserId = '{UserID}';").Count() != 0)
                {
                    return "Have";   
                }
                if (connection.Query<Data.Rasp>($"Select * from Progress Where Name = '{Name}'AND UserId = '{UserID}' ;").Count() == 0 && connection.Query<Data.Rasp>($"Select * from Progress Where UserId = '{UserID}';").Count() <= 8)
                {
                    connection.Query<Data.Rasp>($"Insert into Progress(UserID, Count, Name) Values ('{UserID}', '{Count}', '{Name}');");
                    return "Ok";
                }
                else return "Limit";
            }
        }
        public string EditPr(string UserID, int Count, string OldName, string NewName)
        {            
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (connection.Query<Data.Rasp>($"Select * From Progress Where Name = '{OldName}' AND UserId = '{UserID}';").Count() == 0)
                {
                    return "NoSuch";
                }
                if (connection.Query<Data.Rasp>($"Select * From Progress Where Name = '{NewName}' AND UserId = '{UserID}';").Count() != 0)
                {
                    return "HaveSuch";
                }
               connection.Query<Data.Rasp>($"UPDATE Progress Set Name='{NewName}', Count = '{Count}'  WHERE UserId = '{UserID}' AND Name = '{OldName}'");                                 
                return "Ok";
            }
        }
        public string Del(string UserId, string DelName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (connection.Query<Data.Rasp>($"Select * From Progress Where Name = '{DelName}' AND UserId = '{UserId}';").Count() == 0)
                    return "HaveNo";
                else
                {
                    connection.Query<Data.Rasp>($"Delete from Progress Where Name = '{DelName}' AND UserId = '{UserId}'; ");
                    return "Ok";
                }
            }
        }
    }
}


