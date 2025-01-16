using Microsoft.Win32;
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
    /// Логика взаимодействия для ImageWithDatePicker.xaml
    /// </summary>
    public partial class ImageWithDatePicker : UserControl
    {
        public ImageWithDatePicker()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string TextHeader { get; set; }

        private void SetImage(object sender, MouseEventArgs e)
        {
            if (ImageField.Source == null)
            {

            }
            // Открытие диалогового окна выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg, *.jpeg, *.png, *.gif)|" +
                                    "*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == true)
            {
                ImageField.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }

        private void SetImageQ(object sender, MouseEventArgs e)
        {
            if (ImageField.Source != null)
            {
                DeleteImage.Visibility = Visibility.Visible;
                SelectImage.Visibility = Visibility.Collapsed;
            }
            else
            {

                DeleteImage.Visibility = Visibility.Collapsed;
                SelectImage.Visibility = Visibility.Visible;
            }
        }

        private void SetImageQN(object sender, MouseEventArgs e)
        {
            DeleteImage.Visibility = Visibility.Collapsed;
            SelectImage.Visibility = Visibility.Collapsed;
        }
    }
}
