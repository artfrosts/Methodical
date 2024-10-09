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
using WpfApp5.Core;
using WpfApp5.View.LoginPage;

namespace WpfApp5.View.UserPage
{
    /// <summary>
    /// Логика взаимодействия для MainUserPage.xaml
    /// </summary>
    public partial class MainUserPage : Page
    {
        public MainUserPage()
        {
            InitializeComponent();
            DataOrderInfo.ItemsSource=FrameNavigate.DB.OrderBoard.OrderBy(f=> f.Order).ToList();
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заявка отпралена на рассмотрение модерации ",
                "Системное сообщение",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}
