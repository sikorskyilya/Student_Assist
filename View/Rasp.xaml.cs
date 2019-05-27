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
    public partial class Rasp : UserControl
    {
        string UserID;
        public Rasp(string _userID)
        {
            UserID = _userID;
            InitializeComponent();
            Loaded += Rasp_Loader;
            Add.Visibility = Visibility;
            Del.Visibility = Visibility.Collapsed;
        }
        public Rasp() { }
        private void AddR(object sender, RoutedEventArgs e)
        {
            if (Day.Text.ToString() == "" || Time.Text.ToString() == "" || Subject.Text.ToString() == "" || Place.Text.ToString() == "" || Type.Text.ToString() == "" || Teacher.Text.ToString() == "")
            {
                MessageBox.Show("Вы должны заполнить все поля!");
            }
            else
            {
                string Answer;
                Answer = ViewModel.RaspView.AddR(UserID, Day.Text.ToString(), Time.Text.ToString(), Subject.Text.ToString(), Place.Text.ToString(), Type.Text.ToString(), Teacher.Text.ToString(), examen.IsChecked.ToString());
                if (Answer == "Ok")
                {
                    Rasp_Loader(sender, e);
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }
        private void DeleteR(object sender, RoutedEventArgs e)
        {
            if (DayD.Text.ToString() == "" || TimeD.Text.ToString() == "" || SubjectD.Text.ToString() == "" || PlaceD.Text.ToString() == "" || TypeD.Text.ToString() == "" || TeacherD.Text.ToString() == "")
            {
                MessageBox.Show("Вы должны заполнить все поля!");
            }
            else
            {
                ViewModel.RaspView.DeleteR(UserID, DayD.Text.ToString(), TimeD.Text.ToString(), SubjectD.Text.ToString(), PlaceD.Text.ToString(), TypeD.Text.ToString(), TeacherD.Text.ToString());
                Rasp_Loader(sender, e);
            }
        }
        private void Rasp_Loader(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModel.RaspView(UserID);
        }
        public void AddRasp(object sender, RoutedEventArgs e)
        {
            Add.Visibility = Visibility;
            Del.Visibility = Visibility.Collapsed;
            
        }
        public void DeleteRasp(object sender, RoutedEventArgs e)
        {
            Del.Visibility = Visibility;
            Add.Visibility = Visibility.Collapsed;
        }
        public void RefresheRasp(object sender, RoutedEventArgs e)
        {
            Rasp_Loader(sender, e);
        }


    }
}
