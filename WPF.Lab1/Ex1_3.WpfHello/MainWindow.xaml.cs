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

namespace Ex1.WpfHello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.IsEnabled = false;
            button2.IsEnabled = false;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("username.txt");
                sw.WriteLine(textBox.Text);
                sw.Close();
                button2.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("username.txt");
                label.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            button1.IsEnabled = true;
        }
    }
}
