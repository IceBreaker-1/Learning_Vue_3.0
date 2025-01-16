using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
using ExcellentMeetUp.UserControls;

namespace ExcellentMeetUp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string rememberTimer = "";
        public ArrayList listOfParty = new ArrayList();

        private void AddProgram(object sender, RoutedEventArgs e)
        {
            DatePickerWithHeader newProgram = new DatePickerWithHeader();
            if (listOfParty.Count > 0)
            {
                newProgram.Start.Text = (listOfParty[listOfParty.Count - 1] as DatePickerWithHeader).lastEnd;
                listOfParty.Add(newProgram);
                ListOfPrograms.Children.Add(newProgram);
            }
            else
            {
                listOfParty.Add(newProgram);
                ListOfPrograms.Children.Add(newProgram);
            }
        }

        private void Save(object sender, MouseButtonEventArgs e)
        {
            string ImageIsSelected;
            if(ImageParty.ImageField.Source != null)
            {
                ImageIsSelected = "Выбрано";
            }
            else
            {
                ImageIsSelected = "Не выбрано";
            }
            MessageBox.Show($"Название -> {NameParty.InputField.Text}\nДата -> {DateParty.DateInputField.Text}\nМесто -> {PlaceParty.InputField.Text}\nОписание -> {DescriptionParty.InputField.Text}\nИзображение -> {ImageIsSelected}\nКол-во мероприятий -> {listOfParty.Count}");
        }

        private void Cancel(object sender, MouseButtonEventArgs e)
        {
            NameParty.InputField.Text = "";
            DateParty.DateInputField.Text = "";
            PlaceParty.InputField.Text = "";
            DescriptionParty.InputField.Text = "";
            ImageParty.ImageField.Source = null;
            ListOfPrograms.Children.Clear();
            listOfParty.Clear();
        }
    }
}
