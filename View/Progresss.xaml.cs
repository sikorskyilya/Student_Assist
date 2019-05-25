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
    /// Логика взаимодействия для Progresss.xaml
    /// </summary>
    public partial class Progresss : UserControl
    {
        public string UserID;
        public Progresss(string _userId)
        {
            UserID = _userId;
            InitializeComponent();
            ViewModel.Progress progress = new ViewModel.Progress(UserID);
            DataContext = progress;
            //Loaded += Prog_Loader;
        }
        public void Prog_Loader(object sender, RoutedEventArgs e)
        {
            
        }
        private void AddPR(object sender, RoutedEventArgs e)
        {
            Add_Progress add_Progress = new Add_Progress(UserID);
            add_Progress.Show();
            add_Progress.Topmost = true;
        }
    }
   
}
