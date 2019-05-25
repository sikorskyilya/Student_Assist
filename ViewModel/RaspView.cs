using Student_Assist.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
namespace Student_Assist.ViewModel
{
    class RaspView : DependencyObject
    {
        private const string DB_CONNECTION_NAME = "DefaultDB";
        public static string LoadConnectionString(string id = DB_CONNECTION_NAME) => ConfigurationManager.ConnectionStrings[id].ConnectionString;
        public static string AddR(string _userId, string _day, string _time, string _subject, string _place, string _type, string _teacher, string _exam)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<Rasp>($"Select * from Rasp Where UserID = '{_userId}' And Day = '{_day}' And Time = '{_time}' And Subject = '{_subject}' And Place = '{_place}' And Type = '{_type}' And Teacher = '{_teacher}';").ToArray();
                if (output.Count() == 0 )
                {
                    connection.Query<Rasp>($"Insert into Rasp(UserID, Day, Time, Subject, Place, Type, Teacher, Exam) Values ('{_userId}', '{_day}', '{_time}', '{_subject}', '{_place}', '{_type}', '{_teacher}', '{_exam}');").ToArray();
                    return "Ok";
                }
                else
                return "No";
            }
        }
        public static void DeleteR(string _userId, string _day, string _time, string _subject, string _place, string _type, string _teacher)
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Query<Rasp>($"Delete from Rasp Where UserID = '{_userId}' And Day = '{_day}' And Time = '{_time}' And Subject = '{_subject}' And Place = '{_place}' And Type = '{_type}' And Teacher = '{_teacher}';").ToArray();
            }
        }
        public string FilterRasp
        {
            get { return (string)GetValue(FilterRaspProperty); }
            set { SetValue(FilterRaspProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterRasp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterRaspProperty =
             DependencyProperty.Register("FilterRasp", typeof(string), typeof(RaspView), new PropertyMetadata("", FilterRasp_Changed));

        private static void FilterRasp_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as RaspView;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterPasp;
            }
        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(RaspView), new PropertyMetadata(null));
        public RaspView(string _userid)
        {
            Items = CollectionViewSource.GetDefaultView(Rasp.GetDataRas(_userid));
            Items.Filter = FilterPasp;
        }
        private bool FilterPasp(object obj)
        {
            bool result = true;
            Rasp dataRas = obj as Rasp;
            if (!string.IsNullOrWhiteSpace(FilterRasp) && !dataRas.Place.Contains(FilterRasp) && dataRas != null && !dataRas.Day.Contains(FilterRasp) && !dataRas.Teacher.Contains(FilterRasp) && !dataRas.Time.Contains(FilterRasp) && !dataRas.Subject.Contains(FilterRasp) && !dataRas.Type.Contains(FilterRasp))
            {
                return false;
            }
            return result;
        }
    }
}
