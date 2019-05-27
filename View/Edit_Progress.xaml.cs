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
    /// Логика взаимодействия для Edit_Progress.xaml
    /// </summary>
    public partial class Edit_Progress : Window
    {
        List<int> Pr_1SS = new List<int>(Enumerable.Range(0, 1000));
        string UserID;
        public Edit_Progress(string _userid)
        {
           UserID = _userid;
           InitializeComponent();
            PR_SS.ItemsSource = Pr_1SS;
            PR_VV.ItemsSource = Pr_1SS;
        }
        private void Change(object sender, RoutedEventArgs e)
        {
            
            if ((PR_SS.Text == "" && PR_VV.Text != "" && OldName.Text != "" && NewName.Text != "") || (PR_SS.Text != "" && PR_VV.Text == "" && OldName.Text != "" && NewName.Text != "")
                || (PR_SS.Text != "" && PR_VV.Text != "" && OldName.Text == "" && NewName.Text != "") || (PR_SS.Text != "" && PR_VV.Text != "" && OldName.Text != "" && NewName.Text == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                ViewModel.Progress progress = new ViewModel.Progress();
                string result = progress.EditPr(UserID, Int32.Parse(PR_SS.Text) * 100 / Int32.Parse(PR_VV.Text), OldName.Text, NewName.Text);
                if (result == "NoSuch")
                    MessageBox.Show("Такое Имя не существует");
                else if (result == "HaveSuch")
                    MessageBox.Show("Такое Имя уже существует");
                else this.Close();
            }
        }
        private void Left_Mouse(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
