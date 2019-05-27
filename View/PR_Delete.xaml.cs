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
    /// Логика взаимодействия для PR_Delete.xaml
    /// </summary>
    public partial class PR_Delete : Window
    {
        string UserID;
        public PR_Delete(string _userid)
        {
            UserID = _userid;
            InitializeComponent();
        }
        private void Left_Mouse(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Del(object sender, RoutedEventArgs e)
        {
            if (NameDel.Text == "")
                MessageBox.Show("Введите имя дял удаления");
            ViewModel.Progress progress = new ViewModel.Progress();
            if (progress.Del(UserID, NameDel.Text) == "HaveNo")
                MessageBox.Show("Такая запись не существует");
            this.Close();

        }
    }
}
