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
using System.Windows.Shapes;

namespace Student_Assist.View
{
    public partial class MainMenu : Window
    {
        string UserID;
        public MainMenu(string _UserID)
        {
            InitializeComponent();
            UserID = _UserID;
            ViewModel.Progress progress = new ViewModel.Progress(UserID);
            DataContext = progress;
            MainStack.Children.Add(new Home(UserID));
        }

        private void Notes_open(object sender, RoutedEventArgs e)
        {
            MainStack.Children.Clear();
            MainStack.Children.Add(new TextBook(UserID));
        }
        private void Progress_open(object sender, RoutedEventArgs e) 
        {
            MainStack.Children.Clear();
            MainStack.Children.Add(new Progresss(UserID));
        }
        private void Timetable_open(object sender, RoutedEventArgs e)
        {
            MainStack.Children.Clear();
            MainStack.Children.Add(new Rasp(UserID));
        }
        private void logout(object sender, RoutedEventArgs e)
        {
            ViewModel.UserAccess.DelSaceAcc();      
            Enter_Regist enter_Regist = new Enter_Regist();
            enter_Regist.Show();
            this.Close();
        }
        private void Left_Mouse(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void Quit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            MainStack.Children.Clear();
            MainStack.Children.Add(new Home(UserID));

        }
    }
}
