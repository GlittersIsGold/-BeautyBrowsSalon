using BeautyBrows.Controller.Navigation;
using BeautyBrows.View.Screens.Admin;
using BeautyBrows.View.Windows.Alert;
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
    /// Логика взаимодействия для PageEnterCode.xaml
    /// </summary>
    public partial class PageEnterCode : Page
    {
        public PageEnterCode()
        {
            InitializeComponent();
        }

        private void ButtonEnterWithCode_Click(object sender, RoutedEventArgs e)
        {

            string SecretCode = "0000";

            if(PasswordBoxCode.Password == SecretCode) 
            {
                FrameNavigation.Navigator.Navigate(new PageAdministration());
            }
            else
            {
                ExceptionWindow exceptionWindow= new ExceptionWindow();
                exceptionWindow.Show();
            }
        }
    }
}
