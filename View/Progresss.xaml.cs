﻿using System;
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
    public partial class Progresss : UserControl
    {
        public string UserID;
        public Progresss(string _userId)
        {
            UserID = _userId;
            InitializeComponent();
            Loaded += Prog_Loader;
        }
        public void Prog_Loader(object sender, RoutedEventArgs e)
        {
            ViewModel.Progress progress = new ViewModel.Progress(UserID);
            DataContext = progress;
        }
        private void AddPR(object sender, RoutedEventArgs e)
        {
            Add_Progress add_Progress = new Add_Progress(UserID);
            add_Progress.ShowDialog();
            Prog_Loader(sender, e);
        }
        private void Refresh(object sender, RoutedEventArgs e)
        {
            Prog_Loader(sender, e);
        }
        private void EditPR(object sender, RoutedEventArgs e)
        {
            Edit_Progress edit_Progress = new Edit_Progress(UserID);
            
            edit_Progress.Topmost = true;
            edit_Progress.ShowDialog();
            Prog_Loader(sender, e);
        }
        private void DeletePR(object sender, RoutedEventArgs e)
        {
            PR_Delete pR_Delete = new PR_Delete(UserID);
            pR_Delete.ShowDialog();
            Prog_Loader(sender, e);
        }
    }
   
}
