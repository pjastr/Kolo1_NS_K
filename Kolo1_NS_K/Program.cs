using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_K
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportowiec s1 = new Sportowiec("sddfg", 123);
            Sportowiec s2 = new Sportowiec("kjhgfd", 2123);
            Biegacz b1 = new Biegacz("xzc", 456, 4);
            Biegacz b2 = new Biegacz("xsadzc", 126, 456);
            Kolarz k1 = new Kolarz("pojssb", 23, true);
            Kolarz k2 = new Kolarz("bvcx", 765, false);
            b1.Medal();
            b2.Medal();
            k1.NowyRekord(345);
            k2.NowyRekord(9877);
            s1.Wyswietl();
            s2.Wyswietl();
            b1.Wyswietl();
            b2.Wyswietl();
            k1.Wyswietl();
            k2.Wyswietl();

            Console.ReadKey();
        }
    }
}
