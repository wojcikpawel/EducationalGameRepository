using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace IntelligenceTest
{
    public partial class IQtest : PhoneApplicationPage
    {
        private int score = 0;
        private char [] poprawne = {'a','c','d','a','c','a','b','a','b','d'};
        private int licznik = 1;
        private int tik = 498;

        DispatcherTimer timer = new DispatcherTimer();

        

        public IQtest()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Tick += new EventHandler(timer1_Tick);

            this.score = 0;
            timer.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar.Value += 1;  
            if (tik >= 0)
            {
                tik--;               
              
            }
            else
            {               
                zmianaWidokuGrida(2);
                textBlockWynik.Text += " " + this.score * 43;

                this.score = 0;
                timer.Stop();
            }
        }

        private void obrazki(int i)
        {
            

                switch (i)
                {
                    case 2:
                        BitmapImage source1 = new BitmapImage();
                        source1.UriSource = new Uri("Images/7.png", UriKind.Relative);
                        imagePytanie.Source = source1;
                        BitmapImage source2 = new BitmapImage();
                        source2.UriSource = new Uri("Images/7a.png", UriKind.Relative);
                        imageA.Source = source2;
                        BitmapImage source3 = new BitmapImage();
                        source3.UriSource = new Uri("Images/7b.png", UriKind.Relative);
                        imageB.Source = source3;
                        BitmapImage source4 = new BitmapImage();
                        source4.UriSource = new Uri("Images/7c_pop.png", UriKind.Relative);
                        imageC.Source = source4;
                        BitmapImage source5 = new BitmapImage();
                        source5.UriSource = new Uri("Images/7d.png", UriKind.Relative);
                        imageD.Source = source5;
                        break;
                    case 3:
                        BitmapImage source6 = new BitmapImage();
                        source6.UriSource = new Uri("Images/8.png", UriKind.Relative);
                        imagePytanie.Source = source6;
                        BitmapImage source7 = new BitmapImage();
                        source7.UriSource = new Uri("Images/8a.png", UriKind.Relative);
                        imageA.Source = source7;
                        BitmapImage source8 = new BitmapImage();
                        source8.UriSource = new Uri("Images/8b.png", UriKind.Relative);
                        imageB.Source = source8;
                        BitmapImage source9 = new BitmapImage();
                        source9.UriSource = new Uri("Images/8c.png", UriKind.Relative);
                        imageC.Source = source9;
                        BitmapImage source10 = new BitmapImage();
                        source10.UriSource = new Uri("Images/8d_pop.png", UriKind.Relative);
                        imageD.Source = source10;
                        break;
                    case 4:
                        BitmapImage source11 = new BitmapImage();
                        source11.UriSource = new Uri("Images/9.png", UriKind.Relative);
                        imagePytanie.Source = source11;
                        BitmapImage source12 = new BitmapImage();
                        source12.UriSource = new Uri("Images/9a_pop.png", UriKind.Relative);
                        imageA.Source = source12;
                        BitmapImage source13 = new BitmapImage();
                        source13.UriSource = new Uri("Images/9b.png", UriKind.Relative);
                        imageB.Source = source13;
                        BitmapImage source14 = new BitmapImage();
                        source14.UriSource = new Uri("Images/9c.png", UriKind.Relative);
                        imageC.Source = source14;
                        BitmapImage source15 = new BitmapImage();
                        source15.UriSource = new Uri("Images/9d.png", UriKind.Relative);
                        imageD.Source = source15;
                        break;
                        //
                    case 5:
                        BitmapImage source16 = new BitmapImage();
                        source16.UriSource = new Uri("Images/10.png", UriKind.Relative);
                        imagePytanie.Source = source16;
                        BitmapImage source17 = new BitmapImage();
                        source17.UriSource = new Uri("Images/10a.png", UriKind.Relative);
                        imageA.Source = source17;
                        BitmapImage source18 = new BitmapImage();
                        source18.UriSource = new Uri("Images/10b.png", UriKind.Relative);
                        imageB.Source = source18;
                        BitmapImage source19 = new BitmapImage();
                        source19.UriSource = new Uri("Images/10c_pop.png", UriKind.Relative);
                        imageC.Source = source19;
                        BitmapImage source20 = new BitmapImage();
                        source20.UriSource = new Uri("Images/10d.png", UriKind.Relative);
                        imageD.Source = source20;
                        break;
                    case 6:
                        BitmapImage source21 = new BitmapImage();
                        source21.UriSource = new Uri("Images/11.png", UriKind.Relative);
                        imagePytanie.Source = source21;
                        BitmapImage source22 = new BitmapImage();
                        source22.UriSource = new Uri("Images/11a_pop.png", UriKind.Relative);
                        imageA.Source = source22;
                        BitmapImage source23 = new BitmapImage();
                        source23.UriSource = new Uri("Images/11b.png", UriKind.Relative);
                        imageB.Source = source23;
                        BitmapImage source24 = new BitmapImage();
                        source24.UriSource = new Uri("Images/11c.png", UriKind.Relative);
                        imageC.Source = source24;
                        BitmapImage source25 = new BitmapImage();
                        source25.UriSource = new Uri("Images/11d.png", UriKind.Relative);
                        imageD.Source = source25;
                        break;
                    case 7:
                        BitmapImage source26 = new BitmapImage();
                        source26.UriSource = new Uri("Images/12.png", UriKind.Relative);
                        imagePytanie.Source = source26;
                        BitmapImage source27 = new BitmapImage();
                        source27.UriSource = new Uri("Images/12a.png", UriKind.Relative);
                        imageA.Source = source27;
                        BitmapImage source28 = new BitmapImage();
                        source28.UriSource = new Uri("Images/12b_pop.png", UriKind.Relative);
                        imageB.Source = source28;
                        BitmapImage source29 = new BitmapImage();
                        source29.UriSource = new Uri("Images/12c.png", UriKind.Relative);
                        imageC.Source = source29;
                        BitmapImage source30 = new BitmapImage();
                        source30.UriSource = new Uri("Images/12d.png", UriKind.Relative);
                        imageD.Source = source30;
                        break;
                    case 8:
                        BitmapImage source31 = new BitmapImage();
                        source31.UriSource = new Uri("Images/13.png", UriKind.Relative);
                        imagePytanie.Source = source31;
                        BitmapImage source32 = new BitmapImage();
                        source32.UriSource = new Uri("Images/13a_pop.png", UriKind.Relative);
                        imageA.Source = source32;
                        BitmapImage source33 = new BitmapImage();
                        source33.UriSource = new Uri("Images/13b.png", UriKind.Relative);
                        imageB.Source = source33;
                        BitmapImage source34 = new BitmapImage();
                        source34.UriSource = new Uri("Images/13c.png", UriKind.Relative);
                        imageC.Source = source34;
                        BitmapImage source35 = new BitmapImage();
                        source35.UriSource = new Uri("Images/13d.png", UriKind.Relative);
                        imageD.Source = source35;
                        break;
                    case 9:
                        BitmapImage source36 = new BitmapImage();
                        source36.UriSource = new Uri("Images/14.png", UriKind.Relative);
                        imagePytanie.Source = source36;
                        BitmapImage source37 = new BitmapImage();
                        source37.UriSource = new Uri("Images/14a.png", UriKind.Relative);
                        imageA.Source = source37;
                        BitmapImage source38 = new BitmapImage();
                        source38.UriSource = new Uri("Images/14b_pop.png", UriKind.Relative);
                        imageB.Source = source38;
                        BitmapImage source39 = new BitmapImage();
                        source39.UriSource = new Uri("Images/14c.png", UriKind.Relative);
                        imageC.Source = source39;
                        BitmapImage source40 = new BitmapImage();
                        source40.UriSource = new Uri("Images/14d.png", UriKind.Relative);
                        imageD.Source = source40;
                        break;
                    case 10:
                        BitmapImage source41 = new BitmapImage();
                        source41.UriSource = new Uri("Images/15.png", UriKind.Relative);
                        imagePytanie.Source = source41;
                        BitmapImage source42 = new BitmapImage();
                        source42.UriSource = new Uri("Images/15a.png", UriKind.Relative);
                        imageA.Source = source42;
                        BitmapImage source43 = new BitmapImage();
                        source43.UriSource = new Uri("Images/15b.png", UriKind.Relative);
                        imageB.Source = source43;
                        BitmapImage source44 = new BitmapImage();
                        source44.UriSource = new Uri("Images/15c.png", UriKind.Relative);
                        imageC.Source = source44;
                        BitmapImage source45 = new BitmapImage();
                        source45.UriSource = new Uri("Images/15d_pop.png", UriKind.Relative);
                        imageD.Source = source45;
                        break;
                }
        }

        private void czyPoprawne(int i, char odp)
        {
            if(poprawne[i-1] == odp)
            {
                this.score++;
            }
        }
        private void zmianaWidokuGrida(int flaga)
        {
            if (flaga == 1)
            {
                gridStartowy.Visibility = Visibility.Collapsed;
         
                grid1.Visibility = Visibility.Visible;

            }
            else if (flaga == 2)
            {
                grid1.Visibility = Visibility.Collapsed;
              
                grid2.Visibility = Visibility.Visible;

            }
           
        }

        private void bStartClick(object sender, RoutedEventArgs e)
        {
            zmianaWidokuGrida(1);
          
        }

        private void tapA(object sender, System.Windows.Input.GestureEventArgs e)
        {
            obrazki(licznik+1);
            czyPoprawne(licznik, 'a');
            if (licznik >= 10)
            {
                zmianaWidokuGrida(2);
                textBlockWynik.Text += " " + this.score*43*tik;
                Dane.ustawScoreIQ(this.score * 43*tik);
            }
            licznik++;
         
        }

        private void tapB(object sender, System.Windows.Input.GestureEventArgs e)
        {
            obrazki(licznik + 1);
            czyPoprawne(licznik, 'b');
            if (licznik >= 10)
            {
                zmianaWidokuGrida(2);
                textBlockWynik.Text += " " + this.score * 43 * tik;
                Dane.ustawScoreIQ(this.score * 43 * tik);
            }
            licznik++;
          
        }

        private void tapC(object sender, System.Windows.Input.GestureEventArgs e)
        {
            obrazki(licznik + 1);
            czyPoprawne(licznik, 'c');
            if (licznik >=10)
            {
                zmianaWidokuGrida(2);
                textBlockWynik.Text += " " + this.score * 43 * tik;
                Dane.ustawScoreIQ(this.score * 43 * tik);
            }
            licznik++;

           
        }

        private void tapD(object sender, System.Windows.Input.GestureEventArgs e)
        {
            obrazki(licznik + 1);
            czyPoprawne(licznik, 'd');
            if (licznik >= 10)
            {
                zmianaWidokuGrida(2);
                textBlockWynik.Text += " " + this.score * 43 * tik;
                Dane.ustawScoreIQ(this.score * 43 * tik);
            }
            licznik++;           
        }

        private void bPowrotClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WyborGry.xaml", UriKind.Relative));
                 
        }

        private void progressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }

        private void bBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WyborGry.xaml", UriKind.Relative));
        }
    }
}