using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Snake
{
    class Odczyt
    {
        private static Hashtable tablicaKlawiszy = new Hashtable();

        public static bool CzyWcisniety(Keys przycisk)
        {
            if (tablicaKlawiszy[przycisk]==null)
            {
                return false;
            }
            return (bool)tablicaKlawiszy[przycisk];
        }

        public static void ZmienStatus(Keys przycisk, bool stan)          // odczyt przyciskow z klawiatury
        {
            tablicaKlawiszy[przycisk] = stan;
        }
    }
}
