using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_01
{
    class Tetelek
    {         
        public static void Maximum(int[] tomb)                                 // Maximum kivalsztas
            {
                /*************************************************************/
                // Maximum kiválasztás tétele
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Maximum kivalasztas tetel");
                Console.ResetColor();

                //int[] tomb = { 4, 3, 9, 7, 2, 5 };
                int n = tomb.Length;  //Az n a tömb mérete
                int max;

                max = tomb[0];
                for (int i = 0; i < n; i++)
                {
                    if (tomb[i] > max)
                    {
                        max = tomb[i];
                    }
                }

                Console.WriteLine("  A legnagyobb elem: {0}", max);
            }
        public static void Minimum(int[] tomb)                                 // Minimum kivalsztas
            {
                /*************************************************************/
                // Minimum kiválasztás tétele
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Minimum kivalasztas tetel");
                Console.ResetColor();

                //int[] tomb = { 4, 3, 9, 7, 2, 5 };
                int n = tomb.Length;  //Az n a tömb mérete
                int min;

                min = tomb[0];
                for (int i = 1; i < n; i++)
                {
                    if (tomb[i] < min)
                    {
                        min = tomb[i];
                    }
                }

                Console.WriteLine("  A legkisebb elem: {0}", min);
            }
        public static void BinarisKereses(int[] tomb, int ker)                 // Binaris kereses
            {

                /*************************************************************/
                // Binaris keresés
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Binaris kereses {0}", ker);
                Console.ResetColor();

                int e, u, k; // e - első elem, u - utolsó elem, k - középső elem
                e = 0; // első elem előre állítása
                u = tomb.Length - 1;  // utolsó elem hátulra állítása

                do
                {
                    k = Math.Abs((e + u) / 2); // középső elelm beállítása
                    if (tomb[k] < ker)  // kereset szám nagyobb mint a középső
                    {
                        e = k + 1;  // első elem középre állítása
                    }
                    else if (tomb[k] > ker)  // kereset szám kisebb mint a középső
                    {
                        u = k - 1;  // utolsó elem középre állítása
                    }
                } while ((e <= u) && (ker != tomb[k]));  // ha első elem kisebb egyenlő mint az utolsó és a kereset elem nem egyenlő a középsővel ujra kezdjük

                if (e <= u) // ha az első elelm kisebb egyenlő az utolsóval eredmény kiiratás
                {
                    Console.WriteLine("  Van talalat: " + "index: " + k + " value: " + tomb[k]);
                }
                else
                {
                    Console.WriteLine("  Nincs talalat.");
                }
            }
        public static void Osszegzes(int[] tomb)                               // Osszegzes 
            {
                /*************************************************************/
                // Összegzés
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Összegzés tetel");
                Console.ResetColor();

                //int[] tomb = { 8, 9, 5, 4, 1 };
                int osszeg = 0;  // az osszeg alapértéke
                for (int i = 0; i < tomb.Length; i++)  // számláló ciklus a tomb végéig
                {
                    osszeg = osszeg + tomb[i];  // számonkénti összeadás
                }
                Console.WriteLine("  Összeg: " + osszeg);
            }
        public static void Megszemlalas(int[] tomb, int ker)                   // Megszamlalas
            {
                /*************************************************************/
                // Megszamolas
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Megszamolas tetel");
                Console.ResetColor();

                int n = tomb.Length;  // a tömb hossza
                int c = 0;  // a számláló alaphelyzetbe állítása

                for (int i = 0; i < n; i++)  // szamlaló ciklus a tömb végéig
                {
                    if (tomb[i] < ker)  // ha a ker-nél kisebb a számláló növelése
                    {
                        c++;
                    }
                }

                Console.WriteLine("  5-nél kisebb számok darabszáma: {0}", c);
            }
        public static void Eldontes(int[] tomb, int ker)                       // Eldontes --- For
            {
                /*************************************************************/
                // Eldontes
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eldontes tetel");
                Console.ResetColor();

                int n = tomb.Length;  // a tömb hossza

                bool van = false;  // alapból hamis
                for (int i = 0; i < n; i++)  // számláló ciklus a tömb végéig
                {
                    if (tomb[i] == ker)  // ha benne van igaz
                    {
                        van = true;
                    }
                }

                Console.WriteLine("  Igaz-e, hogy van {0}-ös a tömbben?: {1}", ker, van);
            }
        public static void Eldontes2(int[] tomb, int ker)                      // Eldontes --- While
            {
                /*************************************************************/
                // Eldontes 2
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eldontes tetel 2");
                Console.ResetColor();

                int n = tomb.Length;
                int i = 0;

                while (i < n && tomb[i] != ker)  // elöltesztelő ciklus ha a ker egyenlő a számmal akkor kilép egyébként növeli a számlálót
                {
                    i++;
                }

                if (i < n)  // ha a számláló kisebb mint a tömb hossza benne van
                {
                    Console.WriteLine("  Igaz-e, hogy {0} benne van?: True ", ker);
                }
                else
                {
                    Console.WriteLine("  Igaz-e, hogy {0} benne van?: False ", ker);
                }
            }
        public static void Kivalsztas(int[] tomb, int ker)                     // Kivlasztas
            {
                /*************************************************************/
                // Kiválasztás tétel
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kivalasztas tetel");
                Console.ResetColor();

                int n = tomb.Length; // tömb hossza
                int i = 0;  // előltesztelős ciklus index alaphelyzetbe

                while (i < n && tomb[i] != ker)  // ha index kisebb mint a tömb hossza és a tömb elem nem egyenlő a keresett számmal
                {
                    i++; // ha nincs meg index növelése egyel
                }

                if (i < n)  // ha index kisebb mint a tömbhossza meg van ha nem nincs
                {
                    Console.WriteLine("  A kereset szám {0} indexe: {1}", ker, i);
                }
                else
                {
                    Console.WriteLine("  A kereset szám {0} nincs benne", ker);
                }
            }
        public static void LinearisKereses(int[] tomb, int ker)                // Liearis kereses
            {
                /*************************************************************/
                // Keresés
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kereses");
                Console.ResetColor();

                int n = tomb.Length;  // tömb hossza
                int i = 0;  // előltesztelős ciklus index alaphelyzetbe

                while (i < n && tomb[i] != ker)  // ha index kisebb mint a tömb hossza és a tömb elem nem egyenlő a keresett számmal
                {
                    i++; // ha nincs meg index növelése egyel
                }

                if (i < n)  // ha index kisebb mint a tömbhossza meg van ha nem nincs
                {
                    Console.WriteLine("  A kereset szám {0} indexe: {1}", ker, i);
                }
                else
                {
                    Console.WriteLine("  A kereset szám {0} nincs benne", ker);
                }
            }
        public static void Kivalogatas(int[] tomb, int ker)                    // Kivalogatas
            {
                /*************************************************************/
                // Kiválogatás tétel
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kivalogatas tetel");
                Console.ResetColor();

                int n = tomb.Length;  // a tömb hossza
                int[] b = new int[n];  // másik tömb létrehozása az előző tömb hosszával
                int j = 0;  // a b tömb indexének alapbeállítása

                for (int i = 0; i < n; i++)  // számláló ciklus a tömbök hosszával
                {
                    if (tomb[i] < ker)  // A keresetnél kisebb számok
                    {
                        b[j] = tomb[i];  // átírás a másik tömbbe
                        j++;  // számláló növelése
                    }
                }

                Console.WriteLine("  Eredeti:");
                for (int i = 0; i < n; i++)  // számláló ciklus a kiiratáshoz
                {
                    Console.Write("    {0} ", tomb[i]);
                }

                Console.WriteLine();
                Console.WriteLine("  Az kisebb mint {0} számok kiválogatva:", ker);

                for (int i = 0; i < j; i++)  // számláló ciklus a kiiratáshoz
                {
                    Console.Write("    {0} ", b[i]);
                }

                Console.WriteLine();
            }
        public static void Szetvalogatas(int[] tomb, int ker)                  // Szetvalogatas
            {
                /*************************************************************/
                // Szétválasztás
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Szetvalogatas tetel");
                Console.ResetColor();

                int n = tomb.Length;
                int[] b = new int[n];
                int[] c = new int[n];
                int j = 0;
                int k = 0;

                for (int i = 0; i < n; i++)
                {
                    if (tomb[i] < ker)  //A keresettnél kisebb számok
                    {
                        b[j] = tomb[i];
                        j++;
                    }
                    else
                    {
                        c[k] = tomb[i];
                        k++;
                    }
                }

                Console.WriteLine("  Eredeti:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("    {0} ", tomb[i]);
                }

                Console.WriteLine();
                Console.WriteLine("  Szetvalogatott {0} kisebb:", ker);

                for (int i = 0; i < j; i++)
                {
                    Console.Write("    {0} ", b[i]);
                }

                Console.WriteLine();
                Console.WriteLine("  Szetvalogatott {0} nagyobb:", ker);

                for (int i = 0; i < k; i++)
                {
                    Console.Write("    {0} ", c[i]);
                }

                Console.WriteLine();
            }
        public static void Metszet(int[] tomb, int[] tomb2)                    // Metszet
            {
                /*************************************************************/
                // Metszet
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Metszet tetel");
                Console.ResetColor();

                int n = tomb.Length, m = tomb2.Length, o;  //Tömbök és a metszet mérete
                int[] c = new int[n + m];  // metszet tömb létrehozása
                int i, j, k; //Ciklusváltozók, illetve tömbindexek

                k = 0;  // első tömb index alaphelyzetbe állítása
                for (i = 0; i < n; i++)  // számláló ciklus az első tömb hosszáig i index
                {
                    j = 0;  // második tömb index alaphelyzetbe állítása
                    while (j < m && tomb2[j] != tomb[i])  // elől tesztelő ciklus a második tömb méretéig j index és ha nem egyenlőek a számok léptetés
                    {
                        j++;  // következö szám indexe
                    }

                    if (j < m)  // ha nem értük el az második tömb végét 
                    {
                        c[k] = tomb[i];  // metszetbe másolás
                        k++; // metzset tömb mértének növelése eggyel
                    }
                }

                o = k; // Metszet tömb mérete

                //  Tömbök kiíratása
                Console.WriteLine("  Elso tomb:");

                for (i = 0; i < n; i++) // n első tömb mérete
                {
                    Console.Write("    " + tomb[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine("  Masodik tomb:");

                for (j = 0; j < m; j++) // m második tömb mérete
                {
                    Console.Write("    " + tomb2[j] + " ");
                }

                Console.WriteLine();
                Console.WriteLine("  Tombok metszete:");

                for (k = 0; k < o; k++)  // o a metszet mérete
                {
                    Console.Write("    " + c[k] + " ");
                }

                Console.WriteLine();
            }
        public static void Unio(int[] a, int[] b)                              // Unio
            {
                /*************************************************************/
                // Únió
                /*************************************************************/

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unio tetel");
                Console.ResetColor();

                int n = a.Length, m = b.Length;  // tömbök méretei
                int[] c = new int[n + m];  // unió tömb létrehozása a két tömb méretének összegével
                int i, j, k;  //Ciklusváltozók, indexek

                for (i = 0; i < n; i++)  // számláló ciklus az első tömb méretével
                {
                    c[i] = a[i];  // első tömb másolása az unió tömbbe
                }

                k = n;
                for (j = 0; j < m; j++)  // számláló ciklus az második tömb méretével
                {
                    i = 0;  // while ciklus index
                    while (i < n && b[j] != a[i])  // ha az első és második tömb eleme nem egyezik és az index nem nagyobb mint az első tömb mérete léptejük az indexet
                    {
                        i++;
                    }

                    if (i >= n)  // ha nem értük el az elsö tömb végét
                    {
                        c[k] = b[j]; // másolás az úniós tömbbe
                        k++;
                    }
                }


                // Az a tömb kiíratása
                Console.Write("  Az első tömb: \n    ");

                for (i = 0; i < n; i++)
                {
                    Console.Write(a[i] + "    ");
                }

                Console.Write("\n  A második tömb: \n    ");

                // A b tömb kiíratása
                for (i = 0; i < m; i++)
                {
                    Console.Write(b[i] + "    ");
                }

                Console.Write("\n  Az únió tömb: \n    ");

                // Az únió eredménytömb kiíratása

                for (i = 0; i < k; i++)
                {
                    Console.Write(c[i] + "    ");
                }

                Console.WriteLine();
            }                 
    }
}
