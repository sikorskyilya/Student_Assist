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
    /// <summary>
    /// Логика взаимодействия для Rasp.xaml
    /// </summary>
    public partial class Rasp : UserControl
    {
        string UserID;
        public Rasp(string _userID)
        {
            UserID = _userID;
            InitializeComponent();
            Loaded += Rasp_Loader;
            lol2.Children.Add(new AddRasp(UserID));
        }
        public Rasp() { }
        private void Rasp_Loader(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModel.RaspView(UserID);
        }
        public void AddRasp(object sender, RoutedEventArgs e)
        {
            lol2.Children.Clear();
            lol2.Children.Add(new AddRasp(UserID));
        }
        public void DeleteRasp(object sender, RoutedEventArgs e)
        {
            lol2.Children.Clear();
            lol2.Children.Add(new DeleteRasp(UserID));
        }
        public void RefresheRasp(object sender, RoutedEventArgs e)
        {
            Rasp_Loader(sender, e);
        }


    }
}
