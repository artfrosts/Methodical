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
using WpfApp5.View.AdministratorPage.AdminUserControls;

namespace WpfApp5.View.AdministratorPage
{
    /// <summary>
    /// Логика взаимодействия для MainAdministratorPage.xaml
    /// </summary>
    public partial class MainAdministratorPage : Page
    {
        public MainAdministratorPage()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            GridContentLoad.Children.Add(new AdminInfoUserControl());
        }

        private void MenuEmployer_clik(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            GridContentLoad.Children.Add(new AdminInfoEmployerControl());
        }

        private void MenuItemOrder_Clik(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            GridContentLoad.Children.Add(new AdminInfoOrderControl());
        }
    }
}
