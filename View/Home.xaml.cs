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

namespace Student_Assist.View
{
    public partial class Home : UserControl
    {
        string UserID;
        public Home(string _userId)
        {
            InitializeComponent();
            UserID = _userId;
            Loaded += Info_Loader;
            
        }
        public void Info_Loader(object sender, RoutedEventArgs e)
        {

            ViewModel.HomeView homeView = new ViewModel.HomeView(UserID);
            DataContext = homeView;
            GetInfo();
        }
        private void Person_Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Person_Surname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void GetInfo()
        {
            ViewModel.HomeView homeView = new ViewModel.HomeView();
            Person_FullName.Text = (homeView.UserName(UserID, Person_Name.Text, Person_Surname.Text) + " " + homeView.UserSurname(UserID, Person_Name.Text, Person_Surname.Text)).ToString();
            Person_Name.Text = homeView.UserName(UserID, Person_Name.Text, Person_Surname.Text);
            Person_Surname.Text = homeView.UserSurname(UserID, Person_Name.Text, Person_Surname.Text);
        }
        private void SaveInfo(object sender, RoutedEventArgs e)
        {
            ViewModel.HomeView homeView = new ViewModel.HomeView();
            homeView.SaveInfo(UserID, Person_Name.Text, Person_Surname.Text);
            GetInfo();
        }
    }
}
