using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Elso_megoldas();

            Masodik_megoldas();

        }

        static void Elso_megoldas()
        {
            /*********************************************************************************/
            // elso megoldas
            /*********************************************************************************/

            // cw tab-tab --> Console/WriteLine*();
            Console.WriteLine("\nAdja meg a számot, amit négyzetre, vagy köbre emelünk!");
            int szam = Convert.ToInt32(Console.ReadLine());
            //if tab-tab --> if teljes szerkezete
            if (szam % 2 == 0) // Maradékos osztás kettővel = 0 --> páros szám
            {
                Console.WriteLine(Math.Pow(szam, 2));
            }
            else // else tab-tab - az else szerkezetét adja meg
            {
                Console.WriteLine(Math.Pow(szam, 3));
            }
            Console.ReadKey();

        }

        static void Masodik_megoldas()
        {

            /*********************************************************************************/
            // masodik megoldas
            /*********************************************************************************/

            Console.WriteLine("\nAdja meg a számot, amit négyzetre, vagy köbre emelünk!");
            int szam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Pow(szam, (szam % 2 == 0) ? 2 : 3));

            Console.ReadKey();
        }

    }
}