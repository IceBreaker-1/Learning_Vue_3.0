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

namespace WpfHomework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int n1;
        public int n2;
        public int n3;
        public int n4;
        public int n5;
        public int n6;
        public int n7;
        public int n8;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void N1(object sender, RoutedEventArgs e)
        {
            n1 = Convert.ToInt32(V1.Text);
            MessageBox.Show($"Насос 1 = {n1}");
        }

        private void N2(object sender, RoutedEventArgs e)
        {
            n2 = Convert.ToInt32(V2.Text);
            MessageBox.Show($"Насос 2 = {n2}");
        }

        private void N3(object sender, RoutedEventArgs e)
        {
            n3 = Convert.ToInt32(V3.Text);
            MessageBox.Show($"Насос 3 = {n3}");

        }

        private void N4(object sender, RoutedEventArgs e)
        {
            n4 = Convert.ToInt32(V4.Text);
            MessageBox.Show($"Насос 4 = {n4}");
        }

        private void N5(object sender, RoutedEventArgs e)
        {
            n5 = Convert.ToInt32(V5.Text);
            MessageBox.Show($"Насос 5 = {n5}");
        }

        private void N6(object sender, RoutedEventArgs e)
        {
            n6 = Convert.ToInt32(V6.Text);
            MessageBox.Show($"Насос 6 = {n6}");
        }

        private void N7(object sender, RoutedEventArgs e)
        {
            n7 = Convert.ToInt32(V7.Text);
            MessageBox.Show($"Насос 7 = {n7}");
        }

        private void N8(object sender, SelectionChangedEventArgs e)
        {
            n8 = Convert.ToInt32(V8.Text);
            MessageBox.Show($"Насос 8 = {n8}");
        }
    }
}
