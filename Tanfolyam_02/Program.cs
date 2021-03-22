using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************************************
            // elso megoldas

            Console.WriteLine("Adjon meg egy számot!");  //Ki: "Adjon meg egy számot!"
            string szam = Console.ReadLine();            //szam: Szöveg ... Be: szam
            Console.WriteLine(szam);                     //Ki: szam
            Console.ReadKey();

            **********************************************************************************/
            // masodik megoldas

            Console.WriteLine("Adjon meg egy számot!");  //Ki: "Adjon meg egy számot!"
            Console.WriteLine(Console.ReadLine());       //Ki: Be --> algoritmusban ezt nem lehet leirni
            // A programnyelv logikaja megengedi, hogy ha egy valamilyen "funkcionak" olyan adatot adok at, ami valojaban egy masik "funkcionak" az eredmenye, akkor tudja, hogy addig az az adat nem lesz feldolgozhato az elso finkcioban amig a masodik le nem futott. Ezt akarmeddig tudja folytatni....
            Console.ReadKey();
        }
    }
}