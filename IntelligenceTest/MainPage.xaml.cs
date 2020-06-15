using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using IntelligenceTest.Resources;
using System.Windows.Input;

namespace IntelligenceTest
{
    public partial class MainPage : PhoneApplicationPage
    {
        InputScope scope = new InputScope();
        InputScopeName name = new InputScopeName();

        public string nick = null;



        public MainPage()
        {
            InitializeComponent();

            name.NameValue = InputScopeNameValue.Text;
            scope.Names.Add(name);

            textBoxNick.Focus();
           
        }

      

        private void bDalejClick(object sender, RoutedEventArgs e)
        {
          
            nick = textBoxNick.Text;
            if(nick == null || nick == "")
            {
                nick = "default";
                Dane.ustawNick(nick);
            }
            else
            {
                Dane.ustawNick(nick);
            }
            NavigationService.Navigate(new Uri("/WyborGry.xaml", UriKind.Relative));

        }

        private void SelectionChanged(object sender, RoutedEventArgs e)
        {
            textBoxNick.Background = gridDane.Background;
            textBoxNick.BorderBrush = bDalej.BorderBrush;
        }
    }
}