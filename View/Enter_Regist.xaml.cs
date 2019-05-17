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
    /// <summary>
    /// Логика взаимодействия для Enter_Regist.xaml
    /// </summary>
    public partial class Enter_Regist : Window
    {
        public Enter_Regist()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        DragMove();
        }
        private void HaveAcc(object sender, RoutedEventArgs e)
        {
            BRegist.Visibility = Visibility.Collapsed;
            Check_Pass.Visibility = Visibility.Collapsed;
            HaveAccount.Visibility = Visibility.Collapsed;
            BLogin.Visibility = Visibility;
        }
        private void Open_Regist(object sender, RoutedEventArgs e)
        {
            BRegist.Visibility = Visibility;
            Check_Pass.Visibility = Visibility;
            HaveAccount.Visibility = Visibility;
            BLogin.Visibility = Visibility.Collapsed;
        }
        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Minimize(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
        private void Open_vk(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id170130092");
        }
        private void Open_linkedin(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/sikoskyil/");
        }
        private void Open_telegram(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/nightyy256");
        }
        
    }
}
