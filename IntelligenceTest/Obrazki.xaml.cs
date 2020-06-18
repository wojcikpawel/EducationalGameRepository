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
using System.Threading;
using System.Windows.Threading;

namespace IntelligenceTest
{
    public partial class Obrazki : PhoneApplicationPage
    {
        private static int licznik = 0;
        private static int i, j;
        private static bool flaga = false;
        private static bool timerFlag = false;
        private static int przelacznik = 0;
        private static int zakres = 0;
        private static bool blokada = true;

        public static int score = 0;

        private int tik2 = 149;
        private int tik = 1;

        public List<Image> obrazki;
        public List<BitmapImage> source;
        public Dictionary<Image, BitmapImage> pictures;
        List<int> wylosowane = new List<int>();
        List<int> wylosowane2 = new List<int>();
    
        List<int> iteratory1 = new List<int>();
        List<int> iteratory2 = new List<int>();
        List<int> iteratory3 = new List<int>();

        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer2 = new DispatcherTimer();

        Random rand = new Random();
        
      
        public Obrazki()
        {
            InitializeComponent();

            Obrazki.blokada = true;
            progressBar.Value = 0;

            losowanie();
            dodajObrazki();
            dodajSource();
            
            inicjalizacjaDictionary();
            inicjalizacjaObrazkow();
           

            timer.Interval = new TimeSpan(0, 0, 0, 1);
            timer.Tick += new EventHandler(timer1_Tick);

            timer2.Interval = new TimeSpan(0, 0, 0, 1);
            timer2.Tick += new EventHandler(timer2_Tick);

            timer2.Start();

        }

        public void inicjalizacjaDictionary()
        {
            pictures = new Dictionary<Image, BitmapImage>();

            for (int i = 0; i < 24; i++)
            {
                pictures.Add(obrazki[i], source[12]);
            }

           
        }
        private void inicjalizacjaObrazkow()
        {
            for (int i = 0; i < 24; i++)
            {
                pictures.Keys.ElementAt(i).Source = source[12];
            }
        }
        public void losowanie()
        {

            inicjalizacjaIteratorow();

            int zakres = 0;
            
            for (int i = 0; i < 12; i++)
            {

                int idx = rand.Next(0, 12 - zakres);
                int idx2 = rand.Next(0, 12 - zakres);


                int wylosowana = iteratory2.ElementAt(idx);
                int wylosowana2 = iteratory1.ElementAt(idx2);

                wylosowane.Add(wylosowana);
                wylosowane.Add(wylosowana2);

                iteratory1.RemoveAt(idx2);
                iteratory2.RemoveAt(idx);

                zakres++;
            }

            zakres = 0;
            for (int i = 0; i < 24; i++)
            {

                int idx = rand.Next(0, 24 - zakres);
          
                int wylosowana = iteratory3.ElementAt(idx);
                
                wylosowane2.Add(wylosowana);
             

                iteratory3.RemoveAt(idx);
    
                zakres++;
            }

            zakres = 0;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(tik2 > 0)
            {
                tik2--;
                progressBar.Value++;
            }
            else
            {
                         timer2.Stop();
                         tik2 = 149;
                         gridOdkrywanie.Visibility = Visibility.Collapsed;

                         gridKoniec.Visibility = Visibility.Visible;

                         textBlockWynik.Text = "Your Score: " + Obrazki.score * 49;
                

                Dane.ustawScoreObrazki(Obrazki.score * 49);

                    

                         Obrazki.zakres = 0;
                         Obrazki.blokada = true;
                 
            }
        }

            
        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (tik > 0)
            {
                tik--;
            }
            else
            {
                timer.Stop();
                if (Obrazki.timerFlag)
                {
                    obrazki[i].Visibility = Visibility.Collapsed;
                    obrazki[j].Visibility = Visibility.Collapsed;
                    Obrazki.i = 0;
                    Obrazki.j = 0;
                    Obrazki.timerFlag = false;

                    Obrazki.przelacznik = 0;

                    if (Obrazki.score == 12)
                    {
                        gridOdkrywanie.Visibility = Visibility.Collapsed;

                        gridKoniec.Visibility = Visibility.Visible;

                        textBlockWynik.Text = "Your Score: " + score * 49*tik2;

                        Dane.ustawScoreObrazki(Obrazki.score * 49*tik2);

                        timer2.Stop();
                        Obrazki.zakres = 0;
                        Obrazki.blokada = true;
                    }
                }
                else
                {
                   
                    // przywracanie poczatkowych sourcow dla obrazkow
                    pictures.Keys.ElementAt(j).Source = source[12];
                    default1 = pictures.Keys.ElementAt(j);
                    pictures[default1] = source[12];

                    pictures.Keys.ElementAt(i).Source = source[12];
                    default1 = pictures.Keys.ElementAt(i);
                    pictures[default1] = source[12];
            
                    Obrazki.i = 0;
                    Obrazki.j = 0;
                    Obrazki.przelacznik = 0;
                }
                tik = 1;
            }
        }

