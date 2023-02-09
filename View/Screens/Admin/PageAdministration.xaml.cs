﻿using BeautyBrows.Controller.DataAccess;
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
            DataGridOfferService.ItemsSource = Connetction.BrowsEntities.Services.ToList();
        }

        private void BtnEditService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteService_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
