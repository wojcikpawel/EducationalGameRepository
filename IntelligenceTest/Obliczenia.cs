using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IntelligenceTest
{
    public class Obliczenia
    {
        public int a { get; set; }
        public int b { get; set; }
        public char znak { get; set; }
        public int wynik { get; set; }

        public string label { get; set; }


        List<char> znaki = new List<char>();
        Random rand = new Random();


        public void Losowanie()
        {

            znaki.Add('+');
            znaki.Add('-');
            znaki.Add('*');
            znaki.Add('%');


            int a1 = rand.Next(1, 100);
            int b1 = rand.Next(1, 10);
            int idx1 = rand.Next(0, 4);

            a = a1;
            b = b1;
            int idx = idx1;

            znak = znaki.ElementAt(idx);

            this.label = a.ToString() + " " + znak.ToString() + " " + b.ToString() + " = ?";

            if (znak == '+')
            {
                this.wynik = a + b;
            }
            else if (znak == '-')
            {
                this.wynik = a - b;
            }
            else if (znak == '*')
            {
                this.wynik = a * b;
            }
            else if (znak == '%')
            {
                this.wynik = a % b;
            }


        }


    }
}
