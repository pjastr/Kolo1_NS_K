using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_K
{
    class Kolarz:Sportowiec
    {
        private bool szosa;

        public Kolarz(string p1, int p2, bool szosa)
            : base(p1, p2)
        {
            this.szosa = szosa;
        }

        public void NowyRekord(int p1)
        {
            base.rekord = p1;
            Console.WriteLine("Nowy rekord: {0}", p1);
        }
    }
}
