using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_03
{
    class Program
    {
        static void Main(string[] args)
        {

            /*********************************************************************************
            // elso megoldas

            Console.WriteLine("Adjon meg egy szamot, negyzetre kell emelni!");
            string bolvasas = Console.ReadLine();
            int szam = Convert.ToInt32(bolvasas);
            szam *= szam; // szan = szam * szam
            Console.WriteLine(szam);
            Console.ReadLine();

            *********************************************************************************
            // masodik megoldas

            Console.WriteLine("Adjon meg egy szamot, negyzetre kell emelni!");
            int szam = Convert.ToInt32(Console.ReadLine()); // A sztring valtozot kivettuk, hiszen a beolvasast magaba a kovertalasba is be tudjuk irni
            Console.WriteLine(Math.Pow(szam, 2)); // A szam kulon beszorzasat kivettuk, mert magaban a Console.WritLine-ban elo tudjuk allitani a szam negyzetet, igy megmarad az eredeti szamunk amivel tovabb tudunk dolgozni.
            Console.ReadKey();

            *********************************************************************************/
            // harmadik megoldas

            Console.WriteLine("Adjon meg egy szamot, negyzetre kell emelni!");
            Console.WriteLine(Math.Pow(Convert.ToInt32(Console.ReadLine()), 2));
            Console.ReadKey();
        }
    }
}
