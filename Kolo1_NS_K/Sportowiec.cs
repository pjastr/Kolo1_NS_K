using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_K
{
    class Sportowiec
    {
        protected string nazwisko;
        protected int rekord;

        public Sportowiec(string p1, int p2)
        {
            this.nazwisko = p1;
            this.rekord = p2;
        }

        public void Wyswietl()
        {
            Console.WriteLine(nazwisko + "," + rekord);
        }
    }
}
