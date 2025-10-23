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

namespace VetClinic
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

        private void Button_Click(object sender, RoutedEventArgs e) => Frame.Navigate(new DataPage("Вкладка"));
        

        private void ThemeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) =>
           Application.Current.Resources["Current"] = (ThemeComboBox.SelectedIndex == 0) ?
           (SolidColorBrush)Application.Current.Resources["LightTheme"] :
           (SolidColorBrush)Application.Current.Resources["DarkTheme"];

    }
}
