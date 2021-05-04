using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace Tanfolyam_01
{
    class OraiMunka
    {
        struct Tanulo                                                          // struktura (nev, jegy)
        {
            // A mezőknek egy fontos tulajdonsága a láthatósági szint amivel később fogunk foglalkozni (az osztáyoknál) --> Minden mező láthatatlan alapvetően a külvilág felé, tehát gondoskodni kell róla, hogy látható legyen
            public string nev; // a leírás egy tanulóra kell vonatkozzon
            public byte jegy; // Azokat a vátozókat amiket itt létrehozzunk mezőnek / field-nek nevezzük.
        }
        struct Auto                                                            // (rendszam, alalpot)
        {
            public string rendszam;
            public int allapot;
        }
        struct Butor                                                           // struktura (cikkaszam, arak
        {
            public string cikkszam; // cikkszamok számok és karakterek
            public int arak; // az árak
        }

        public static void HelloWord()                                         // Hello world
        {
            /*************************************************************/
            // Hello world
            /*************************************************************/

            // CTRL + SHIFT + B --> a program leforditasa elerheto
            // F5 / Start gomb --> a program leforditasa es futtatasa

            Console.Clear();
            Console.WriteLine("Hello World!");
            // A console alkalmazasok azonnal kilepnek a futasbol amint az osszes feldatot végrrehajtottak
            // A megoldas: olyan feladatot adunk a programnak amit nem tud rögtön végrehajtani, így am0g arra var, addig mi el tudjuk olvasni, hogy mi van a konzolon.
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey(); // Beolvasunk tehat a felhasznalotol egy karaktert, mely akkor tud csak tovabb ugrani ha aa felhasznalo lenyomta a gombot, így addig a konyol életben marad.
        }
        public static void Szamkiiratas()                                      // Szám kiiratás
        {
            /*************************************************************/
            // Elso megoldas
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Adjon meg egy számot!");  //Ki: "Adjon meg egy számot!"
            string szam = Console.ReadLine();            //szam: Szöveg ... Be: szam
            Console.WriteLine(szam);                     //Ki: szam
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();
        }
        public static void SzamkiiratasJavitvaV1()                             // Szám kiiratás egymásba ágyazással 
        {
            /*************************************************************/
            // Masodik megoldas
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Adjon meg egy számot!");  //Ki: "Adjon meg egy számot!"
            Console.WriteLine(Console.ReadLine());       //Ki: Be --> algoritmusban ezt nem lehet leirni
            // A programnyelv logikaja megengedi, hogy ha egy valamilyen "funkcionak" olyan adatot adok at, ami valojaban egy masik "funkcionak" az eredmenye, akkor tudja, hogy addig az az adat nem lesz feldolgozhato az elso finkcioban amig a masodik le nem futott. Ezt akarmeddig tudja folytatni....
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();
        }
        public static void SzamkiiratasJavitvaV2()                             // Szám kiiratás egymásba ágyazással folytatva
        {
            /*************************************************************/
            // Elso megoldas
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Adjon meg egy szamot, negyzetre kell emelni!");
            string bolvasas = Console.ReadLine();
            int szam = Convert.ToInt32(bolvasas);
            szam *= szam; // szan = szam * szam
            Console.WriteLine(szam);
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();
        }
        public static void SzamkiiratasJavitvaV3()                             // Szám kiiratás egymásba ágyazással folytatva
        {
            /*************************************************************/
            // Masodik megoldas
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Adjon meg egy szamot, negyzetre kell emelni!");
            int szam = Convert.ToInt32(Console.ReadLine()); // A sztring valtozot kivettuk, hiszen a beolvasast magaba a kovertalasba is be tudjuk irni
            Console.WriteLine(Math.Pow(szam, 2)); // A szam kulon beszorzasat kivettuk, mert magaban a Console.WritLine-ban elo tudjuk allitani a szam negyzetet, igy megmarad az eredeti szamunk amivel tovabb tudunk dolgozni.
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();
        }
        public static void SzamkiiratasJavitvaKesz()                           // Szám kiiratás egymásba ágyazással kész
        {
            /*************************************************************/
            // Harmadik megoldas
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Adjon meg egy szamot, negyzetre kell emelni!");
            Console.WriteLine(Math.Pow(Convert.ToInt32(Console.ReadLine()), 2));
            Console.WriteLine("\nNyomj meg egy gombot!");
            Console.ReadKey();
        }
        public static void SzamNegyzetKobV1()                                  // Szam négyzetre vagy köbre emelése if state
        {
            /*********************************************************************************/
            // elso megoldas
            /*********************************************************************************/

            // cw tab-tab --> Console/WriteLine*();
            Console.Clear();
            Console.WriteLine("Adja meg a számot, amit négyzetre, vagy köbre emelünk!");
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
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();

        }
        public static void SzamNegyzetKobV2()                                  // Szam négyzetre vagy köbre emelése tenary state (...) ? ... : ...;
        {

            /*********************************************************************************/
            // masodik megoldas
            /*********************************************************************************/

            Console.Clear();
            Console.WriteLine("Adja meg a számot, amit négyzetre, vagy köbre emelünk!");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(szam, (szam % 2 == 0) ? 2 : 3));
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();
        }
        public static void Osztalyzatok()                                      // Osztáyzatok kiiratása szövegesen
        {
            /*************************************************************/
            // Osztalyzatok
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Adja meg a jegyet!");

            byte jegy = Convert.ToByte(Console.ReadKey().KeyChar.ToString()); // KeyChar().ToString());

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

            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();
        }
        public static void OsszegSzorzat()                                     // Számok összegének és szorzatának kiiratása különböző módokon
        {
            /*************************************************************/
            // Osszeg, szorzat, kiiratas peldak
            /*************************************************************/

            Console.Clear();
            int osszeg = 0, szorzat = 1;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Adja meg kovetkezo a(z) {0}. szamot!", i);
                int szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
                szorzat *= szam;
            }
            Console.WriteLine("\n Az osszeg: {0}", osszeg);
            Console.WriteLine("\n A szorzat: {0}", szorzat);

            Console.WriteLine($"\n Az osszeg: {osszeg}");
            Console.WriteLine($"\n A szorzat: {szorzat}");

            Console.WriteLine("\n Az osszeg: " + osszeg);
            Console.WriteLine("\n A szorzat: " + szorzat);

            Console.WriteLine("\nNyonjon meg egy gombot!");
            Console.ReadKey();
        }
        public static void ErtekAtadas()                                       // Érték átadás példa
        {
            /*************************************************************/
            // Ertek atadas peldak
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Ertek atadas peldak:\n");
            int a = 3;
            int b = a;
            b++;
            Console.WriteLine("  Az 'a' változo erteke: {0}, a 'b' valtozo erteke: {1}", a, b);
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();
        }
        public static void ReferenciaAtadas()                                  // Referencia szerinti atadas
        {
            /*************************************************************/
            // Referencia szerinti atadas
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Referencia szerinti atadas:\n");
            int[] aTomb = new int[2];
            aTomb[0] = 3;
            aTomb[1] = 10;
            int[] bTomb = aTomb;

            Console.WriteLine("  Az eredmeny: aTomb[0] = {0}, aTomb[1] = {1}, bTomb[0] = {2}, aTomb[1] = {3}", aTomb[0], aTomb[1], bTomb[0], bTomb[1]);
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();

        }
        public static void ManualisKlonozas()                                  // Manualis klonozas (egy tömb átmásolása egy másikba)
        {
            /*************************************************************/
            // Manualis klonozas
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Manualis klonozas:\n");
            int[] aTomb = new int[2];
            aTomb[0] = 3;
            aTomb[1] = 10;
            //--------------------------------------
            // int[] bTomb = aTomb;
            int[] bTomb = new int[2];
            for (int i = 0; i < 2; i++)
            {
                bTomb[i] = aTomb[i];
            }
            bTomb[0] = 5;
            bTomb[1] = aTomb[0] + 10;
            Console.WriteLine("Az eredmeny: aTomb[0] = {0}, aTomb[1] = {1}, bTomb[0] = {2}, aTomb[1] = {3}\n", aTomb[0], aTomb[1], bTomb[0], bTomb[1]);
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();
        }
        public static void ReferenciaAtadasString()                            // Ertekatadas pálda egy sztring átadáasa egy metódussal
        {
            /*************************************************************/
            // Ertekatadas pelda
            /*************************************************************/

            Console.Clear();
            Console.WriteLine("Ertekatadas a Connsole.WriteLine(szoveg); metodussal ez referencia atadas:\n");
            string szoveg = "Hello vilag!";
            Console.WriteLine(szoveg); // Itt a szoveg valtozot atadtam egy funkciónak, aki azt ki fogja irni a standard kimenetre. --> Tehát ugyanolyan ertekatadas tortent, mintha legyen egyenlő operátort hasznaltam volna. Mivel a string primitiv tipusnak szamit c#-ban, igy az eteket lemasoltuk a meoriaba
            // Funkcio(tomb) --> itt csak hivatkozast adok meg a tombre, nem masolom at a memoriaban, mint az elozo string-et
            Console.WriteLine("\nNyomj egy gombot!");
            Console.ReadKey();
        }
        public static void MaximumKeresesHiba()                                       // Maximum kereses hiba kereses gyakorlása
        {
            /*************************************************************/
            // Hiba kereses
            /*************************************************************/

            // Hibakereses soran szemantikai hibákat probaljuk feltárni --> a program valalmilyen logikai hibaval rendelkezik, de futaskepes
            int[] szamok = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Adja meg a(z) {0}. szamot", i + 1);
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxElem = szamok[0]; // C alalpu nyelvekben 0-tol indul az index szamozas
            for (int i = 1; i < 5; i++)
            {
                if (maxElem < szamok[i])
                {
                    maxElem = szamok[i];
                }
            }
            Console.WriteLine("A megadott szamok kozul a legnagyobb: " + maxElem);
            Console.ReadKey();
        }
        public static void TanulokAtlaga()                                            // Tanulok jegye es neve alapján az átlag, legrosszab, legjobb jegyek kiiratasa, bekert adatok védelmével
        {
            /*************************************************************/
            // Tanulo adatainak bekerese es atlagolasa
            /*************************************************************/

            Console.WriteLine("Adja meg, hogy hany tanulo lesz!");
            int letszam = Convert.ToInt32(Console.ReadLine());
            byte[] jegyek = new byte[letszam];
            string[] nevek = new string[letszam];
            // A tarolas logkank, hogy az i-dik nevhez, az i-dik jegy tartozik --> index alapu a ket adatszerkezet kozotti osszeköttetes
            Console.Clear();
            for (int i = 0; i < letszam; i++)
            {
                Console.WriteLine("Adja meg {0}. tanulo nevet!", i + 1);
                nevek[i] = Console.ReadLine();
                Console.WriteLine("Adja meg a(z) {0}. tanulo ({1}) jegyet!", i + 1, nevek[i]);
                // jegy bekeres karakteres vedelme
                char bekert;
                do
                {
                    bekert = Console.ReadKey().KeyChar;
                    //} while (bekert < 49 || bekert > 53); // 49 - 1 es 53 - 5 
                } while (bekert < '1' || bekert > '5'); // ugyanaz jelenti mint fent csak a nyelvre bizzuk a kiertekelest 

                jegyek[i] = Convert.ToByte(bekert.ToString());
                Console.Clear();
            }

            // Atlagszamitas
            double atlag = 0;
            for (int i = 0; i < letszam; i++)
            {
                atlag += jegyek[i]; // atlag = atlag + jegyek[i];
            }
            atlag /= letszam; // atlag = atlag / letszam;

            Console.WriteLine("A megadott tanulok átlaga: " + atlag);

            //Legjobb es legrosszabb tanulo meghatarozasa
            int n = jegyek.Length;  //Az n a tömb mérete
            int max_index = 0;
            int min_index = 0;

            int max = jegyek[0];
            int min = jegyek[0];
            for (int i = 0; i < n; i++)
            {
                if (jegyek[i] > max) // legjobb tanulo
                {
                    max = jegyek[i];
                    max_index = i;
                }

                if (jegyek[i] < min) // legrosszabb tanulo
                {
                    min = jegyek[i];
                    min_index = i;
                }
                Console.SetCursorPosition(0, Console.CursorTop);
            }
            // Kiiratas
            Console.WriteLine("\nA Legjobb tanulo: {0} jegye: {1}", nevek[max_index], max);
            Console.WriteLine("\nA Legjobb tanulo: {0} jegye: {1}", nevek[min_index], min);
            Console.ReadKey();

        }
        public static void ButorokCikkszamokArakV1()                                  // Butor cikkszamok és árak ellenörzése saját megoldás indexek különtárolásával
        {
            /*************************************************************/
            // Butor cikkszamok és árak ellenörzése
            /*************************************************************/
            int darabszam;
            Console.WriteLine("Irja be a darabszamot!");
            darabszam = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string[] cikkszam = new string[darabszam];
            int[] arak = new int[darabszam];
            //int darabszan = 0;
            int[,] indexek = new int[3, arak.Length];  //  ketdimenzios tomb olcso 1, kozoeoes 2, draga 0, oszlopopkkal

            for (int i = 0; i < darabszam; i++)
            {
                Console.WriteLine("Irja be az {0}. cikkszamot:  ", i + 1);
                cikkszam[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Irja be az {0}. arat:  ", i + 1);
                arak[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            // Eldontes
            bool voltKoztesTermek = false;  // alapból hamis
            int j = 0;
            while ((j < darabszam) && !((arak[j] > 10000) && (arak[j] < 15000)))
            {
                j++;
            }
            voltKoztesTermek = (j < darabszam);

            // Szetvalogatas
            string[] olcsobb = new string[darabszam], kozepes = new string[darabszam], dragabb = new string[darabszam];
            int o = 0, k = 0, d = 0;

            for (int i = 0; i < darabszam; i++)
            {
                if (arak[i] < 30000)
                {
                    olcsobb[o] = cikkszam[i];
                    indexek[0, o] = i + 1;
                    o++;
                }
                else if (arak[i] >= 30000 && arak[i] <= 50000)
                {
                    kozepes[k] = cikkszam[i];
                    indexek[1, k] = i + 1;
                    k++;
                }
                else
                {
                    dragabb[d] = cikkszam[i];
                    indexek[2, d] = i + 1;
                    d++;
                }
            }

            int max = 0;
            for (int e = 0; e < darabszam; e++)
            {
                if (arak[max] < arak[e])
                {
                    max = e;
                }
            }

            Console.Clear();
            if (voltKoztesTermek)
            {
                Console.WriteLine("Az arak kozott volt 10-15 ezer közötti termék!\n");
            }
            else
            {
                Console.WriteLine("Az arak kozott nem volt 10-15 ezer közötti termék!\n");
            }
            Console.WriteLine("A legmagasabb aru termek ara: {0}\n", arak[max]);


            Console.WriteLine("\n\nOlcso aruak:\n");
            Console.WriteLine("    ----------------------------");
            Console.WriteLine("\tCikkszam:\tAr:");
            Console.WriteLine("    ----------------------------");
            for (int i = 0; i < darabszam; i++)
            {
                if (indexek[0, i] != 0)
                {
                    Console.WriteLine("\t{0}\t\t{1}", olcsobb[i], arak[indexek[0, i] - 1]);
                }

            }

            Console.WriteLine("\n\nKozepes aruak:\n");
            Console.WriteLine("    ----------------------------");
            Console.WriteLine("\tCikkszam:\tAr:");
            Console.WriteLine("    ----------------------------");
            for (int i = 0; i < darabszam; i++)
            {
                if (indexek[1, i] != 0)
                {

                    Console.WriteLine("   {0}       {1}", kozepes[i], arak[indexek[1, i] - 1]);
                }
            }

            Console.WriteLine("\n\nDraga aruak:\n");
            Console.WriteLine("    ----------------------------");
            Console.WriteLine("\tCikkszam:\tAr:");
            Console.WriteLine("    ----------------------------");
            for (int i = 0; i < darabszam; i++)
            {
                if (indexek[2, i] != 0)
                {

                    Console.WriteLine("   {0}       {1}", kozepes[i], arak[indexek[2, i] - 1]);
                }
            }


            Console.ReadKey();
        }
        public static void ButorokCikkszamokArakV2()                                  // Butor cikkszamok és árak ellenörzése, tanárral megoldva
        {
            /*************************************************************/
            // Butor cikkszamok és árak ellenörzése
            /*************************************************************/
            int darabszam;
            Console.WriteLine("Adja meg hány bútor lesz a raktárban!");
            darabszam = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string[] cikkszam = new string[darabszam];
            int[] arak = new int[darabszam];

            for (int i = 0; i < darabszam; i++)
            {
                Console.WriteLine("Irja be az {0}. cikkszamot:  ", i + 1);
                cikkszam[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Irja be az {0}. arat:  ", i + 1);
                arak[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            // Eldontes
            int j = 0;
            // while (( j < darabszam ) && (( arak[j] < 10000 ) || (arak[j] > 15000))) // Demorgan azonosság miatt igy is lelehet irni a feltetelt
            while ((j < darabszam) && !((arak[j] >= 10000) && (arak[j] <= 15000)))
            {
                j++;
            }
            bool voltKoztesTermek = (j < darabszam);

            // Szetvalogatas
            string[] olcsobb = new string[darabszam], kozepes = new string[darabszam], dragabb = new string[darabszam];
            int o = 0, k = 0, d = 0;

            for (int i = 0; i < darabszam; i++)
            {
                if (arak[i] < 30000)
                {
                    olcsobb[o] = cikkszam[i];
                    o++;
                }
                else if (/*arak[i] >= 30000 &&*/ arak[i] <= 50000)  // nem érdekes mert már a 30000 egyszer le volt kérdezve
                {
                    kozepes[k] = cikkszam[i];
                    k++;
                }
                else
                {
                    dragabb[d] = cikkszam[i];
                    d++;
                }
            }

            int max = 0;
            for (int i = 1; i < darabszam; i++)  // i = 1 mert ha 0 lenne akkor az első az lenne, hogy önnmagával hasonlítaná össze
            {
                if (arak[max] < arak[i])
                {
                    max = i;
                }
            }

            Console.Clear();
            Console.WriteLine("A megedott bútorok között {0} 10000 és 15000 közöti árrla rendelkező.", voltKoztesTermek ? "volt" : "nem volt");
            Console.WriteLine("Az ar szerinti bontás eredmény:");

            Console.WriteLine("A 30000-nél olcsóbb bútorok:");
            if (o > 0)
            {
                for (int i = 0; i < o; i++)
                {
                    Console.WriteLine("\t- {0}", olcsobb[i]);
                }
            }
            else
            {
                Console.WriteLine("\tNem volt ilyen bútor");
            }

            Console.WriteLine("A 30000-nél drágáb, de 50000-nél olcsóbb bútorok:");
            if (k > 0)
            {
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("\t- {0}", kozepes[i]);
                }
            }
            else
            {
                Console.WriteLine("\tNem volt ilyen bútor");
            }

            Console.WriteLine("A 50000-nél drágább bútorok:");
            if (d > 0)
            {
                for (int i = 0; i < d; i++)
                {
                    Console.WriteLine("\t- {0}", dragabb[i]);
                }
            }
            else
            {
                Console.WriteLine("\tNem volt ilyen bútor");
            }

            Console.WriteLine("A megadott bútorok közül a legdrágább: " + cikkszam[max]);
            Console.WriteLine("");
            Console.ReadKey();

        }
        public static void ButorokCikkszamokArakV3()                                  // Butor cikkszamok, strukúrákba rendezve, önnálóan és a tanárral befejezves
        {
            /*************************************************************/
            // Butor cikkszamok és árak ellenörzése
            /*************************************************************/

            Console.WriteLine("Adja meg hány bútor lesz a raktárban!");
            Butor[] butorok = new Butor[Convert.ToInt32(Console.ReadLine())];
            Console.Clear();

            for (int i = 0; i < butorok.Length; i++)
            {
                Console.WriteLine("Irja be az {0}. cikkszamot:  ", i + 1);
                bool voltBekeres = false;
                do
                {
                    if (voltBekeres)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" A magadott érték hibás! A cikkszám nem lehet üres!");
                        Console.ResetColor();
                    }
                    butorok[i].cikkszam = Console.ReadLine();
                    voltBekeres = true;
                    //} while ( butrorok[i].cikkszam == ""); // "" = üres szöveg
                    //} while ( butrorok[i].cikkszam ==string.Empty); // string.Empty = üres szöveg
                } while (string.IsNullOrWhiteSpace(butorok[i].cikkszam)); // string.IsNullOrWhiteSpace ("szöveg") = megadja, hogy a szöveh üres, vagy szóköyöket tratalmaz csupán

                Console.WriteLine("Irja be az {0}. bútor ({1}) árát:  ", i + 1, butorok[i].cikkszam);
                voltBekeres = false;
                do
                {
                    if (voltBekeres)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A megadott ár hibás! Az ár minimum 1 Ft kell legyen!");
                        Console.ResetColor();
                    }
                    butorok[i].arak = Convert.ToInt32(Console.ReadLine());
                    voltBekeres = true;

                } while (butorok[i].arak < 1);
                Console.Clear();
            }

            // Eldontes
            int j = 0;
            while ((j < butorok.Length) && !((butorok[j].arak >= 10000) && (butorok[j].arak <= 15000)))
            {
                j++;
            }
            bool voltKoztesTermek = (j < butorok.Length);

            // Szetvalogatas
            Butor[] olcsobb = new Butor[butorok.Length];
            Butor[] kozepes = new Butor[butorok.Length];
            Butor[] dragabb = new Butor[butorok.Length];
            int o = 0, k = 0, d = 0;

            for (int i = 0; i < butorok.Length; i++)
            {
                if (butorok[i].arak < 30000)
                {
                    olcsobb[i] = butorok[i];
                    o++;
                }
                else if (butorok[i].arak <= 50000)  // nem érdekes mert már a 30000 egyszer le volt kérdezve
                {
                    kozepes[k] = butorok[i];
                    k++;
                }
                else
                {
                    dragabb[d] = butorok[i];
                    d++;
                }
            }

            Butor max = new Butor();
            for (int i = 1; i < butorok.Length; i++)  // i = 1 mert ha 0 lenne akkor az első az lenne, hogy önnmagával hasonlítaná össze
            {
                if (max.arak < butorok[i].arak)
                {
                    max = butorok[i];
                }
            }

            Console.Clear();
            Console.WriteLine("A megedott bútorok között {0} 10000 és 15000 közöti árrla rendelkező.", voltKoztesTermek ? "volt" : "nem volt");
            Console.WriteLine("Az ar szerinti bontás eredmény:");

            Console.WriteLine("A 30000-nél olcsóbb bútorok:");
            if (o > 0)
            {
                for (int i = 0; i < o; i++)
                {
                    Console.WriteLine($"\t- {olcsobb[i].cikkszam} ({olcsobb[i].arak} FT)");
                }
            }
            else
            {
                Console.WriteLine("\tNem volt ilyen bútor");
            }

            Console.WriteLine("A 30000-nél drágáb, de 50000-nél olcsóbb bútorok:");
            if (k > 0)
            {
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine($"\t- {kozepes[i].cikkszam} ({kozepes[i].arak} FT)");
                }
            }
            else
            {
                Console.WriteLine("\tNem volt ilyen bútor");
            }

            Console.WriteLine("A 50000-nél drágább bútorok:");
            if (d > 0)
            {
                for (int i = 0; i < d; i++)
                {
                    Console.WriteLine($"\t- {dragabb[i].cikkszam} ({dragabb[i].arak} FT)");
                }
            }
            else
            {
                Console.WriteLine("\tNem volt ilyen bútor");
            }

            Console.WriteLine("A megadott bútorok közül a legdrágább: " + max.cikkszam + " - " + max.arak + " FT");
            Console.WriteLine("");
            // string a = §"gdgdgdggdgd {max.ar} fgdfgdggggd {m}";  // c# 6.0 <=
            // string a = "fsfdfsf" + max.ar + "ggdfgfgdg" + m;
            // string a = string.Format("gdfgdgdg {0} gdgdgdgd {1}", max.ar, m );

            Console.ReadKey();

        }
        public static void TanulokAtlagaStruct()                                      // Tanulók jegyei strukúrákban rendezve
        {
            Console.WriteLine("Adja meg hány tanuló lesz!");
            // Eddig itt minden esetben lementettük a létszámot külön vátozóba, de igazából erre nincs szükség, mert a tömb tudja magától, hogy mekkora
            Tanulo[] tanulok = new Tanulo[Convert.ToInt32(Console.ReadLine())];
            Console.Clear();
            // tanulok.Length --> Létszám
            for (int i = 0; i < tanulok.Length; i++)
            {
                Console.WriteLine("Adja meg a(z) {0}. tanuló nevét!:", i + 1);
                tanulok[i].nev = Console.ReadLine();
                Console.WriteLine("Adja meg a(z) {0} tanuló ({1}) jegyét!:", i + 1, tanulok[i].nev);
                tanulok[i].jegy = Convert.ToByte(Console.ReadKey().KeyChar.ToString());
                Console.Clear();
            }

            // Átlagszámítás
            double atlag = 0;
            for (int i = 0; i < tanulok.Length; i++)
            {
                atlag += tanulok[i].jegy;
            }
            atlag /= tanulok.Length;
            // Itt az érték szerinti megoldás is működik mivel a komplex Tanulo típus a nevet és a jegyet is tárolja - így ha megtalálom a tnault akkor tudom a jegyét és a nevét is

            //----------------------------------
            // Megoldás érték szerint
            //-----------------------------------

            Tanulo min = tanulok[0], max = tanulok[0]; // Itt az érték szerinti megoldásnál az elején a tömb első elemét mentem ki mint referencia elem
            for (int i = 0; i < tanulok.Length; i++)
            {
                if (min.jegy < tanulok[i].jegy)
                {
                    min = tanulok[i]; // A tlejes tanulot lementem névvel és jeggyel együtt
                }

                if (max.jegy > tanulok[i].jegy)
                {
                    max = tanulok[i]; // A tlejes tanulot lementem névvel és jeggyel együtt
                }
            }

            //----------------------------------
            // Megoldás index szerint
            //-----------------------------------

            int minIndex = 0, maxIndex = 0; // Itt csak indexet tárolunk
            for (int i = 0; i < tanulok.Length; i++)
            {
                if (tanulok[maxIndex].jegy < tanulok[i].jegy)
                {
                    maxIndex = i;
                }

                if (tanulok[minIndex].jegy > tanulok[i].jegy)
                {
                    minIndex = i;
                }


            }
            // Kiiratás

            Console.WriteLine("A megadott tanulók átlaga: " + atlag);
            Console.WriteLine("A legjobb tanuló érték szerint: " + max.nev);
            Console.WriteLine("A rosszabb tanuló érték szerint: " + min.nev);
            Console.WriteLine("A legjobb tanuló index szerint: " + tanulok[maxIndex].nev);
            Console.WriteLine("A rosszabb tanuló index szerint: " + tanulok[minIndex].nev);
            Console.ReadKey();
        }
        public static void NevekSzetvalgatas()                                        // Nevek bekérése és szétválogatása
        {
            Console.WriteLine("Adja meg, hogy hány név lesz!");
            string[] nevek = new string[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine($"Adaj meg a(z) {i + 1}. nevet!");
                bool voltBekeres = false;
                do
                {
                    if (voltBekeres)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A megadott név hibás lagalább 1 karakter megadása kötelező!");
                        Console.ResetColor();
                    }
                    nevek[i] = Console.ReadLine();
                    voltBekeres = true;
                } while (string.IsNullOrWhiteSpace(nevek[i]));
            }

            // Hánnnny M     bbbbetúvel kezdődő név van a - megszámlámlás
            int mBetusNevekszama = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                // if (nevek[i].ToCharArray()[0] == 'M') // ez is jó
                if (nevek[i][0] == 'M')
                {
                    mBetusNevekszama++;
                }
            }

            // Van-e Jkab nevű ember - eldöntés
            int j = 0;
            while (j < nevek.Length && nevek[j] != "Jakab")
            {
                j++;
            }
            bool voltJakab = j < nevek.Length;

            // Első H betű mentén való szétválogatás - Kiválasztás + Szétválogatás --> egybeépítve
            // Az egybépítés során minden esetben a fixen hosszabb lefutással rendelkezőbe építjük a rövidebb lefutással rendelkezőt
            string[] elotte = new string[nevek.Length], utana = new string[nevek.Length];
            int k = 0, l = 0;
            bool voltH = false;
            for (int i = 0; i < nevek.Length; i++)
            {
                // Eldöntés beépítve
                if (!voltH && nevek[i][0] == 'H')
                {
                    voltH = true;
                }
                // Szétválogatás
                if (!voltH)
                {
                    elotte[k] = nevek[i];
                    k++;
                }
                else
                {
                    utana[l] = nevek[i];
                    l++;
                }
            }
            Console.Clear();
            // Kiíratás
            Console.WriteLine((voltJakab ? "Volt" : "Nem volt") + " Jakab a nevek között!");
            Console.WriteLine("A megadott nevek között {0} db 'M' betűvel kezdődő név volt!", mBetusNevekszama);
            Console.WriteLine("Az első 'H' betűvel kezdődő név elötti nevek:");
            if (k > 0)
            {
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("\t- " + elotte[i]);
                }
            }
            else
            {
                Console.WriteLine("\tNem volt ilyen név!");
            }
            Console.WriteLine("Az első 'H' betővel kezdődő név és azt követő nevek:");
            if (l > 0)
            {
                for (int i = 0; i < l; i++)
                {
                    Console.WriteLine("\t- " + utana[i]);
                }
            }
            else
            {
                Console.WriteLine("\tNem volt ilyen név!");
            }
            Console.ReadKey();
        }
        public static void LinearisBinarisIdo()                                       // Lineáris és Bináris keresés időben való lemérése
        {
            /*************************************************************/
            // Binaris és lineéris keresés lefutási idők mérése 
            /*************************************************************/

            // Ahhoz, hogy az időt letudjuk mérni egy hatalmas tömb kell --> több száz MB / több GB méretű
            //int[] tomb = new int[int.MaxValue]; // nyolc GB méretű lenne
            Console.WriteLine("Kérem várjon ...");
            int[] tomb = new int[int.MaxValue / 7];
            Random r = new Random(); // ezzel létrehoztuk a véletlenszámgenerátort
            tomb[0] = r.Next(1, 11); // 1..10
            for (int i = 1; i < tomb.Length; i++)
            {
                tomb[i] = tomb[i - 1] + r.Next(1, 6) - 1; // a tömb i-edik eleme legyen egyenlő a tömb előző elem + 0..4 egy véletlen szám -- monoton növekvő
            }
            Console.Clear();
            Console.WriteLine("Adja meg a keresendő elemet. (A tartomány: {0} ... {1})", tomb[0], tomb[tomb.Length - 1]);
            int keresett = Convert.ToInt32(Console.ReadLine());
            Stopwatch ora = new Stopwatch(); // Ezzel létrhoztunk egy stoppert

            // lineáris keresés
            ora.Start();
            int j = 0;
            while (j < tomb.Length && tomb[j] != keresett)
            {
                j++;
            }
            ora.Stop();
            Console.WriteLine("A lineáris keresés {0} ms alatt futott le, {1} lefutása volt és az értéket {2}.", ora.ElapsedMilliseconds, j, (j < tomb.Length && tomb[j] == keresett) ? "megtalálta" : "nem találta meg");
            Console.ReadKey();

            // bináris keresás
            ora.Restart();
            int e = 0, u = tomb.Length - 1, k;
            j = 0;
            do
            {
                k = (e + u) / 2;
                if (tomb[k] > keresett)
                {
                    u = k - 1;
                }
                else if (tomb[k] < keresett)
                {
                    e = k + 1;
                }
                j++;
            } while (e <= u && tomb[k] != keresett);
            ora.Stop();
            Console.WriteLine("A bináris keresés {0} ms alatt futott le, {1} lefutása volt és az értéket {2}.", ora.ElapsedMilliseconds, j, (e <= u) ? "megtalálta" : "nem találta meg");
            Console.ReadKey();
        }
        public static void NegyAlapmuveletMain(string[] argsTomb)                     // Negy alapmuvelet veegrehajtasa metodussal main fuggveny
        {
            /*************************************************************/
            // Paraméterek ellenőrzése ha van értékadás, ha ninics bekérés
            /*************************************************************/
            int szam1 = 0, szam2 = 0;
            char muvelet = ' ';
            if (argsTomb.Length != 0)
            {
                for (int i = 0; i < argsTomb.Length; i++)
                {
                    switch (argsTomb[i])
                    {
                        case "-a":
                            szam1 = Convert.ToInt32(argsTomb[i + 1]);
                            break;
                        case "-b":
                            szam2 = Convert.ToInt32(argsTomb[i + 1]);
                            break;
                        case "-muvelet":
                            muvelet = Convert.ToChar(argsTomb[i + 1]);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {

                /*************************************************************/
                // Negy alapmuvelet végrehajtasa metodussal bekérés és végrehajtás
                /*************************************************************/

                Console.WriteLine("Adja meg az első operandust!");
                szam1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Adja meg az második operandust!");
                szam2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Adja meg a műveletet!");
                muvelet = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            double eredmeny = NegyAlapmuveletMetodus(szam1, szam2, muvelet); // negy alap múvelet methodus
            if (double.IsNaN(eredmeny))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A megadott művelet helytelen!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Az eredmény: " + eredmeny);
            }
            Console.ReadKey();

        }
        public static void NegyAlapmuveletMainTanarral(string[] argumentumok)         // Negy alapmuvelet veegrehajtasa metodussal --> tanarral
        {
            /*************************************************************/
            // Negy alapmuvelet tanarral ez ha rossz sorrendben adjuk meg lefagy
            /*************************************************************/
            if (argumentumok.Length == 3)
            {
                double eredmeny = NegyAlapmuveletMetodus(Convert.ToInt32(argumentumok[0]), Convert.ToInt32(argumentumok[1]), argumentumok[2][0]);
                if (double.IsNaN(eredmeny))
                {
                    ConsoleError("A megadott művelet helytelen!");
                }
                else
                {
                    Console.WriteLine("Az eredmény: " + eredmeny);
                }
            }
            else
            {
                ConsoleError("Az argumentumok száma helytelen!");
            }
        }
        public static void ConsoleError(string errorText)                             // Konzol hiba üzenet pirossal
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorText);
            Console.ResetColor();
        }
        public static double NegyAlapmuveletMetodus(int a, int b, char muvelet)       // Negy alapmuvelet vegrehajtasa metodus
        {
            /*************************************************************/
            // Negy alapmuvelet veegrehajtasa metodussal
            /*************************************************************/

            switch (muvelet)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    //return a / b;
                    //return Convert.ToDouble(a) / b; // Ha az elso szamot konvertaljuk akkor az opertor is double lesz es igy a vissza teresi ertek is az lesz es a masodik szam integer tehat belefer a double-ba
                    return a * 1.0 / b; // Mostmar a ket egesz szam hanyadosa tortkent all elo es a nullaval valo osztas sem okoz problemat... --> Mivel a double a matematikai analizisben hasznalt specialsi erteket is tartalmazza, igy amikor ket double szamot lehosztok egy massal, akkor az eredmeny nem egzakt eredmeny, hanem kovergalt eredmeny lesz ( tehat azt kapom meg, hogy az ertek hova konvergal) --> 4.0 / 0.0 --> tehat 4-et leosztom egy 0-at vegtelenul megkozelito ertekkel --> Pozitiv vegtelen az eredmeny -4.0 / 0.0 --> pedig negativ vegtelen es 0 / 0 --> NaN (Not a Number)
                default:
                    //return 0; // Ebbol nem jovunk ra, hogy ez egy hibas lefutas
                    // Consolee.WriteLine("Hibas!"); /// Minden keppen ertekkel kell visszternunk
                    return double.NaN;
            }
        }
        public static string SzovegEkezetMentesitese(string alapSzoveg)               // Szöveg ékezet mentesítése
        {
            /*************************************************************/
            // Szöveg ékezet mentesítése
            /*************************************************************/
            // AlapSzovrg[0] = 'A'; --> eu nem működik egy szöveget nem lehet módósítani -- nem módosítható objectum
            string mentesitettSzoveg = ""; // string.Empty;
            string csere = "öüóőúéáűíÖÜÓŐÚÉÁŰÍ", ujCsere = "ouooueauiOUOOUEAUI";
            for (int i = 0; i < alapSzoveg.Length; i++)
            {
                // alapSzoveg[i] --> mindne esetben kijelöli a következö karaktert a szövegben amelyről elkel dönteni, hogy cserélendő-e - ha igen akkor a csere változatát, ha nem akkor sajátmagát rakjuk bele a mentesitettSzoveg-be
                int keresesIndex = SzovegLinearisKeresese(csere, alapSzoveg[i]);
                if (keresesIndex == -1)
                {
                    mentesitettSzoveg += alapSzoveg[i]; // Nivel nem találtuk meg ezért sajátmagát rakjuk be az új szövegbe is --> nem ékezetes a krakter

                }
                else // megtalálta a Linearis keresés
                {
                    mentesitettSzoveg += ujCsere[keresesIndex]; // Ezzel tehát az ékezetes karakter új változatát raktuk bele a szövegbe
                }
            }
            return mentesitettSzoveg;
        }
        public static int SzovegLinearisKeresese(string miben, char mit)              // Egy megadott karakter lineáris keresésa a megadott szövegben 
        {
            /*************************************************************/
            // Egy megadott karakter lineáris keresésa a megadott szövegben
            /*************************************************************/
            int i = 0;
            while (i < miben.Length && miben[i] != mit)
            {
                i++;
            }
            return (i < miben.Length) ? i : -1;
        }
        public static int FaktorialisCiklussal(int hanyadik)                          // Faktorialis kiszamitasa ciklussal
        {
            /*************************************************************/
            // Faktorialis kiszamitasa ciklussal
            /*************************************************************/
            int eredmeny = hanyadik;
            for (hanyadik--; hanyadik >= 1; hanyadik--)
            {
                eredmeny *= hanyadik;
            }
            return eredmeny;
        }
        public static int FaktorialisRekurziv(int hanyadik)                           // Faktorialis kiszamitasa rekurziv megoldassal
        {
            /*************************************************************/
            // Faktorialis kiszamitasa rekurziv megoldassal
            /*************************************************************/
            if (hanyadik > 1)
            {
                return hanyadik * FaktorialisRekurziv(hanyadik - 1);
            }
            return 1;
        }
        public static int FaktorialisRekurziv2(int hanyadik)                          // Faktorialis kiszamitasa rekurziv megoldassal egszerubben
        {
            /*************************************************************/
            // Faktorialis kiszamitasa rekurziv megoldassal egszerubben
            /*************************************************************/
            return (hanyadik > 1) ? hanyadik * FaktorialisRekurziv(hanyadik - 1) : 1;
        }
        public static int FibonacciCiklussal(int hanyadik)                            // Fibonacci szam kiszamitasa ciklussal
        {
            /*************************************************************/
            // Fibonacci szam kiszamitasa ciklussal
            /*************************************************************/
            if (hanyadik > 2)
            {
                int elozo = 1, elozoElotti = 1, eredemny = elozo + elozoElotti;
                for (int i = 4; i <= hanyadik; i++)
                {
                    elozoElotti = elozo;
                    elozo = eredemny;
                    eredemny = elozo + elozoElotti;
                }
                return eredemny;
            }
            return 1;
        }
        public static int FibonacciRekurziv(int hanyadik)                             // Fibonacci szam kiszamitasa rekurziv megoldassal
        {
            /*************************************************************/
            // Fibonacci szam kiszamitasa rekurziv megoldassal
            /*************************************************************/
            if (hanyadik > 2)
            {
                return FibonacciRekurziv(hanyadik - 1) + FibonacciRekurziv(hanyadik - 2);
            }
            return 1;
        }
        public static void BeepitettRendezes()                                        // Array.Sort() rendezes hasznalata
        {
            /*************************************************************/
            // Array.Sort() rendezes hasznalata
            /*************************************************************/
            int[] szamok = new int[20];
            Random r = new Random();
            Console.WriteLine("A szamok rendezs elott:");
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = r.Next(-1000, 1001);
                Console.Write(szamok[i] + "; ");
            }
            Console.WriteLine("\n");
            Array.Sort(szamok);
            Console.WriteLine("A szamaok rendezes utan:");
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + "; ");
            }
            Console.WriteLine();
        }

        /*************************************************************/
        // Auto rendszamok kezdete
        /*************************************************************/

        static int AutoKiválaszt(Auto[] autok)                                        // minimum allapot keresese
        {
            int n = autok.Length;  //Az n a tömb mérete
            int min, index = -1;

            min = autok[0].allapot;
            for (int i = 1; i < n; i++)
            {
                if (autok[i].allapot < min)
                {
                    min = autok[i].allapot;
                    index = i;
                }
            }
            return index;
        }
        static void HibaUzenet1(string uzenet)                                        // hibauzenet
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(uzenet);
            Console.ResetColor();
        }
        static void HibaUzenet2(string uzenet, Auto[] autok, int i)                  // hibauzenet
        {
            HibaUzenet1(uzenet);
            autok[i].rendszam = Console.ReadLine();
        }
        static void BekeresRendszam(string uzenet, Auto[] autok, int i)              // rendszam bekerese
        {
            bool voltBekeres = false;
            do
            {
                if (voltBekeres)
                {
                    HibaUzenet1(uzenet);
                }
                autok[i].rendszam = Console.ReadLine();
                voltBekeres = true;
            } while (string.IsNullOrWhiteSpace(autok[i].rendszam));
        }
        static void BekeresAllapot(string uzenet, Auto[] autok, int i)               // allapot  bekerese
        {
            bool voltBekeres = false;
            do
            {
                if (voltBekeres)
                {
                    HibaUzenet1(uzenet);
                }
                autok[i].allapot = Convert.ToInt32(Console.ReadLine());
                voltBekeres = true;
            } while (string.IsNullOrWhiteSpace(autok[i].rendszam));
        }
        static bool RendszamLekerdezes(Auto[] autok, int i, bool hibasRendszam)      // a rendszam ellenorzese
        {
            hibasRendszam = autok[i].rendszam.Length != 7;
            hibasRendszam = !Char.IsLetter(autok[i].rendszam[0]);
            hibasRendszam = !Char.IsLetter(autok[i].rendszam[1]);
            hibasRendszam = !Char.IsLetter(autok[i].rendszam[2]);
            hibasRendszam = autok[i].rendszam[3] == '-';
            hibasRendszam = !Char.IsDigit(autok[i].rendszam[4]);
            hibasRendszam = !Char.IsDigit(autok[i].rendszam[5]);
            hibasRendszam = !Char.IsDigit(autok[i].rendszam[6]);
            return hibasRendszam;
        }
        public static void AutoRendszamok()
        {
            Console.WriteLine("Adja meg hány auto adatait szeretné rögzíteni! (XXX-XXX)");
            Auto[] autok = new Auto[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < autok.Length; i++)
            {
                // rendszámok
                //----------------------------------------------------------------------------------------------
                Console.WriteLine("Irja be az {0}. autó rendszámát:  ", i + 1);
                BekeresRendszam(" A magadott szám hibás! A Rendszám nem lehet üres!", autok, i);
                bool hibasRendszam;
                do
                {
                    hibasRendszam = false;
                    if (autok[i].rendszam.Length != 7)
                    {
                        HibaUzenet2(" A Rendszám hibás!", autok, i);
                        hibasRendszam = true;
                    }
                    else
                    {
                        hibasRendszam = false;
                        if (RendszamLekerdezes(autok, i, hibasRendszam))
                        {
                            HibaUzenet2(" A Rendszám hibás!", autok, i);
                        }
                    }
                } while (hibasRendszam);

                // állapot
                //----------------------------------------------------------------------------------------------
                Console.WriteLine("Irja be az {0}. ({1}) rendszamú autó  állapotát:  ", i + 1, autok[i].rendszam);
                BekeresAllapot("A megadott állapot hibás! (0-100) ", autok, i);
                Console.Clear();
            }
            int eredmeny = AutoKiválaszt(autok);
            Console.WriteLine("A legrosszabb allapotban levő autó rendszáma {0} és álapota {1}", autok[eredmeny].rendszam, autok[eredmeny].allapot);
            Console.ReadKey();
        }                                       // a funkciók mehívása és a rendszámok bekérése illetve ellenörzése


        /*************************************************************/
        // Auto rendszamok Tanárral
        /*************************************************************/

        struct AutoT
        {
            public string rendszam;
            public byte allapot;
        }

        // Reguláris kifejezések alkalmazása: [A-Za-Z]{3}\-[0-9]{3}
        // }while(Regex.IsMatch(autok[i].rendszam, "[A-Za-Z]{3}-[0-9]{3}"));

        static AutoT MinimumKivalasztas(AutoT[] autokT)
        {
            AutoT min = autokT[0];
            for (int i = 0; i < autokT.Length; i++)
            {
                if (min.allapot > autokT[i].allapot)
                {
                    min = autokT[i];
                }
            }
            return min;
        }
        static void Kiiratas(string szoveg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(szoveg);
            Console.ResetColor();
        }
        public static void AutoRendszamokTanar()
        {
            Console.WriteLine("Adja meg hány autó lesz!");
            bool voltMarBekeres = false;
            int elemszam = 0;
            do
            {
                if (voltMarBekeres)
                {
                    Kiiratas("A megadott elemszám nem megfelelő!");
                }
                elemszam = Convert.ToInt32(Console.ReadLine());
                voltMarBekeres = true;
            } while (elemszam < 1);
            AutoT[] autokT = new AutoT[elemszam];
            for (int i = 0; i < autokT.Length; i++)
            {
                Console.WriteLine("Adja meg a(z) {0}. autó rendszámát!", i + 1);
                voltMarBekeres = false;
                do
                {
                    if (voltMarBekeres)
                    {
                        Kiiratas("A megadott rendszám üres!");
                    }
                    autokT[i].rendszam = Console.ReadLine();
                    voltMarBekeres = true;
                } while (string.IsNullOrWhiteSpace(autokT[i].rendszam));
                //}while(autok[i].rendszam = "");
                //}while(autok[i].rendszam = String.Empty);
                Console.WriteLine("Adja meg a(z) {0}. autó ({1}) állapotát", i + 1, autokT[i].rendszam);

                voltMarBekeres = false;
                do
                {
                    if (voltMarBekeres)
                    {
                        Kiiratas("Az autók állapota 0 és 100 között lehet!");

                    }
                    autokT[i].allapot = Convert.ToByte(Console.ReadLine());
                    voltMarBekeres = true;
                } while (autokT[i].allapot > 100); // mert a Byte nem tárol előjelet
                //}while(autok[i].allapot > 100 || autok[i].allapot < 0); // ha int mert a Integerben lehet negatív szám

                //*****************************************************************
                // ha nem üznek be semmi akkor így lehet ellenőrizni
                //*****************************************************************
                //string ideiglenesAllapot;
                //do{
                //    if .....
                //    ideiglenesAllapot = Console.ReadLine();
                //    ideiglenesAllapot = ture;
                //}while(string.IsNullOrWhiteSpace(ideiglenesAllapot) || Convert.ToByte(ideiglenesAllapot) > 100);
                //autok[i].allapot = Convert.ToByte(ideiglenesAllapot);
                //*****************************************************************

                Console.Clear();
            }

            // minimum kiválasztás
            AutoT min = MinimumKivalasztas(autokT);
            Console.WriteLine("A megadott autók között a legrosszabb: " + min.rendszam);
            Console.ReadKey();
        }

        /*************************************************************/
        // Fájl kezelés beolvasás
        /*************************************************************/

        public struct TanuloAtlag
        {
            public string nev;
            public double atlag;
        }
        static TanuloAtlag[] SzovegesFajlbolStreamReader(string filenev)
        {
            // A probléma az, hogy a StreamReader alapvetően csak azt tudja, hogy a fájl végére értünk-e - azt nem tudja előre, hogy mennyi van még hátra és azt sem tudja, hogy az hány sorban van elrendezve --> a tömb amibe mentenénk a tnaulök adatait viszont fix méretű, így tudni kellene előre, hogy hány tanulóra számítunk. --> Megoldás: kétszer olvassuk be a fájlt --> ez nem tól jó mert a hátértár a leglassabb adatkiszolgáló eszköz.
            StreamReader file = new StreamReader(filenev);
            int sorszam = 0;
            while (!file.EndOfStream) // RndOfStream --> megadja, hogy vége van-e a fájlnak
            {
                file.ReadLine(); // Beolvas a fájlból egy sornyi adatot, de ezzel nem tudunk mit kezdeni, mág nincs hova menteni
                sorszam++;
            }
            file.Close(); // A probléma, hogy tudjuk, hogy hány sor van, de a fájlpointer a fájl végén van addigre, nekünk pedig újra kellene indítanunk az olvasást, tehát lezárjuk a fájlt és ujra megnyitjuk - ekkor a filepointer vissza kerül az elejére
            file = new StreamReader(filenev/*, Encoding.Default*/);           // A .NET alatt futó alap értelmezet kódolást adja mega az Encoding.Default Windows-nál ez UTF-16
            TanuloAtlag[] tanulok = new TanuloAtlag[sorszam / 2];             // Azért kettő mert minden tanulo két sort foglal el
            for (int i = 0; i < tanulok.Length && !file.EndOfStream; i++)    // a biztonnság kedvéért a file végét is ellenőrizük de nem szükséges
            {
                tanulok[i].nev = file.ReadLine();                             // beolvasunk egy sort
                tanulok[i].atlag = Convert.ToDouble(file.ReadLine());         // beolvasunk egy sort és konvertáljuk
            }
            file.Close();
            return tanulok;
        }
        public static TanuloAtlag[] SzovegesFajlbolFile(string filenev)
        {
            // A probléma hogy a File osztály seggírségével egy file-t teljes egészében be tudunk olvasni, viszont így akarva akaratlanul a teljes file be kerül a memóriába, így egy ideig dupla memória területet használ a program, a másik probléma, hogy lehet a file eleve negyobb mint a memória
            string[] teljesFileSoronkent = File.ReadAllLines(filenev/*, Encoding.Default*/);
            TanuloAtlag[] tanulok = new TanuloAtlag[teljesFileSoronkent.Length / 2];
            for (int i = 0, j = 0; i < tanulok.Length; i++, j += 2)
            {
                tanulok[i].nev = teljesFileSoronkent[j];
                tanulok[i].atlag = Convert.ToDouble(teljesFileSoronkent[j + 1]);
            }
            return tanulok;
        }
        public static void SzovegesFajlbolTanulok(string filenev)
        {
            TanuloAtlag[] tanulok = SzovegesFajlbolStreamReader(filenev);     // (@"tanulok.txt")
            for (int i = 0; i < tanulok.Length; i++)
            {
                Console.WriteLine(tanulok[i].nev + "; " + tanulok[i].atlag);
            }
            Console.WriteLine();
            Console.ReadKey();

            TanuloAtlag[] tanulokFile = SzovegesFajlbolFile(filenev);   // (@"tanulok.txt")
            for (int i = 0; i < tanulokFile.Length; i++)
            {
                Console.WriteLine(tanulokFile[i].nev + "; " + tanulokFile[i].atlag);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static double Atlagszamitas(TanuloAtlag[] tomb)
        {
            double eredmeny = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                eredmeny += tomb[i].atlag;
            }
            return eredmeny / tomb.Length;
        }

        public static int MinimumSzamitas(TanuloAtlag[] tomb)
        {
            double min = tomb[0].atlag;
            int index = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i].atlag < min)
                {
                    min = tomb[i].atlag;
                    index = i;
                }
            }
            return index;
        }

        public static int MaximumSzamitas(TanuloAtlag[] tomb)
        {
            double max = tomb[0].atlag;
            int index = 0;
            for (int i = 1; i < tomb.Length; i++)
            {
                if (tomb[i].atlag > max)
                {
                    max = tomb[i].atlag;
                    index = i;
                }
            }
            return index;
        }

        public static void EvVegiJegyek(TanuloAtlag[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                double round = Math.Round(tomb[i].atlag);
                Console.WriteLine("{0} átlaga {1} és év végi jegye {2}", tomb[i].nev, tomb[i].atlag, round);
            }
        }

        public static void TanulokAtlagMaxMin()
        {
            TanuloAtlag[] tanulokFile = SzovegesFajlbolFile("tanulok.txt");
            Console.WriteLine("A tanulók átlaga: {0}", Atlagszamitas(tanulokFile));
            int min = MinimumSzamitas(tanulokFile);
            Console.WriteLine("A legrosszab tanuló: {0}" + " az átlaga {1}", tanulokFile[min].nev, tanulokFile[min].atlag);
            int max = MaximumSzamitas(tanulokFile);
            Console.WriteLine("A legjobb tanuló: {0}" + " az átlaga {1}", tanulokFile[max].nev, tanulokFile[max].atlag);
            EvVegiJegyek(tanulokFile);
        }

        /*************************************************************/
        // Fájl kezelés kiiratás
        /*************************************************************/

        public static void NevekFilebaIratasa()
        {
            StreamWriter file = new StreamWriter(@"nevek.txt", true);  // true esetén az append fog végrehajtódni
            string nev;
            int mentesSzamlalo = 0;
            do
            {
                Console.WriteLine("Adja meg a következő nevet! (kilépés --> exit)");
                nev = Console.ReadLine();
                mentesSzamlalo++;
                if (nev != "exit")
                {
                    file.WriteLine(nev);
                    if (mentesSzamlalo % 5 == 0)  // minden 5. névnél csinálunk egy file-ba kiiratást
                    {
                        file.Flush();
                    }
                }
            } while (nev != "exit");
            file.Close();  // file-t minden esetben le kell zárni
        }
        public static void TanulokFilebaIratasa()
        {
            StreamWriter file = new StreamWriter(@"tanulok.txt");
            string nev, atlag;
            int mentesSzamlalo = 0;
            do
            {
                Console.WriteLine("Adja meg a következő nevet! (kilépés --> exit)");
                nev = Console.ReadLine();
                mentesSzamlalo++;
                if (nev != "exit")
                {
                    Console.WriteLine("Adja meg a tanuló átlagát!");
                    atlag = Console.ReadLine();
                    file.WriteLine(nev);
                    file.WriteLine(atlag);
                    if (mentesSzamlalo % 5 == 0)  // minden 5. névnél csinálunk egy file-ba kiiratást
                    {
                        file.Flush();
                    }
                }
            } while (nev != "exit");
            file.Close();  // file-t minden esetben le kell zárni
        }
        public static void TanulokFilebaIratasaStruct()
        {
            TanuloAtlag tanulok;
            StreamWriter file = new StreamWriter(@"tanulok.txt");
            int mentesSzamlalo = 0;
            do
            {
                Console.WriteLine("Adja meg a következő nevet! (kilépés --> exit)");
                tanulok.nev = Console.ReadLine();
                mentesSzamlalo++;
                if (tanulok.nev != "exit")
                {
                    Console.WriteLine("Adja meg a tanuló átlagát!");
                    tanulok.atlag = Convert.ToDouble(Console.ReadLine());
                    file.WriteLine(tanulok.nev);
                    file.WriteLine(tanulok.atlag);
                    if (mentesSzamlalo % 5 == 0)  // minden 5. névnél csinálunk egy file-ba kiiratást
                    {
                        file.Flush();
                    }
                }
            } while (tanulok.nev != "exit");
            file.Close();  // file-t minden esetben le kell zárni
        }

        /*************************************************************/
        // Ékezetmentesítő
        /*************************************************************/

        static string SzovegEkezet(string eredetiSzoveg)
        {
            eredetiSzoveg = eredetiSzoveg.ToLower().Trim();
            string cserelendo = "öüóőúéáűí ", csere = "ouooueaui_";
            for (int i = 0; i < cserelendo.Length; i++)
            {
                eredetiSzoveg = eredetiSzoveg.Replace(cserelendo[i], csere[i]);
            }
            return eredetiSzoveg;
        }
        public static void SzovegEkezetMentesito()
        {
            Console.WriteLine("Adja meg a szöveget!");
            Console.WriteLine(SzovegEkezet(Console.ReadLine()));
            Console.ReadKey();
        }

        /*************************************************************/
        // Versenyző adatainak rendezése
        /*************************************************************/

        struct Versenyzo
        {
            public string nev, versenyzoAzonosito;
            public int pont;
        }

        //TODO: Menü és kezelése
        static char Menukezeles()
        {
            Console.Clear();
            Console.WriteLine("Valassszon az alabbi opciok kozul:\n\t" +
                "L - a versenyzok listaja pontszam szerint rendezve\n\t" +
                "D - Dobogos versenyzok\n\t" +
                "A - Atlagos ponntszam\n\t" +
                "K - Kilepes");
            return Console.ReadKey(true).KeyChar.ToString().ToLower()[0]; // a karakter kisbetusitese es bekerese, ReadKey(true) akkor nem jeleniti meg a beolvasot karaktert
        }
        //TODO: Rendezés -visszafele rendezes
        static void MaximumKivalasztasosRendezes(Versenyzo[] versenyzok)
        {
            for (int i = 0; i < versenyzok.Length - 1; i++)
            {
                int max = i;
                for (int j = +1; j < versenyzok.Length; j++)
                {
                    if (versenyzok[j].pont > versenyzok[max].pont)
                    {
                        max = j;
                    }
                }
                if (max != i)
                {
                    Versenyzo csere = versenyzok[i];
                    versenyzok[i] = versenyzok[max];
                    versenyzok[max] = csere;
                }
            }
        }
        //TODO: Bekérés

        static Versenyzo VersenyzoBekerese()
        {
            Versenyzo bekert;
            Console.WriteLine("Adja meg a versenyzo nevet!");
            bool voltMarBekeres = false;
            do
            {
                if (voltMarBekeres)
                {
                    Hibakiiras("A versenyzo neve nem lehet ures!");
                }
                bekert.nev = Console.ReadLine();
                voltMarBekeres = true;
            } while (string.IsNullOrWhiteSpace(bekert.nev));

            voltMarBekeres = false;
            Console.WriteLine("Adja meg a versenyzo azonositojat!");
            do
            {
                if (voltMarBekeres)
                {
                    Hibakiiras("A versenyzo azonositoja nem lehet ures!");
                }
                bekert.versenyzoAzonosito = Console.ReadLine();
                voltMarBekeres = true;
            } while (string.IsNullOrWhiteSpace(bekert.versenyzoAzonosito));

            Console.WriteLine("Adja meg a versenyzo pontjat!");
            voltMarBekeres = false;
            do
            {
                if (voltMarBekeres)
                {
                    Hibakiiras("A versenyzo pontja minimum nulla kell legyen!");
                }
                bekert.pont = Convert.ToInt32(Console.ReadLine());
                voltMarBekeres = true;
            } while (bekert.pont < 0);
            Console.Clear();
            return bekert;
        }

        //TODO: Hiba kiiratása
        static void Hibakiiras(string szoveg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(szoveg);
            Console.ResetColor();
        }
        //TODO: Átlagszáítás

        static double AtlagPontszam(Versenyzo[] versenyzok)
        {
            double atlag = 0;
            for (int i = 0; i < versenyzok.Length; i++)
            {
                atlag += versenyzok[i].pont;
            }
            return atlag /= versenyzok.Length;
        }

        //TODO: tomb kiirato megoldasaa

        static void TombKiiratas(Versenyzo[] versenyzok, int dobogosSzam) // ha 0 akkor mindet listazza ha nem akkor annyit amennyi meg van adva
        {
            int zaroIndex = versenyzok.Length - 1;
            if (dobogosSzam > 0 && dobogosSzam < zaroIndex)
            {
                zaroIndex = dobogosSzam;
            }
            for (int i = 0; i <= zaroIndex; i++)
            {
                Console.WriteLine(versenyzok[i].nev + " - " + versenyzok[i].pont + " - " + versenyzok[i].versenyzoAzonosito);
            }
        }

        public static void VersenyzokRendezes()
        {
            Console.WriteLine("Adja meg, hogy hany versenyzo lesz!");
            Versenyzo[] jatekosok = new Versenyzo[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < jatekosok.Length; i++)
            {
                jatekosok[i] = VersenyzoBekerese();
            }
            MaximumKivalasztasosRendezes(jatekosok);
            char menuOpcio;
            do
            {
                menuOpcio = Menukezeles();
                switch (menuOpcio)
                {
                    case 'l':
                        TombKiiratas(jatekosok, 0);
                        break;
                    case 'd':
                        TombKiiratas(jatekosok, 2); // 0 index-tol a 2 a harmadik
                        break;
                    case 'a':
                        Console.WriteLine("A megadott versenyzok atlagos pontszama: " + AtlagPontszam(jatekosok));
                        break;
                    case 'k':
                        // kilepes
                        break;
                    default:
                        Hibakiiras("A keresett funkcio nem letzik!");
                        break;
                }
                if (menuOpcio != 'k')
                {
                    Console.WriteLine("A folytatashoz nyomjon egy gombot!");
                    Console.ReadKey();
                }
            } while (menuOpcio != 'k');
        }

        /*************************************************************/
        // CSV Beléptetés
        /*************************************************************/

        public static string SHA256(string szoveg)
        {
            //// Szöveget át kell konvertálni bájtra
            //byte[] szovegBajtban = Encoding.UTF8.GetBytes(szoveg);
            //// Implementáljuk a titkosítót
            //SHA256CryptoServiceProvider titkosito = new SHA256CryptoServiceProvider();
            //// titkosítás...
            //byte[] titkosSzovegBajtban = titkosito.ComputeHash(szovegBajtban);
            //// Hexa konvertálás kell
            //string titkosSzoveg = BitConverter.ToString(titkosSzovegBajtban).ToLower().Replace("-", "");
            //return titkosSzoveg;

            return BitConverter.ToString(new SHA256CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(szoveg))).ToLower().Replace("-", "");
        }

        //TODO: Jelszó bekérése

        static string JelszoBekeres()
        {
            Console.ForegroundColor = Console.BackgroundColor;
            string jelszó = SHA256(Console.ReadLine());
            Console.ResetColor();
            return jelszó;
        }

        static string JelszoBekeresBitonságosabb()
        {
            string jelszo = "";
            char jelenlegi;
            do
            {
                jelenlegi = Console.ReadKey(true).KeyChar;
                if (jelenlegi == 8 && jelszo.Length > 0)  //ASCII(8) = Backspace
                {
                    jelszo = jelszo.Remove(jelszo.Length - 1);
                    // Ha van kiiratás
                    //Console.Write("\b");
                    Console.CursorLeft--; //megadja hogy balra hányadik karakternél áll a kurzor
                    Console.Write(" "); // Kiirunk egy szóközt (annak a helyére amin eddig áltunk)
                    Console.CursorLeft--; // Újfent visszalépünk egyet, így egyel kevesebb karakterből áll a jelszó vizuálisan
                }
                else if (jelenlegi >= 32) // a space vagy annál nagyobb helyen lévő karakter - a space alatt vezérlő karakterek vannak
                {
                    jelszo += jelenlegi;
                    // ha vna kiiratás
                    Console.Write("*");
                }
            } while (jelenlegi != 13);
            Console.WriteLine();
            return SHA256(jelszo);
        }

        static string JelszoBekeresLinux()
        {
            string jelszo = "";
            char jelenlegi;
            do
            {
                jelenlegi = Console.ReadKey(true).KeyChar;
                if (jelenlegi == 8 && jelszo.Length > 0)
                {
                    jelszo = jelszo.Remove(jelszo.Length - 1);
                }
                else if (jelenlegi >= 32)
                {
                    jelszo += jelenlegi;
                    Console.Write("*");
                }
            } while (jelenlegi != 13);
            Console.WriteLine();
            return SHA256(jelszo);
        }

        //TODO: CS-ben keresés

        static bool CSVKereses(string felhasznalonev, string titkosJelszó)
        {
            StreamReader reader = new StreamReader(@"login.csv");
            bool belepve = false;
            while (!reader.EndOfStream)
            {
                string[] csvDaraboltSor = reader.ReadLine().Split(';');
                if (csvDaraboltSor[0] == felhasznalonev && csvDaraboltSor[1] == titkosJelszó)
                {
                    belepve = true;
                }
            }
            reader.Close();
            return belepve;
        }

        public static void CSVBeleptetes()
        {
            Console.WriteLine("Adja meg a felhasznalónevét");
            string fnev = Console.ReadLine();
            Console.WriteLine("Adja meg a jelszavát!");
            //string titkosJelszó = JelszoBekeres();
            //string titkosJelszó = JelszoBekeresBitonságosabb();
            string titkosJelszó = JelszoBekeresLinux();
            if (CSVKereses(fnev, titkosJelszó))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sikeres belépés!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás felhasználónév / jelszó!");
            }
            Console.ReadKey();
        }

        /*************************************************************/
        // Tanulo átlag CSV-vel fájlba iratássa
        /*************************************************************/

        struct TanuloCSV
        {
            public string nev;
            public double atlag;

            public string CSVFormatum()
            {
                return $"{nev};{atlag}";
                //return atlag + "";  // az atlag át konvertálódik szöveggé és így kerül vissza adásra
            }
        }

        public static void TanuloAtlagCSV()
        {
            TanuloCSV jelenlegi;
            StreamWriter writer = new StreamWriter(@"tanulo.csv", false, Encoding.Default); // false mert felül íras és Encoding.Default hogy az operációs rendszer karakter kódolására állítsa be
            //StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\tanulokcsv"); // a desktopra etszi ki a fájlt
            do
            {
                Console.WriteLine("Adja meg a következő tanuló nevét!");
                jelenlegi.nev = Console.ReadLine();
                if (jelenlegi.nev.ToLower().Trim() != "exit")
                {
                    Console.WriteLine("Adja meg a tanuló ({0}) átlagát", jelenlegi.nev);
                    jelenlegi.atlag = Convert.ToDouble(Console.ReadLine());
                    writer.WriteLine(jelenlegi.CSVFormatum());
                }
            } while (jelenlegi.nev.ToLower().Trim() != "exit");
            writer.Close();
        }

        /*************************************************************/
        // Fájl kezelő program
        /*************************************************************/



        static string KerdesValasz(string kerdes, string[] valaszok)
        {
            Console.WriteLine(kerdes);
            string valasz;
            bool voltMarBekeres = false;
            do
            {
                if (voltMarBekeres)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A válasz nem elfogadható");
                    Console.ReadLine();
                }
                valasz = Console.ReadLine();
                voltMarBekeres = true;
            } while (!valaszok.Contains(valasz));  // A Contais megadja, hogy az adott tömbben van-e olyan elem - eldöntés tétel
            return valasz;
        }

        // TODO: Fájl másoló

        static void FajlMasolo()
        {
            Console.WriteLine("Adja meg, hogy melyik fájlt másoljuk!");
            string forras = Console.ReadLine();
            if (File.Exists(forras))
            {
                Console.WriteLine("Adja meg, hogy hova másoljuk a forrást!");
                string celfajl = Console.ReadLine();
                if (File.Exists(celfajl))
                {
                    string valasz = KerdesValasz("A cél fájl már létezik. Felülírjuk?", new string[] { "i", "n" });
                    if (valasz == "n")
                    {
                        return;
                    }
                }
                File.Copy(forras, celfajl, true);
                Console.WriteLine("A másolás sikeres!");
            }
            else
            {
                Console.WriteLine("A forrás nem létezik");
            }
        }

        // TODO: Fájl felovasó

        static void FajlFelolvaso()
        {
            Console.WriteLine("Adja meg, hogy melyik fájlt olvassuk be!");
            string forras = Console.ReadLine();
            if (File.Exists(forras))
            {
                StreamReader reader = new StreamReader(forras);
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
                reader.Close();
                Console.WriteLine("----EOF---");
            }
            else
            {
                Console.WriteLine("A megadott fájl nem található!");
            }
        }

        // TODO: Fálba író;
        static void FajlbaIro()
        {
            Console.WriteLine("Adja meg, hogy  mi legyen a fájl tartalma!");
            string tartalom = Console.ReadLine();
            Console.WriteLine("Adja meg a mentés helyét!");
            string celfajl = Console.ReadLine();
            string opcio = "o";
            if (File.Exists(celfajl))
            {
                opcio = KerdesValasz("A megadott célfájl létezik, felülírjuk (o), folytassuk (a), vagy szakítsuk meg a műveletet (c)? [o/a/c]", new string[] { "o", "a", "c"});
                if (opcio == "c")
                {
                    return;
                }
            }
            StreamWriter writer = new StreamWriter(celfajl, opcio == "a");
            writer.WriteLine(tartalom);
            writer.Close();
        }

        // TODO: Menu

        static string MenuKiiras()
        {
            Console.Clear();
            return KerdesValasz("Válaszon az alábbi opciók közül:\nC - Fájl másolása\nO - Fájl megnyitása\nS - Fájl létrehozása / metése\nE - Kilépés", new string[] { "c", "o", "s", "e" });
        }

        public static void FajlKezelo()
        {
            string opcio;
            do
            {
                opcio = MenuKiiras();
                switch (opcio)
                {
                    case "c":
                        FajlMasolo();
                        break;
                    case "o":
                        FajlFelolvaso();
                        break;
                    case "s":
                        FajlbaIro();
                        break;
                }
                if (opcio != "e")
                {
                    Console.WriteLine("A folytatáshoz nyomjon egy gombot!");
                    Console.ReadKey();
                }

            } while (opcio != "e");
        }


        /*************************************************************/
        // Egyszerü szövegszerkesztő program
        /*************************************************************/


        //static string KerdesValasz(string kerdes, string[] valaszok)
        //{
        //    Console.WriteLine(kerdes);
        //    string valasz;
        //    bool voltMarBekeres = false;
        //    do
        //    {
        //        if (voltMarBekeres)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("A válasz nem elfogadható");
        //            Console.ResetColor();
        //        }
        //        valasz = Console.ReadLine();
        //        voltMarBekeres = true;
        //    } while (!valaszok.Contains(valasz));
        //    return valasz;
        //}

        static void Kiiratas(string celFajl, string szovegSor, bool opcio)
        {
            StreamWriter writer = new StreamWriter(celFajl, opcio);
            do
            {
                szovegSor = Console.ReadLine();
                if (szovegSor != "vege")
                {
                    writer.WriteLine(szovegSor);
                }
            } while (szovegSor != "vege");
            writer.Close();
        }

        static void Beolvasas(string celFajl)
        {
            StreamReader reader = new StreamReader(celFajl);
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
            reader.Close();
        }

        public static void EgyszeruSzovegSzerkeszto()
        {
            string ujra = "";
            Console.WriteLine("Egyszeru szoveg szerkeszto program\n");
            do
            {
                Console.Clear();
                string szovegSor = "", opcio = "o";
                Console.WriteLine("Adja meg szoveg nevet");
                string celFajl = Console.ReadLine();
                if (File.Exists(celFajl))
                {
                    opcio = KerdesValasz("A megadott célfájl létezik, felülírjuk (o), folytassuk (a), vagy szakítsuk meg a műveletet (c)? [o/a/c]", new string[] { "o", "a", "c" });
                    if (opcio == "c")
                    {
                        continue;
                    }
                }
                if (opcio == "a")
                {
                    Console.WriteLine("Kerem folytassa a szoveget ha vegzet az utolso sorba irja be, hogy \"vege\"!");
                    Beolvasas(celFajl);
                    Kiiratas(celFajl, szovegSor, true);
                }
                else if (opcio == "o")
                {
                    Console.WriteLine("Ija be a szoveget ha vegzet az utolso sorba irja be, hogy \"vege\"!");
                    Kiiratas(celFajl, szovegSor, false);
                }
                ujra = KerdesValasz("Szeretne masik fajlt szerkeszteni? (i/n)", new string[] { "i", "n" });
            } while (ujra == "i");
        }


        /*************************************************************/
        // Idő és dátum kezelése
        /*************************************************************/

        public static void DateAndTime()
        {
            Console.Clear();
            DateTime datum1 = new DateTime(2021, 4, 27);
            //DateTime datum2 = new DateTime(2021, 4, 27, 40, 30);
            DateTime[] datumok = new DateTime[10];
            datumok[0] = DateTime.MinValue;
            datumok[1] = DateTime.Now;
            datumok[2] = DateTime.UtcNow;
            datumok[3] = DateTime.Today;
            datumok[4] = Convert.ToDateTime("2021.04.27");
            datumok[5] = DateTime.Parse("2021.04.27");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(datumok[i]);
            }
            Console.Write("\n" + datum1 + " " + datum1.DayOfWeek + " " + datum1.DayOfYear + "\n");
            Console.WriteLine(datum1.Year);
            Console.WriteLine(datum1.AddHours(2.5));
            datum1 = datum1.AddHours(-3);
            Console.WriteLine(datum1);
            Console.WriteLine(DateTime.Parse("2021.04.27") < DateTime.Now);
            TimeSpan karácsonyig = DateTime.Parse("2021.12.25") - DateTime.Now;
            Console.WriteLine("Karácsonyig {0} idő van még hátra!", karácsonyig);
            Console.WriteLine(datum1.ToShortDateString());
            Console.WriteLine(datum1.ToLongDateString());
        }

        /*************************************************************/
        // Save CSV file from user input with time and date
        /*************************************************************/


        struct NevCSV
        {
            public string nev;
            public string születésiDatum;
            public string szuletesiHely;
        }

        static void NevekCSV(NevCSV[] tomb)
        {
            StreamWriter writer = new StreamWriter(@"nevek.csv", false, Encoding.Default);
            writer.WriteLine("Vezetéknév;Keresztnév;Születési év;hónap;nap;Születési hely");
            for (int i = 0; i < tomb.Length; i++)
            {
                string szoveg = tomb[i].nev, sor = "";
                string[] splitSzoveg = szoveg.Split(' ');
                for (int j = 0; j < splitSzoveg.Length; j++)
                {
                    sor += $"{splitSzoveg[j]};";
                }
                DateTime szovegDateTime = Convert.ToDateTime(tomb[i].születésiDatum);
                sor += $"{szovegDateTime.ToString("yyyy")};";
                sor += $"{szovegDateTime.ToString("MMMM")};";
                sor += $"{szovegDateTime.ToString("dd")};";
                sor += tomb[i].szuletesiHely;
                writer.WriteLine(sor);
            }
            writer.Close();
        }

        public static void SaveNevekCSV()
        {
            Console.WriteLine("Adja meg hány nevet szeretne rözíteni!");
            int dararbSzam = Convert.ToInt32(Console.ReadLine());
            NevCSV[] Nevek = new NevCSV[dararbSzam];
            for (int i = 0; i < Nevek.Length; i++)
            {
                Console.WriteLine("Adja meg a teljes nevet!");
                Nevek[i].nev = Console.ReadLine();
                Console.WriteLine("Adja meg a születési dátumot! (YYYY-MM-DD)");
                Nevek[i].születésiDatum = Console.ReadLine();
                Console.WriteLine("Adja meg a születési Helyet!");
                Nevek[i].szuletesiHely = Console.ReadLine();
                Console.Clear();
            }

            NevekCSV(Nevek);
            Console.ReadKey();
        }


    }
}
