using System;
using System.Windows;

namespace practicalWorkNo12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
            => InitializeComponent();

        private void Close_Click(object sender, RoutedEventArgs e)
            => Close();

        private void BtnDoATask_Click(object sender, RoutedEventArgs e)
        {
            SupClass.TaskFunc(tbInput, tbResult);
        }

        private void ShowInfo_Click(object sender, RoutedEventArgs e)
            => MessageBox.Show("1) Даны стороны прямоугольника a и b. Найти его площадь периметр\n" +
                               "2) Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево.");

        private void TbInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
            => BtnDoATask.IsEnabled = true;
    }
}
