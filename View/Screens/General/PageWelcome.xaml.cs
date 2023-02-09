using BeautyBrows.Controller.Navigation;
using BeautyBrows.View.Screens.User;
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

namespace BeautyBrows.View.Screens.General
{
    /// <summary>
    /// Логика взаимодействия для PageWelcome.xaml
    /// </summary>
    public partial class PageWelcome : Page
    {
        public PageWelcome()
        {
            InitializeComponent();
        }

        private void ButtonAdmin_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigation.Navigator.Navigate(new PageEnterCode());
        }

        private void ButtonUser_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigation.Navigator.Navigate(new PageOfferService());
        }
    }
}
