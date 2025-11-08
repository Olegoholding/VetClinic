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

        private void Button_Click(object sender, RoutedEventArgs e) => Frame.Navigate(new DataPage(((Button)sender).Tag.ToString(), ((Button)sender).Tag.ToString(), ((Button)sender).Uid, $"Select * From {((Button)sender).Tag.ToString()}_view"));
        private void ThemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) =>
           Application.Current.Resources["Current"] = (ThemeComboBox.SelectedIndex == 0) ?
           (SolidColorBrush)Application.Current.Resources["LightTheme"] :
           (SolidColorBrush)Application.Current.Resources["DarkTheme"];

    }
}
