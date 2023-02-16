using BeautyBrows.Controller.DataAccess;
using System;
using System.Linq;
using System.Windows.Controls;

namespace BeautyBrows.View.Screens.User
{
    /// <summary>
    /// Логика взаимодействия для PageOfferService.xaml
    /// </summary>
    public partial class PageOfferService : Page
    {
        public PageOfferService()
        {
            InitializeComponent();

            var ServiceData = Connetction.BrowsEntities.Services.ToList();

            DataGridOfferService.ItemsSource = ServiceData;

            CmbServiceList.DisplayMemberPath = "Title";
            CmbServiceList.SelectedValuePath = "ID";
            CmbServiceList.ItemsSource = ServiceData;

            RunRecordsFound.Text = Convert.ToString(ServiceData.Count());
        }

        private void BtnOfferService_Click(object sender, System.Windows.RoutedEventArgs e)
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
                                                         .Where( x => x.ID == SelectedServiceId)
                                                         .ToList();

            DataGridOfferService.ItemsSource = FoundServices;

            RunRecordsFound.Text = Convert.ToString(FoundServices.Count());
        }
    }
}
