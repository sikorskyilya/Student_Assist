using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Configuration;
using Dapper;
namespace Student_Assist.View
{
    public partial class TextBook : UserControl
    {
        private const string DB_CONNECTION_NAME = "DefaultDB";
        public static string LoadConnectionString(string id = DB_CONNECTION_NAME) => ConfigurationManager.ConnectionStrings[id].ConnectionString;
        public string UserId;
        public TextBook(string _userid)
        {
            InitializeComponent();
            L1.AppendText(ViewModel.TextBookViewModel.UserText(_userid, 1));
            L2.AppendText(ViewModel.TextBookViewModel.UserText(_userid, 2));
            LK.AppendText(ViewModel.TextBookViewModel.UserText(_userid, 3));
            PractZ.AppendText(ViewModel.TextBookViewModel.UserText(_userid, 4));
            CourcePr.AppendText(ViewModel.TextBookViewModel.UserText(_userid, 5));
            Import.AppendText(ViewModel.TextBookViewModel.UserText(_userid, 6));
            UserId = _userid;
        }
        public void SaveText(string _userid)
        {
          // ViewModel.TextBookViewModel.SaveText(_userid, new TextRange(L1.Document.ContentStart, L1.Document.ContentEnd).Text,  )
        }
        private void SaveAll(object sender, RoutedEventArgs e)
        {
            ViewModel.TextBookViewModel.SaveText(UserId, new TextRange(L1.Document.ContentStart, L1.Document.ContentEnd).Text,
                new TextRange(L2.Document.ContentStart, L2.Document.ContentEnd).Text, new TextRange(LK.Document.ContentStart, LK.Document.ContentEnd).Text,
                new TextRange(PractZ.Document.ContentStart, PractZ.Document.ContentEnd).Text, new TextRange(CourcePr.Document.ContentStart, CourcePr.Document.ContentEnd).Text,
                new TextRange(Import.Document.ContentStart, Import.Document.ContentEnd).Text);
        }
    }
}
