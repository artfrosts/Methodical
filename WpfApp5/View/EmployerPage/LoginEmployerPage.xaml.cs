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
    /// Логика взаимодействия для LoginEmployerPage.xaml
    /// </summary>
    public partial class LoginEmployerPage : Page
    {
        public LoginEmployerPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employers userModel = FrameNavigate.DB.Employers.FirstOrDefault(u => u.EmployerMail == TbLogin.Text && u.EmployerPhone == PsbPassword.Password);

                if (userModel == null)
                {
                    MessageBox.Show("Ошибка данных",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    FrameNavigate.FrameObject.Navigate(new DeteilEmployerPage());
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

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }
    }
}
