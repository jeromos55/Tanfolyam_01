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
            //OraiMunka.HelloWord();                                    // 01 Project -- > Hello word
            //OraiMunka.Szamkiiratas();                                 // 02 Project --> Számkiíratás
            //OraiMunka.SzamkiiratasJavitvaV1();                        // 02 Project --> Számkiíratás egymásba ágyazassal
            //OraiMunka.SzamkiiratasJavitvaV2();                        // 03 Project --> Számkiíratás egymásba ágyazassal folytatva
            //OraiMunka.SzamkiiratasJavitvaV3();                        // 03 Project --> Számkiíratás egymásba ágyazassal folytatva
            //OraiMunka.SzamkiiratasJavitvaKesz();                      // 03 Project --> Számkiíratás egymásba ágyazassal kész
            //OraiMunka.SzamNegyzetKobV1();                             // 04 Project --> Szam négyzetre vagy köbre emelése if state
            //OraiMunka.SzamNegyzetKobV2();                             // 04 Project --> Szam négyzetre vagy köbre emelése tenary state (...) ? ... : ...;
            //OraiMunka.Osztalyzatok();                                 // 05 Project --> Osztályzatok kiiratása szövegesen
            //OraiMunka.OsszegSzorzat();                                // 06 Project --> Számok összegének és szorzaténak kiiratasa különböző módokon
            //OraiMunka.ErtekAtadas();                                  // 07 Project --> Érték átadás példa
            //OraiMunka.ReferenciaAtadas();                             // 07 Project --> Referencia szerinti átadás pléda
            //OraiMunka.ManualisKlonozas();                             // 07 Project --> Manuális klónozás ---- egy tömb átmásolása egy másikba
            //OraiMunka.MaximumKeresesHiba();                                     // 08 Project --> Maximum kereses hiba kereses gyakorlása
            //OraiMunka.TanulokAtlaga();                                          // 08 Project --> Tanulok jegye es neve alapján az átlag, legrosszab, legjobb jegyek kiiratasa, bekert adatok védelmével
            //OraiMunka.ButorokCikkszamokArakV1();                                // 09 Project --> Butor cikkszamok és árak ellenörzése saját megoldás indexek különtárolásával
            //OraiMunka.ButorokCikkszamokArakV2();                                // 09 Project --> Butor cikkszamok és árak ellenörzése, tanárral megoldva
            //OraiMunka.ButorokCikkszamokArakV3();                                // 09 Project --> Butor cikkszamok, strukúrákba rendezve, önnálóan és a tanárral befejezve
            //OraiMunka.TanulokAtlagaStruct();                                    // 09 Project --> Tanulók jegyei strukúrákban rendezve             
            //OraiMunka.NevekSzetvalgatas();                                      // 10 Project --> Nevek bekérése és szétválogatása
            //OraiMunka.LinearisBinarisIdo();                                     // 10 Project --> Lineáris és Bináris keresés időben való lemérése
            //OraiMunka.NegyAlapmuveletMain(args);                                // 10 Project --> Negy alapmuvelet veegrehajtasa metodussal main fuggveny
            
            //Console.WriteLine(OraiMunka.NegyAlapmuveletMetodus(5, 3, '+'));     // 11 Project --> 5 + 3 = 8
            //Console.WriteLine(OraiMunka.NegyAlapmuveletMetodus(12, 8, '/'));    // 11 Project --> 12 / 8 = 1,5
            //Console.WriteLine(OraiMunka.NegyAlapmuveletMetodus(5, 0, '/'));     // 11 Project --> 5 / 0 = + végtelen
            //Console.WriteLine(OraiMunka.NegyAlapmuveletMetodus(-5, 0, '/'));    // 11 Project --> -5 / 0 = - végtelen ---> 0 / 0 = NaN (Non A Number)

            Console.WriteLine(OraiMunka.SzovegEkezetMentesitese("árvíztűrő tükörfúrógép, ÁRVÍTÜRŐ TÜKÖRFÚRÓGÉP")); // Szöveg ékezet mentesítése

            Console.ReadKey();
        }
    }
}