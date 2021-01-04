using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Snake
{
    public enum Kierunek {
        Gora,
        Dol,
        Lewo,
        Prawo
            // Kierunki ruchu weza 
    };

    public class Ustawienia
    {
        public static int Szerokosc { get; set; }
        public static int Wysokosc { get; set; }
        public static int Szybkosc { get; set; }
        public static int Wynik { get; set; }
        public static int Punkty { get; set; }
        public static bool KoniecGry { get; set; }
        public static Kierunek kierunek { get; set; }

        public Ustawienia()
        {
            Szerokosc = 16;
            Wysokosc = 16;
            Szybkosc = 16;
            Wynik = 0;
            Punkty = 1;
            KoniecGry = false;
            kierunek = Kierunek.Dol; // ustawienia wszyskich 

        }
    }
}
