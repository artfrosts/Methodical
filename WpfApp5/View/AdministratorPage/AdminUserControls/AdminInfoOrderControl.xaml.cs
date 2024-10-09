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

namespace WpfApp5.View.AdministratorPage.AdminUserControls
{
    /// <summary>
    /// Логика взаимодействия для AdminInfoOrderControl.xaml
    /// </summary>
    public partial class AdminInfoOrderControl : UserControl
    {
        public AdminInfoOrderControl()
        {
            InitializeComponent();
            DataOrderInfo.ItemsSource =FrameNavigate.DB.OrderBoard.OrderBy(w=>w.Order).ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idOrder = (DataOrderInfo.SelectedItem as OrderBoard).IDOrder;
            var result = MessageBox.Show("Хотите удалить заказ?",
                "Ситемное сообщение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                OrderBoard orderBoard = (from b in FrameNavigate.DB.OrderBoard where b.IDOrder == idOrder select b).SingleOrDefault();
                FrameNavigate.DB.OrderBoard.Remove(orderBoard);
                FrameNavigate.DB.SaveChanges();
               DataOrderInfo.ItemsSource = FrameNavigate.DB.OrderBoard.OrderBy(w => w.Order).ToList();
            }
        }
    }
}
