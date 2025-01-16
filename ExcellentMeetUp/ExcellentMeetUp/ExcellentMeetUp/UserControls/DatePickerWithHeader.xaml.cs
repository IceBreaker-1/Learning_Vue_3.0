using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ExcellentMeetUp.UserControls
{
    /// <summary>
    /// Логика взаимодействия для DatePickerWithHeader.xaml
    /// </summary>
    public partial class DatePickerWithHeader : UserControl
    {
        public DatePickerWithHeader()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string lastEnd = "";
        private void CheckFormat(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string regex = @"^([0-1]?[0-9]|[2][0-3]):([0-1]?[0-9]|[2-5][0-9])$";
            if (Regex.Match(textBox.Text, regex).Success)
            {
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
            else
            {
                textBox.Foreground = new SolidColorBrush(Colors.Red);

            }
            if(textBox.Name == "End")
            {
                lastEnd = textBox.Text;
            }
        }

        private void ClearThis(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }
    }
}
