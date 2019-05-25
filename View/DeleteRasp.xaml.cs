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
    /// Логика взаимодействия для DeleteRasp.xaml
    /// </summary>
    public partial class DeleteRasp : UserControl
    {
        string UserID;
        public DeleteRasp(string _userId)
        {
            InitializeComponent();
            UserID = _userId;
        }
        private void DeleteR(object sender, RoutedEventArgs e)
        {
            if (Day.Text.ToString() == "" || Time.Text.ToString() == "" || Subject.Text.ToString() == "" || Place.Text.ToString() == "" || Type.Text.ToString() == "" || Teacher.Text.ToString() == "")
            {
                MessageBox.Show("Вы должны заполнить все поля!");
            }
            else
            {
               ViewModel.RaspView.DeleteR(UserID, Day.Text.ToString(), Time.Text.ToString(), Subject.Text.ToString(), Place.Text.ToString(), Type.Text.ToString(), Teacher.Text.ToString());
            }
        }
    }
}
