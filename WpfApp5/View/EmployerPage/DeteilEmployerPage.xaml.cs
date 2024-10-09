using MaterialDesignThemes.Wpf.Internal;
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

namespace WpfApp5.View.EmployerPage
{
    /// <summary>
    /// Логика взаимодействия для DeteilEmployerPage.xaml
    /// </summary>
    public partial class DeteilEmployerPage : Page
    {
        public DeteilEmployerPage()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TbTitle.Text)||
                string.IsNullOrEmpty(TbTime.Text)||
                string.IsNullOrEmpty(TbOrder.Text))
            {
                MessageBox.Show("Все поля должны быть заполены!",
                                "Системное сообщение",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Заказ № 15 отправлен на модерирование",
                                  "Системное сообщение",
                                  MessageBoxButton.OK,
                                  MessageBoxImage.Information);
                ClearTextBox();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new LoginEmployerPage());
        }
        private void ClearTextBox()
        {
            TbOrder.Text = string.Empty;
            TbTitle.Text = string.Empty;
            TbTime.Text = string.Empty;
        }
    }
}
