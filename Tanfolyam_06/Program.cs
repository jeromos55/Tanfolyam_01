using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0, szorzat = 1;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Adja meg kovetkezo a(z) {0}. szamot!", i);
                int szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
                szorzat *= szam;
            }
            Console.WriteLine("\n Az osszeg: {0}",osszeg);
            Console.WriteLine("\n A szorzat: {0}",szorzat);

            Console.WriteLine($"\n Az osszeg: {osszeg}");
            Console.WriteLine($"\n A szorzat: {szorzat}");

            Console.WriteLine("\n Az osszeg: " + osszeg);
            Console.WriteLine("\n A szorzat: " + szorzat);

            Console.ReadKey();
        }
    }
}
