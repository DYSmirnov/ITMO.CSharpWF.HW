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

namespace WPF.Lab2.Ex1.WpfRoutedEvent_2_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        
        }

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        textBox1_TextChanged_1:
            MessageBox.Show("Event by textbox");
            e.Handled = (bool)radBut1.IsChecked;

        Grid_TextChanged_1:
            MessageBox.Show("Event by Grid");
            e.Handled = (bool)radBut2.IsChecked;

        Window_TextChanged_1:
            MessageBox.Show("Event by Window");
            e.Handled = (bool)radBut3.IsChecked;
        }
    }
}
