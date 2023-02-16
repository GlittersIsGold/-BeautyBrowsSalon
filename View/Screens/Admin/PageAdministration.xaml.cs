using BeautyBrows.Controller.DataAccess;
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

namespace BeautyBrows.View.Screens.Admin
{
    /// <summary>
    /// Логика взаимодействия для PageAdministration.xaml
    /// </summary>
    public partial class PageAdministration : Page
    {
        public PageAdministration()
        {
            InitializeComponent();

            var ServiceData = Connetction.BrowsEntities.Services.ToList();

            DataGridOfferService.ItemsSource = ServiceData;

            CmbServiceList.DisplayMemberPath = "Title";
            CmbServiceList.SelectedValuePath = "ID";
            CmbServiceList.ItemsSource = ServiceData;

            RunRecordsFound.Text = Convert.ToString(ServiceData.Count());
        }

        private void BtnEditService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TbSearchQuery_TextChanged(object sender, TextChangedEventArgs e)
        {
            string SearchQuery = Convert.ToString(TbSearchQuery.Text);

            var FoundRespone = Connetction.BrowsEntities.Services
                                                        .Where(x => x.Title.Contains(SearchQuery))
                                                        .ToList();

            DataGridOfferService.ItemsSource = FoundRespone;

            RunRecordsFound.Text = Convert.ToString(FoundRespone.Count());
        }

        private void CmbServiceList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedServiceId = Convert.ToInt32(CmbServiceList.SelectedValue);

            var FoundServices = Connetction.BrowsEntities.Services
                                                         .Where(x => x.ID == SelectedServiceId)
                                                         .ToList();

            DataGridOfferService.ItemsSource = FoundServices;

            RunRecordsFound.Text = Convert.ToString(FoundServices.Count());
        }
    }
}
