﻿using Student_Assist.ViewModel;
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
using System.Data.SQLite;
using System.Configuration;
using Dapper;
namespace Student_Assist.View
{
    /// <summary>
    /// Логика взаимодействия для Add_Progress.xaml
    /// </summary>
    public partial class Add_Progress : Window
    {
        List<int> Pr_1SS;
        string UserID;
        public Add_Progress(string _userid)
        {
            UserID = _userid;
            InitializeComponent();
            Pr_1SS = new List<int>(Enumerable.Range(1, 1000));
            PR1_SS.ItemsSource = Pr_1SS;
            PR1_VV.ItemsSource = Pr_1SS;
            PR2_SS.ItemsSource = Pr_1SS;
            PR2_VV.ItemsSource = Pr_1SS;
            PR3_SS.ItemsSource = Pr_1SS;
            PR3_VV.ItemsSource = Pr_1SS;
            PR4_SS.ItemsSource = Pr_1SS;
            PR4_VV.ItemsSource = Pr_1SS;
            PR5_SS.ItemsSource = Pr_1SS;
            PR5_VV.ItemsSource = Pr_1SS;
            PR6_SS.ItemsSource = Pr_1SS;
            PR6_VV.ItemsSource = Pr_1SS;
        }
        private void Left_Mouse(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if ((PR1_SS.Text.ToString() != "" && PR1_VV.Text.ToString() == "") || (PR1_SS.Text.ToString() == "" && PR1_VV.Text.ToString() != "") ||
                 (PR2_SS.Text.ToString() != "" && PR2_VV.Text.ToString() == "") || (PR2_SS.Text.ToString() == "" && PR2_VV.Text.ToString() != "") ||
                 (PR3_SS.Text.ToString() != "" && PR3_VV.Text.ToString() == "") || (PR3_SS.Text.ToString() == "" && PR3_VV.Text.ToString() != "") ||
                 (PR4_SS.Text.ToString() != "" && PR4_VV.Text.ToString() == "") || (PR4_SS.Text.ToString() == "" && PR4_VV.Text.ToString() != "") ||
                 (PR5_SS.Text.ToString() != "" && PR5_VV.Text.ToString() == "") || (PR5_SS.Text.ToString() == "" && PR5_VV.Text.ToString() != "") ||
                 (PR6_SS.Text.ToString() != "" && PR6_VV.Text.ToString() == "") || (PR6_SS.Text.ToString() == "" && PR6_VV.Text.ToString() != "") ||
                 (PR1_SS.Text != "" && PR1_VV.Text != "" && name1.Text == "") || (PR2_SS.Text != "" && PR2_VV.Text != "" && name2.Text == "") ||
                 (PR3_SS.Text != "" && PR3_VV.Text != "" && name3.Text == "") || (PR4_SS.Text != "" && PR4_VV.Text != "" && name4.Text == "") ||
                 (PR5_SS.Text != "" && PR5_VV.Text != "" && name5.Text == "") || (PR6_SS.Text != "" && PR6_VV.Text != "" && name6.Text == ""))
            {
                MessageBox.Show("Поля должны быть попарно заполнены!");
            }
            else
            {
                string result;
                ViewModel.Progress progress = new ViewModel.Progress();
                if (PR1_SS.Text.ToString() != "")
                {
                    if (Int32.Parse(PR1_SS.Text) > Int32.Parse(PR1_VV.Text))
                        MessageBox.Show("Ошибочные данные в строке 1");
                    else
                    {
                        result = progress.AddPr(UserID, (Int32.Parse(PR1_SS.Text) * 100) / Int32.Parse(PR1_VV.Text), name1.Text);
                        if (result == "Have")
                            MessageBox.Show("Такое поле есть!");
                        if (result == "Limit")
                            MessageBox.Show("Количество полей бльше 8!");
                    }
                }
                if (PR2_SS.Text.ToString() != "")
                {
                    if (Int32.Parse(PR2_SS.Text) > Int32.Parse(PR2_VV.Text))
                        MessageBox.Show("Ошибочные данные в строке 1");
                    else
                    {
                        result = progress.AddPr(UserID, (Int32.Parse(PR2_SS.Text) * 100) / Int32.Parse(PR2_VV.Text), name2.Text);
                        if (result == "Have")
                            MessageBox.Show("Такое поле есть!");
                        if (result == "Limit")
                            MessageBox.Show("Количество полей бльше 8!");
                    }
                }
                if (PR3_SS.Text.ToString() != "")
                {
                    if (Int32.Parse(PR3_SS.Text) > Int32.Parse(PR3_VV.Text))
                        MessageBox.Show("Ошибочные данные в строке 1");
                    else
                    {
                        result = progress.AddPr(UserID, (Int32.Parse(PR3_SS.Text) * 100) / Int32.Parse(PR3_VV.Text), name3.Text);
                        if (result == "Have")
                            MessageBox.Show("Такое поле есть!");
                        if (result == "Limit")
                            MessageBox.Show("Количество полей бльше 8!");
                    }
                }
                if (PR4_SS.Text.ToString() != "")
                {
                    if (Int32.Parse(PR4_SS.Text) > Int32.Parse(PR4_VV.Text))
                        MessageBox.Show("Ошибочные данные в строке 1");
                    else
                    {
                        result = progress.AddPr(UserID, (Int32.Parse(PR4_SS.Text) * 100) / Int32.Parse(PR4_VV.Text), name4.Text);
                        if (result == "Have")
                            MessageBox.Show("Такое поле есть!");
                        if (result == "Limit")
                            MessageBox.Show("Количество полей бльше 8!");
                    }
                }
                if (PR5_SS.Text.ToString() != "")
                {
                    if (Int32.Parse(PR5_SS.Text) > Int32.Parse(PR5_VV.Text))
                        MessageBox.Show("Ошибочные данные в строке 1");
                    else
                    {
                        result = progress.AddPr(UserID, (Int32.Parse(PR5_SS.Text) * 100) / Int32.Parse(PR5_VV.Text), name5.Text);
                        if (result == "Have")
                            MessageBox.Show("Такое поле есть!");
                        if (result == "Limit")
                            MessageBox.Show("Количество полей бльше 8!");
                    }
                }
                if (PR6_SS.Text.ToString() != "")
                {
                    if (Int32.Parse(PR6_SS.Text) > Int32.Parse(PR6_VV.Text))
                        MessageBox.Show("Ошибочные данные в строке 1");
                    else
                    {
                        result = progress.AddPr(UserID, (Int32.Parse(PR6_SS.Text) * 100) / Int32.Parse(PR6_VV.Text), name6.Text);
                        if (result == "Have")
                            MessageBox.Show("Такое поле есть!");
                        if (result == "Limit")
                            MessageBox.Show("Количество полей бльше 8!");
                    }
                }
            }
            this.Close();
        }
        private void Quit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
