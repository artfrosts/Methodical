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
using WpfApp5.Model;
using WpfApp5.View.LoginPage;

namespace WpfApp5.View.EmployerPage
{
    /// <summary>
    /// Логика взаимодействия для MainEmployerPage.xaml
    /// </summary>
    public partial class MainEmployerPage : Page
    {
        public MainEmployerPage()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employers employerModel = FrameNavigate.DB.Employers.FirstOrDefault(m => m.FIO == TbCompanyName.Text);
                if (employerModel == null)
                {
                    MessageBox.Show("Ошибка данных",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Данные проверенны, доступ разрешен",
                                       "Системное сообщение",
                                       MessageBoxButton.OK,
                                       MessageBoxImage.Information);
                    BtnCheck.IsEnabled = false;
                    BtnLoginEmployer.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                               "Системная ошибка",
                               MessageBoxButton.OK,
                              MessageBoxImage.Error);
            }

        }

        private void BtnLoginEmployer_Click(object sender, RoutedEventArgs e)
        {
                FrameNavigate.FrameObject.Navigate(new LoginEmployerPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }
    }
}
