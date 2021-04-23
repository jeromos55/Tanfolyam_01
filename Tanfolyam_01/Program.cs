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
            //int[] tomb = { 1, 9, 15, 20, 21, 35, 36, 38, 49 };
            //int[] tomb2 = { 1, 15, 21, 28, 30 };
            //int[] tomb3 = { 15, 9, 1, 35, 21, 20, 49, 38, 36 };
            //int[] tomb4 = { 15, 9, 1, 35, 21, 20, 49, 38, 36 };
            //int[] tomb5 = { 15, 9, 1, 35, 21, 20, 49, 38, 36 };
            //int[] tomb6 = { 15, 9, 1, 35, 21, 20, 49, 38, 36 };
            //int[] tomb7 = { 15, 9, 1, 35, 21, 20, 49, 38, 36 };
            //int[] shell_lepesek = { 5, 3, 1 };

            //Tetelek.BinarisKereses(tomb, 49);
            //Tetelek.BinarisKereses(tomb, 22);

            //Tetelek.Osszegzes(tomb);
            //Tetelek.Megszemlalas(tomb, 21);

            //Tetelek.Eldontes(tomb, 21);
            //Tetelek.Eldontes(tomb, 28);

            //Tetelek.Eldontes2(tomb, 21);
            //Tetelek.Eldontes2(tomb, 28);

            //Tetelek.Kivalsztas(tomb, 15);
            //Tetelek.Kivalsztas(tomb, 16);

            //Tetelek.LinearisKereses(tomb, 35);
            //Tetelek.LinearisKereses(tomb, 37);

            //Tetelek.Kivalogatas(tomb, 21);
            //Tetelek.Szetvalogatas(tomb, 35);

            //Tetelek.Metszet(tomb, tomb2);
            //Tetelek.Unio(tomb, tomb2);

            //Tetelek.Maximum(tomb);
            //Tetelek.Maximum(tomb2);
            //Tetelek.Minimum(tomb);
            //Tetelek.Minimum(tomb2);

            //Rendezesek.Buborek(tomb3);
            //Rendezesek.Cseres(tomb4);
            //Rendezesek.Maximum(tomb5);
            //Rendezesek.Beszurasos(tomb3);
            //Rendezesek.GyorsRekurziv_main(tomb6);
            //Rendezesek.Shell_rendzes(tomb7, shell_lepesek);

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

            //Console.WriteLine(OraiMunka.FaktorialisCiklussal(5));
            //Console.WriteLine(OraiMunka.FaktorialisRekurziv(5));
            //Console.WriteLine(OraiMunka.FaktorialisRekurziv2(5));

            //Console.WriteLine(OraiMunka.FibonacciCiklussal(5));
            //Console.WriteLine(OraiMunka.FibonacciCiklussal(10));
            //Console.WriteLine(OraiMunka.FibonacciRekurziv(5));
            //Console.WriteLine(OraiMunka.FibonacciRekurziv(10));

            //OraiMunka.BeepitettRendezes();                                            // Array.Sort() rendezes hasznalata
            //OraiMunka.AutoRendszamok();                                               // Autórednszámos feladat saját megoldás
            //OraiMunka.AutoRendszamokTanar();                                          // Autórendszámos feldat tanárral megoldva
            //SajatProgramok.BinarisKeresesRekurzivExamples();                          // Bináris kereses rekurziv saját megoldás
            //OraiMunka.SzovegesFajlbolTanulok();
            //OraiMunka.NevekFilebaIratasa();
            //OraiMunka.TanulokFislebaIratasa();
            //OraiMunka.SzovegEkezetMentesito();

            //OraiMunka.TanulokFilebaIratasaStruct();                             // tanulok.txt létrehozás és ujból beolvasaása majd átlag és min és max kiiratása
            //OraiMunka.TanulokAtlagMaxMin();                                     // tanulok átlaga, maximuma és minmuma

            //OraiMunka.VersenyzokRendezes();                                     // Vesrenyzok listazasa es rendezese helyzetek és pontszám szerint

            //OraiMunka.CSVBeleptetes();                                          // Baléptető rendszer készítése jakab, 123456aA, ica, 123456aB, geza, 123456aC
            //Console.WriteLine(OraiMunka.SHA256("jakab"));                       // sha256 jelszó kódólás kiiratása

            //SajatProgramok.SorsolasStatisztika();                              // Lotoszám Statisztika

            //OraiMunka.TanuloAtlagCSV();                                          // CVS fájlba írása

            OraiMunka.FajlKezelo();

            Console.ReadKey();
        }
    }
}