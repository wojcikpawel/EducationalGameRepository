using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace IntelligenceTest
{
    public partial class WyborGry : PhoneApplicationPage
    {
               
       
        // Constructor
        public WyborGry()
        {
            InitializeComponent();
          
        }

      
        private void bDzialania(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Dzialania.xaml", UriKind.Relative));
        }

        private void bObrazki(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Obrazki.xaml", UriKind.Relative));
        }

        private void bIQ(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/IQtest.xaml", UriKind.Relative));
        }

        private void bPodsumowanie(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Podsumowanie.xaml", UriKind.Relative));
        }

        private void bExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Terminate();
        }
        

    }
}