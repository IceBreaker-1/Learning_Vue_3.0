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

namespace WpfAppHomework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string text;
        public int index;
        public int index_for_delete;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAdd_click(object sender, RoutedEventArgs e)
        {
            List1.Items.Add($"{List1.Items.Count+1}. {text}");
        }

        private void ButtonRemove_click(object sender, RoutedEventArgs e)
        {
            if (List1.Items.Count > 0)
            {
                List1.Items.RemoveAt(List1.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Список дел пуст");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            text = textBox.Text;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            TextBox textBox1 = (TextBox)sender;
            index = Convert.ToInt32(textBox1.Text);
        }

        private void ButtonInsert_click(object sender, RoutedEventArgs e)
        {
            List1.Items.Insert(index, text);
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            TextBox textBox2 = (TextBox)sender;
            index_for_delete = Convert.ToInt32(textBox2.Text);
        }

        private void ButtonRemoveAt_click(object sender, RoutedEventArgs e)
        {
            if (index_for_delete < List1.Items.Count)
            {
                List1.Items.RemoveAt(index_for_delete);
            }
            else
            {
                MessageBox.Show($"Элемента с индексом '{index_for_delete}' нет в списке");
            }
        }
    }
}
