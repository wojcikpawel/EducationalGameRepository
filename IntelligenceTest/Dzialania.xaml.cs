using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Input;
using System.Windows.Threading;

namespace IntelligenceTest
{
    public partial class Dzialania : PhoneApplicationPage
    {
        Obliczenia Obl = new Obliczenia();
        InputScope scope = new InputScope();
        InputScopeName name = new InputScopeName();
        DispatcherTimer timer = new DispatcherTimer();

        private int tik = 9;
        private static int score = 0;
        

        public Dzialania()
        {
            InitializeComponent();

           
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Tick += new EventHandler(timer1_Tick);

            Dzialania.score = 0;
           
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
           progressBar.Value++;
           if (tik >= 0)
               tik--;
           else
           {
               Dzialania.score *= 37;
               textBlockWynik.Text += " " + Dzialania.score;

               Dane.ustawScoreDzialania(Dzialania.score);

               timer.Stop();
               zmianaWidokuGrida(2);
           }    
        }

        private void zmianaWidokuGrida(int flaga)
        {
            if (flaga == 1)
            {
                gridDzialaniaStart.Visibility = Visibility.Collapsed;
                gridPowrot.Visibility = Visibility.Collapsed;

                gridRownania.Visibility = Visibility.Visible;

            }
            else if (flaga == 2)
            {
                gridRownania.Visibility = Visibility.Collapsed;
                gridDzialaniaStart.Visibility = Visibility.Collapsed;
            
                gridPowrot.Visibility = Visibility.Visible;
                
            }
            else if(flaga == 3)
            {
                gridRownania.Visibility = Visibility.Collapsed;
                gridPowrot.Visibility = Visibility.Collapsed;

                gridDzialaniaStart.Visibility = Visibility.Visible;
            }
        }

        private void bStartClick(object sender, RoutedEventArgs e)
        {

            zmianaWidokuGrida(1);
            
            //losowanie rownania i ustawianie textBlocka na rownanie
            Obl.Losowanie();
            tRownanie.Text = Obl.label;

            //ustawianie klawiatury telefonicznej
            name.NameValue = InputScopeNameValue.TelephoneNumber;
            scope.Names.Add(name);
           
            textBoxOdpowiedz.InputScope = scope;
            this.IsTabStop = true;
            // Set focus on the TextBox.
            textBoxOdpowiedz.Focus();

            timer.Start();


        }

   
        private void bDalejClick(object sender, RoutedEventArgs e)
        {
            timer.Stop();

            //ustawianie klawiatury telefonicznej
            name.NameValue = InputScopeNameValue.TelephoneNumber; 
            // Set focus on the TextBox.
            textBoxOdpowiedz.Focus();

            //deklaracja i inicjalizacja odpowiedzi uzytkownika
            string odpowiedz = textBoxOdpowiedz.Text;
            //deklaracja i inicjalizacja wyniku
            int Awynik = 0;

            //pobranie odpowiedzi uzytkownika wraz z lapaniem exception'a
           try
           {
                Awynik = Convert.ToInt32(odpowiedz);
           }
           catch(FormatException ex)
           {
                tRownanie.Text = Obl.label;   
           }

            //sprawdzanie poprawnosci odpowiedzi
            if (Awynik == Obl.wynik)
            {
                Obl.Losowanie();
                tRownanie.Text = Obl.label;

                Dzialania.score++;
            }
            else
            {
              
                

                zmianaWidokuGrida(2);
                Dzialania.score *= 37 * tik;
                textBlockWynik.Text += " " + Dzialania.score;

                Dane.ustawScoreDzialania(Dzialania.score);
              
              

                timer.Stop();

            }

            textBoxOdpowiedz.Text = " ";

            tik = 9;
            timer.Start();
            progressBar.Value = 0;
        }

        private void bPowrotClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WyborGry.xaml", UriKind.Relative));
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void SelectionChanged(object sender, RoutedEventArgs e)
        {
            textBoxOdpowiedz.Background = gridRownania.Background;
            textBoxOdpowiedz.BorderBrush = buttonDalej.BorderBrush;
        }

        private void bBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WyborGry.xaml", UriKind.Relative));
        }
    }
}