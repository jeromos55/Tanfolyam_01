using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_01
{
    class SajatProgramok
    {
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

        
    }
}
