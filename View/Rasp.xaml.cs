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
    /// <summary>
    /// Логика взаимодействия для Rasp.xaml
    /// </summary>
    public partial class Rasp : UserControl
    {
        List<int> numbers = new List<int>();
        public Rasp()
        {
            InitializeComponent();
            Loaded += Rasp_Loader;
        }
        private void Rasp_Loader(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModel.RaspView();
        }
        public void AddRasp(object sender, RoutedEventArgs e)
        {
            lol2.Children.Add(new AddRasp());
        }
        public void DeleteRasp(object sender, RoutedEventArgs e)
        {
            
        }
        public void boolCBC_Checked(object sender, RoutedEventArgs e)
        {
            numbers.Add(data.SelectedIndex);
        }
        public void boolCBC_Unchecked(object sender, RoutedEventArgs e)
        {
            numbers.Remove(data.SelectedIndex);
        }
    }
}
