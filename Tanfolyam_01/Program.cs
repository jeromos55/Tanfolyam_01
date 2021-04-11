using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_01
{
    class Program
    {



        /*************************************************************/
        // Main metodus parameterek kiiratasa
        /*************************************************************/

        //static void Main(string[] args)
        //{
        //    // Valami

        //    if (args.Length > 0)
        //    {
        //        for (int i = 0; i < args.Length; i++)
        //        {
        //            Console.WriteLine("\t -" + args[i]);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nem erkezett parameter a programhoz");
        //    }
        //    Console.ReadKey();
        //}

        /*************************************************************/


        static void Main(string[] args)
        {
            //OraiMunka.HelloWord();                                              // Hello word
            //OraiMunka.Szamkiiratas();                                           // Számkiíratás
            //OraiMunka.SzamkiiratasJavitvaV1();                                  // Számkiíratás egymásba ágyazassal
            //OraiMunka.SzamkiiratasJavitvaV2();                                  // Számkiíratás egymásba ágyazassal folytatva
            //OraiMunka.SzamkiiratasJavitvaV3();                                  // Számkiíratás egymásba ágyazassal folytatva
            //OraiMunka.SzamkiiratasJavitvaKesz();                                // Számkiíratás egymásba ágyazassal kész
            //OraiMunka.SzamNegyzetKobV1();                                       // Szam négyzetre vagy köbre emelése if state
            //OraiMunka.SzamNegyzetKobV2();                                       // Szam négyzetre vagy köbre emelése tenary state (...) ? ... : ...;
            //OraiMunka.Osztalyzatok();                                           // Osztályzatok kiiratása szövegesen
            //OraiMunka.OsszegSzorzat();                                          // Számok összegének és szorzaténak kiiratasa különböző módokon
            //OraiMunka.ErtekAtadas();                                            // Érték átadás példa
            //OraiMunka.ReferenciaAtadas();                                       // Referencia szerinti átadás pléda
            //OraiMunka.ManualisKlonozas();                                       // Manuális klónozás ---- egy tömb átmásolása egy másikba
            //OraiMunka.MaximumKeresesHiba();                                     // Maximum kereses hiba kereses gyakorlása
            //OraiMunka.TanulokAtlaga();                                          // Tanulok jegye es neve alapján az átlag, legrosszab, legjobb jegyek kiiratasa, bekert adatok védelmével
            //OraiMunka.ButorokCikkszamokArakV1();                                // Butor cikkszamok és árak ellenörzése saját megoldás indexek különtárolásával
            //OraiMunka.ButorokCikkszamokArakV2();                                // Butor cikkszamok és árak ellenörzése, tanárral megoldva
            //OraiMunka.ButorokCikkszamokArakV3();                                // Butor cikkszamok, strukúrákba rendezve, önnálóan és a tanárral befejezve
            //OraiMunka.TanulokAtlagaStruct();                                    // Tanulók jegyei strukúrákban rendezve             
            //OraiMunka.NevekSzetvalgatas();                                      // Nevek bekérése és szétválogatása
            //OraiMunka.LinearisBinarisIdo();                                     // Lineáris és Bináris keresés időben való lemérése
            //OraiMunka.NegyAlapmuveletMain(args);                                // Negy alapmuvelet veegrehajtasa metodussal main fuggveny
            //OraiMunka.NegyAlapmuveletMainTanarral(args);                          // Negy alapmuvelet veegrehajtasa

            //Console.WriteLine(OraiMunka.NegyAlapmuveletMetodus(5, 3, '+'));     // 5 + 3 = 8
            //Console.WriteLine(OraiMunka.NegyAlapmuveletMetodus(12, 8, '/'));    // 12 / 8 = 1,5
            //Console.WriteLine(OraiMunka.NegyAlapmuveletMetodus(5, 0, '/'));     // 5 / 0 = + végtelen
            //Console.WriteLine(OraiMunka.NegyAlapmuveletMetodus(-5, 0, '/'));    // -5 / 0 = - végtelen ---> 0 / 0 = NaN (Non A Number)

            //Console.WriteLine(OraiMunka.SzovegEkezetMentesitese("árvíztűrő tükörfúrógép, ÁRVÍTÜRŐ TÜKÖRFÚRÓGÉP")); // Szöveg ékezet mentesítése

            //SajatProgramok.IfElseProblems1(22, "Andras");
            //SajatProgramok.IfElseProblems1(19, "Kati");
            //SajatProgramok.IfElseProblems1(5, "Zsolt");
            //SajatProgramok.IfElseProblems1(0, "Peter");

            //Console.ReadKey();
            //Console.Clear();

            //SajatProgramok.IfElseProblems2(22, "Andras");
            //SajatProgramok.IfElseProblems2(19, "Kati");
            //SajatProgramok.IfElseProblems2(5, "Zsolt");
            //SajatProgramok.IfElseProblems2(0, "Peter");

            //Console.ReadKey();
            //Console.Clear();

            //SajatProgramok.IfElseProblems3(22, "Andras");
            //SajatProgramok.IfElseProblems3(19, "Kati");
            //SajatProgramok.IfElseProblems3(5, "Zsolt");
            //SajatProgramok.IfElseProblems3(0, "Peter");

            Console.WriteLine(OraiMunka.FaktorialisCiklussal(5));
            Console.WriteLine(OraiMunka.FaktorialisRekurziv(5));
            Console.WriteLine(OraiMunka.FaktorialisRekurziv2(5));

            Console.WriteLine(OraiMunka.FibonacciCiklussal(5));
            Console.WriteLine(OraiMunka.FibonacciCiklussal(10));
            Console.WriteLine(OraiMunka.FibonacciRekurziv(5));
            Console.WriteLine(OraiMunka.FibonacciRekurziv(10));

            Console.ReadKey();
        }
    }
}