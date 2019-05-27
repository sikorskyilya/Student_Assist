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
            if (ViewModel.UserAccess.CheckSaveAcc() != "")
            {
                MainMenu mainMenu = new MainMenu(ViewModel.UserAccess.CheckSaveAcc());
                mainMenu.Show();
                this.Close();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) => DragMove();
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
        private void Login(object sender, RoutedEventArgs e)
        {
            if(ViewModel.UserAccess.CheckUser(UserLogin.Text, UserPass.Password) != "No" && ViewModel.UserAccess.CheckUser(UserLogin.Text, UserPass.Password) != null)
            {
                MainMenu mainMenu = new MainMenu(ViewModel.UserAccess.CheckUser(UserLogin.Text, UserPass.Password));
                mainMenu.Show();
                ViewModel.UserAccess.DelSaceAcc();
                if (RememberAcc.IsChecked.Value)
                {
                    
                    ViewModel.UserAccess.SaceAcc(UserLogin.Text, UserPass.Password);
                }  
                this.Close();
            }
            else
            {
                DontTrue.Visibility = Visibility;
            }
        }
        private void Regist(object sender, RoutedEventArgs e)
        {
            DontTrue.Visibility = Visibility.Collapsed;
            HaveAc.Visibility = Visibility.Collapsed;
            PassError.Visibility = Visibility.Collapsed;
            if (UserPass.Password != UserPass2.Password)
            {
                PassError.Visibility = Visibility;
            }
            else
            {
                if (UserLogin.Text.Length != 0 && UserPass.Password.Length != 0)
                {
                    if (ViewModel.UserAccess.Registration(UserLogin.Text, UserPass.Password) != "Error")
                    {
                        MainMenu mainMenu = new MainMenu(ViewModel.UserAccess.CheckUser(UserLogin.Text, UserPass.Password));
                        ViewModel.UserAccess.DelSaceAcc();
                        if (RememberAcc.IsChecked.Value)
                        {
                            ViewModel.UserAccess.SaceAcc(UserLogin.Text, UserPass.Password);
                        }
                        mainMenu.Show();
                        this.Close();
                    }
                    else
                    {
                        HaveAc.Visibility = Visibility;
                    }
                }
            }
        }
        private void Quit(object sender, RoutedEventArgs e) => this.Close();
        private void Minimize(object sender, RoutedEventArgs e) => SystemCommands.MinimizeWindow(this);
        private void Open_vk(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start("https://vk.com/id170130092"); 
        private void Open_linkedin(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start("https://www.linkedin.com/in/sikoskyil/");
        private void Open_telegram(object sender, RoutedEventArgs e) => System.Diagnostics.Process.Start("https://t.me/nightyy256");
    }
}
