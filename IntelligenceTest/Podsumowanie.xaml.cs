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
    public partial class Podsumowanie : PhoneApplicationPage
    {
        private int suma = 0;
        public Podsumowanie()
        {
            InitializeComponent();

            suma = Dane.zwrocScoreDzialania() + Dane.zwrocScoreIQ() + Dane.zwrocScoreObrazki();
            
            textBlockScoreDzialania.Text = "Score: " + Dane.zwrocScoreDzialania().ToString();            
            textBlockScoreIQ.Text = "Score: " + Dane.zwrocScoreIQ();
            textBlockScoreObrazki.Text = "Score: " + Dane.zwrocScoreObrazki();
            textBlockSumaryczny.Text = "Overall: " + suma;

            if(Dane.zwrocNick() != null && Dane.zwrocNick() != " ")
            {
                textBlockNick.Text = "Your nickname: " + Dane.zwrocNick();
            }
            else
            {
                textBlockNick.Text = "Score default";
            }
        }


        private void bPowrotClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WyborGry.xaml", UriKind.Relative));
        }
    }
}