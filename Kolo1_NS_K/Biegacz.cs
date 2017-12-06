using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_K
{
    class Biegacz:Sportowiec
    {
        private int dystans;

        public Biegacz(string p1, int p2, int p3)
            : base(p1, p2)
        {
            this.dystans = p3;
        }

        public bool Medal()
        {
            if (rekord > 63) return true;
            else return false;
        }
    }
}
