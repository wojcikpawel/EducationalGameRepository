using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligenceTest
{
    public class Dane
    {
        public static string nickname = "default";
        public static int scoreIQ = 0;

        public static int scoreDzialania = 0;

        public static int scoreObrazki = 0;

        public static void ustawScoreDzialania(int sc)
        {
            scoreDzialania = sc;
        }
        public static int zwrocScoreDzialania()
        {
            return scoreDzialania;
        }
        public static void ustawNick(string nm)
        {
           nickname = nm;
        }
        public static string zwrocNick()
        {
            return nickname;
        }
        public static void ustawScoreObrazki(int sc)
        {
            scoreObrazki = sc;
        }
        public static int zwrocScoreObrazki()
        {
            return scoreObrazki;
        }
        public static void ustawScoreIQ(int sc)
        {
            scoreIQ = sc;
        }
        public static int zwrocScoreIQ()
        {
            return scoreIQ;
        }
    }
}
