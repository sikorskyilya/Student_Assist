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
        //public ObservableCollection<MyData> Data { get; set; }

        //public MyViewModel()
        //{
        //    Data = new ObservableCollection<MyData>
        //    {
        //        new MyData {Name="Country 1", Count = 10 },
        //        new MyData {Name="Country 2", Count = 25 },
        //        new MyData {Name="Country 3", Count = 40 },
        //    };
        //}
        private const string DB_CONNECTION_NAME = "DefaultDB";
        public static string LoadConnectionString(string id = DB_CONNECTION_NAME) => ConfigurationManager.ConnectionStrings[id].ConnectionString;
        public ObservableCollection<Data.Progr> Data { get; set; }
        public Progress(string _userid) {
            ViewModelProgr(_userid);
        }
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
    }
}


