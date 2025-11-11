using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace VetClinic
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CurrentTime.Text = DateTime.Now.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Command;
            if (((Button)sender).Tag.ToString() == "Продажи")
            {
                Command = "SELECT Продажи.Номер AS 'Номер', Покупатели.Фамилия AS 'Покупатель', Работники.Фамилия AS 'Продавец', Номенклатура.Название AS 'Товар', Номенклатура.Цена FROM Продажи " +
                            " LEFT JOIN Работники ON Работники.Номер = Продажи.Продавец " +
                            " LEFT JOIN Покупатели ON Покупатели.Номер = Продажи.Покупатель" +
                            " LEFT JOIN Номенклатура ON Номенклатура.Номер = Продажи.Покупатель";
            }
            else
            {
                Command = $"SELECT * FROM {((Button)sender).Tag.ToString()}";
            }
            Frame.Navigate(new DataPage(((Button)sender).Tag.ToString(), ((Button)sender).Tag.ToString(), ((Button)sender).Uid, Command));
        }
        private void ThemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) =>
           Application.Current.Resources["Current"] = (ThemeComboBox.SelectedIndex == 0) ?
           (SolidColorBrush)Application.Current.Resources["LightTheme"] :
           (SolidColorBrush)Application.Current.Resources["DarkTheme"];

    }
}
