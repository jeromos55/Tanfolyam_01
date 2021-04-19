using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_01
{
    class SajatProgramok
    {
        /*************************************************************/
        // if else problems
        /*************************************************************/
        public static void IfElseProblems1(int age, string name) // Ez igy nehezebben ertheto
        {
            Console.WriteLine(name + " " + age + " eves");
            if (age != 0)
            {
                if (age < 18)
                {
                    Console.WriteLine("Nem ihat alkoholt az EU-ban!\n");
                }
                else if (age < 21)
                {
                    Console.WriteLine("Nem ihat alkoholt az US-ban!\n");
                }
                else
                {
                    Console.WriteLine("Ihat alkoholt\n");
                }
            }
            else
            {
                Console.WriteLine("Rossz kormeghatarozas!\n");
            }
        }

        public static void IfElseProblems2(int age, string name) // Lehet-e hasznalni a return-t kilepesre ??
        {
            Console.WriteLine(name + " " + age + " eves");

            if (age <= 0)
            {
                Console.WriteLine("Rossz kormeghatarozas!\n");
                return;
            }

            string result;
            if (age < 18)
            {
                result = "Nem ihat alkoholt az EU-ban!\n";
            }
            else if (age < 21)
            {
                result = "Nem ihat alkoholt az US-ban!\n";
            }
            else
            {
                result = "Ihat alkoholt\n";
            }
            Console.WriteLine(result);
        }

        public static void IfElseProblems3(int age, string name) // Mindegyik feltetel kulon igy konyebben ertheto
        {
            Console.WriteLine(name + " " + age + " eves");

            if (age <= 0)
            {
                Console.WriteLine("Rossz kormeghatarozas!\n");
                return;
            }

            if (age < 18)
            {
                Console.WriteLine("Nem ihat alkoholt az EU-ban!\n");
                return;
            }

            if (age < 21)
            {
                Console.WriteLine("Nem ihat alkoholt az US-ban!\n");
                return;
            }

            Console.WriteLine("Ihat alkoholt\n");
            return ;
 
        }

        /*************************************************************/
        // binaris kereses rekurziv
        /*************************************************************/
        static int BinarasiKereses(int[] tomb, int l, int r, int x)  // a l ,r a két széle a tömbnek az x pedig a keresett szám
        {
            while (l <= r)
            {
                int m = l + Math.Abs((r - l) / 2);
                if (tomb[m] == x) return m;  // Ha pont középen van akkor vissza adjuk m-et
                if (tomb[m] < x) // Ha x nagyobb kihagyjuk a ball oldalt
                {
                    l = m + 1;
                }
                else   // Ha x kisebb kihagyjuk a jobb oldalt
                {
                    r = m - 1;
                }
            }
            return -1;
        }

        static int BinarasiKeresesRekurziv(int[] tomb, int l, int r, int x)
        {
            if (r >= l)
            {
                int m = l + Math.Abs((r - l) / 2);
                if (tomb[m] == x) return m;  // Ha pont középen van akkor vissza adjuk m-et
                if (tomb[m] > x) return BinarasiKeresesRekurziv(tomb, 1, m - 1, x); // Ha az elem kisebb mint m, akkor baloldalon van
                return BinarasiKeresesRekurziv(tomb, m + 1, r, x);  // Különbenn elem jobb oldalon van
            }
            return -1;  // Ha nincs tömb akkor vissza
        }

        public static void BinarisKeresesRekurzivExamples()
        {
            int[] tomb = { 1, 9, 15, 20, 21, 35, 36, 38, 49 };
            int tombHossz = tomb.Length - 1;
            int keresetSzam;
            int result;
            string resultString;

            keresetSzam = 21;
            result = BinarasiKereses(tomb, 0, tombHossz, keresetSzam);
            resultString = (result == -1) ? "Nincs benne " : "Benne van ";
            Console.WriteLine("{0}a tömbben a {1}!\n", resultString, keresetSzam);


            result = BinarasiKeresesRekurziv(tomb, 0, tombHossz, keresetSzam);
            resultString = (result == -1) ? "Nincs benne " : "Benne van ";
            Console.WriteLine("{0}a tömbben a {1}! Rekurziv megoldás\n", resultString, keresetSzam);

            keresetSzam = 10;
            result = BinarasiKereses(tomb, 0, tombHossz, keresetSzam);
            resultString = (result == -1) ? "Nincs benne " : "Benne van ";
            Console.WriteLine("{0}a tömbben a {1}!\n", resultString, keresetSzam);


            result = BinarasiKeresesRekurziv(tomb, 0, tombHossz, keresetSzam);
            resultString = (result == -1) ? "Nincs benne " : "Benne van ";
            Console.WriteLine("{0}a tömbben a {1}! Rekurziv megoldás\n", resultString, keresetSzam);

            Console.ReadKey();
        }
    }
}