        public void inicjalizacjaIteratorow()
        {
            for (int i = 0; i < 12; i++)
            {
             
                iteratory1.Add(i);
                iteratory2.Add(i);
            }
            for (int i = 0; i < 24; i++)
            {
                iteratory3.Add(i);
            }
                Obrazki.blokada = false;
        }

        public void dodajObrazki()
        {
            obrazki = new List<Image>();
                       
            obrazki.Add(img1);
            obrazki.Add(img2);
            obrazki.Add(img3);
            obrazki.Add(img4);
            obrazki.Add(img5);
            obrazki.Add(img6);
            obrazki.Add(img7);
            obrazki.Add(img8);
            obrazki.Add(img9);
            obrazki.Add(img10);
            obrazki.Add(img11);
            obrazki.Add(img12);
            obrazki.Add(img13);
            obrazki.Add(img14);
            obrazki.Add(img15);
            obrazki.Add(img16);
            obrazki.Add(img17);
            obrazki.Add(img18);
            obrazki.Add(img19);
            obrazki.Add(img20);
            obrazki.Add(img21);
            obrazki.Add(img22);
            obrazki.Add(img23);
            obrazki.Add(img24);
            obrazki.Add(default1);
            

           
        }

        public void dodajSource()
        {
            source = new List<BitmapImage>();

            for (int i = 1; i < 14; i++)
            {
                source.Add(new BitmapImage(new Uri("Obrazki/"+i+".png", UriKind.Relative)));              

            }
          
           
        }
      
        
        private void tap(int a)
        {
            if (pictures.Keys.ElementAt(a).Source == source[12])
            {               
                
                if (Obrazki.przelacznik == 0)
                {
                    
                    pictures.Keys.ElementAt(a).Source = source[wylosowane.ElementAt(a)];
                    default1 = pictures.Keys.ElementAt(a);
                    pictures[default1] = source[wylosowane.ElementAt(a)];

                    Obrazki.i = a; // iterator potrzebny do zakrycia obrazkow

                    czyIdentyczne(a);
                    Obrazki.przelacznik++; // przelacznik uniemozliwiajacy klikniecie wiecej niz 2 obrazkow

                }
                else if (Obrazki.przelacznik == 1)
                {
                    pictures.Keys.ElementAt(a).Source = source[wylosowane.ElementAt(a)];
                    default1 = pictures.Keys.ElementAt(a);
                    pictures[default1] = source[wylosowane.ElementAt(a)];

                    Obrazki.j = a; // iterator potrzebny do zakrycia obrazkow
                    czyIdentyczne(a);

                    Obrazki.przelacznik++;

                }
            }
        }

        private void czyIdentyczne(int j)
        {
            for (int i = 0; i < 24; i++)
            {
                if (i != j)
                {
                    if (pictures.Values.ElementAt(j) == pictures.Values.ElementAt(i))
                    {
                        Obrazki.i = i;
                        Obrazki.j = j;

                        //flaga używana jest w timerze 
                        Obrazki.timerFlag = true;

                        timer.Start();   
                       
                        Obrazki.score++;                       
                        
                        // flaga powoduje wejście do poniższego ifa tak żeby nie zwiększał się licznik
                        Obrazki.flaga = true;

                    }
                }
            }
            if(flaga)
            {
                Obrazki.flaga = false;
               
            }
            else if(Obrazki.licznik == 0)
            {
                 Obrazki.licznik++;
                 
            }
            else if(Obrazki.licznik == 1)
            {
                Obrazki.licznik = 0;
                timer.Start();
            }
        }
       

        private void bStartClick(object sender, RoutedEventArgs e)
        {
            gridStartowy.Visibility = Visibility.Collapsed;

            gridOdkrywanie.Visibility = Visibility.Visible;

            timer2.Start();
        }

        private void bPowrotClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/WyborGry.xaml", UriKind.Relative));
        }
        private void img1Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(0);

        }
        private void img2Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(1);
        }

        private void img3Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(2);
        }

        private void img4Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(3);
        }

        private void img5Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(4);
           
        }

        private void img6Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(5);
        }

        private void img7Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(6);
        }

        private void img8Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(7);
        }        

        private void img9Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(8);
        }

        private void img10Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(9);
        }

        private void img11Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(10);
        }

        private void img12Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(11);
            
        }

        private void img13Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(12);
        }

        private void img14Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(13);
        }

        private void img15Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(14);
        }

        private void img16Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(15);
        }

        private void img17Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(16);
        }

        private void img18Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(17);
        }

        private void img19Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(18);
        }

        private void img20Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(19);
        }

        private void img21Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(20);
        }

        private void img22Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(21);
        }

        private void img23Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(22);
        }

        private void bBack_Click(object sender, RoutedEventArgs e)
        {
              NavigationService.Navigate(new Uri("/WyborGry.xaml", UriKind.Relative));
        }

        private void img24Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            tap(23);
        }

    }
}

