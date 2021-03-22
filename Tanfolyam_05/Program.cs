using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a jegyet!");

            byte jegy = Convert.ToByte(Console.ReadKey().KeyChar.ToString());//KeyChar().ToString());

            Console.WriteLine();

            switch (jegy)
            {
                case 1:
                    Console.WriteLine("\nElegseges");
                    break;
                case 2:
                    Console.WriteLine("\nKettes");
                    break;
                case 3:
                    Console.WriteLine("\nHarmas");
                    break;
                case 4:
                    Console.WriteLine("\nNegyes");
                    break;
                case 5:
                    Console.WriteLine("\nOtos");
                    break;
                default:
                    Console.WriteLine("Hibas adat");
                    break;
            }

            Console.ReadKey();
        }
    }
}
