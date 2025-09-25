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

namespace лаба_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Сулейманова.Navigate(new ServicePage());
            Manager.Сулейманова = Сулейманова;
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.Сулейманова.GoBack();
        }
        private void Сулейманова_ContentRendered(object sender, EventArgs e)
        {
            if (Сулейманова.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }
    }
}
