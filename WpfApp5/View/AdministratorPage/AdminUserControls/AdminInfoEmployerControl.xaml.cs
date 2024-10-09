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
    /// Логика взаимодействия для AdminInfoEmployerControl.xaml
    /// </summary>
    public partial class AdminInfoEmployerControl : UserControl
    {
        public AdminInfoEmployerControl()
        {
            InitializeComponent();
            DataEmploerInfo.ItemsSource = FrameNavigate.DB.Employers.OrderBy(w=>w.FIO).ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idEmployer = (DataEmploerInfo.SelectedItem as Employers).EmployerID;
            var result= MessageBox.Show("Хотите удалить компнаию?",
                "Ситемное сообщение",
                MessageBoxButton.YesNo, 
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Employers employers = (from w in FrameNavigate.DB.Employers where w.EmployerID == idEmployer select w).SingleOrDefault();
                FrameNavigate.DB.Employers.Remove(employers);
                FrameNavigate.DB.SaveChanges();
                DataEmploerInfo.ItemsSource = FrameNavigate.DB.Employers.OrderBy(w => w.FIO).ToList();
            }
        }
    }
}
