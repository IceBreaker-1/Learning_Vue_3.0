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

namespace ExcellentMeetUp.UserControls
{
    /// <summary>
    /// Логика взаимодействия для TextBoxWithHeader.xaml
    /// </summary>
    public partial class TextBoxWithHeader : UserControl
    {
        public TextBoxWithHeader()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string TextHeader { get; set; }

        public int TextBoxWidth { get; set; }

        public bool IsTextBox { get; set; }

        private void SetTextBoxOrDatePicker(object sender, RoutedEventArgs e)
        {
            if(IsTextBox)
            {
                InputField.Visibility = Visibility.Visible;
                DateInputField.Visibility = Visibility.Collapsed;
            }
            else
            {
                InputField.Visibility = Visibility.Collapsed;
                DateInputField.Visibility = Visibility.Visible;
            }
        }
    }
}
