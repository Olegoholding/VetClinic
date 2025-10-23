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
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        private string _name;
        public DataPage(string name)
        {
            InitializeComponent();

            _name = name;
            DirName.Text = _name;
        }

        private void ToMainWindow_MouseDown(object sender, MouseButtonEventArgs e) => ((MainWindow)Application.Current.MainWindow).Frame.Content = null;

    }
}
