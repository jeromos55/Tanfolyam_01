using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Elso_project_Hello_word();  //Hello word

            //Masodik_project_Elso_prg();  
            //Masodik_project_Masodik_prg();

            //Harmadik_project_Elso_prg();
            //Harmadik_project_Masodik_prg();
            //Harmadik_project_Harmadik_prg();

            //Negyedik_project_Elso_prg();
            //Negyedik_project_Masodik_prg();

            //Otodik_project_Elso_prg();

            //Hatodik_project_Elso_prg();   

            //Hetedik_project_Elso_prg();
            //Hetedik_project_Masodik_prg();
            //Hetedik_project_Harmadik_prg();
            //Hetedik_project_Negyedik_prg();
            //Hetedik_project_Otodik_prg();
            Hetedik_project_Hatodik_prg();

            //Nyolcadik_project_Elso_prg();
            //Nyolcadik_project_masodik_prg();
        }

        static void Elso_project_Hello_word()
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
        static void Masodik_project_Elso_prg()
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
        static void Masodik_project_Masodik_prg()
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
        static void Harmadik_project_Elso_prg()
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
        static void Harmadik_project_Masodik_prg()
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
        static void Harmadik_project_Harmadik_prg()
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
        static void Negyedik_project_Elso_prg()
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
        static void Negyedik_project_Masodik_prg()
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
        static void Otodik_project_Elso_prg()
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
        static void Hatodik_project_Elso_prg()
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
        static void Hetedik_project_Elso_prg()
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
        static void Hetedik_project_Masodik_prg()
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
        static void Hetedik_project_Harmadik_prg()
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
        static void Hetedik_project_Negyedik_prg()
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
        static void Hetedik_project_Otodik_prg() // Maximum kereses hiba kereses gyakorlása
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
        static void Hetedik_project_Hatodik_prg() // Tanulok jegye es neve alapján az átlag, legrosszab, legjobb jegyek kiiratasa, bekert adatok védelme
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
                } while ( bekert < '1' || bekert > '5'); // ugyanaz jelenti mint fent csak a nyelvre bizzuk a kiertekelest 

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
                
            }
            Console.WriteLine("\nA Legjobb tanulo: {0} jegye: {1}", nevek[max_index], max);
            Console.WriteLine("\nA Legjobb tanulo: {0} jegye: {1}", nevek[min_index], min);
            Console.ReadKey();

        }
        static void Nyolcadik_project_Elso_prg() // Butor cikkszamok és árak ellenörzése saját megoldás indexek különtárolásával
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
            int[ , ] indexek = new int[3, arak.Length];  //  ketdimenzios tomb olcso 1, kozoeoes 2, draga 0, oszlopopkkal

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
            while ( (j < darabszam) && !( (arak[j] > 10000) && (arak[j] < 15000) ))
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
            for (int  i = 0;  i < darabszam;  i++)
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
        static void Nyolcadik_project_masodik_prg() // Butor cikkszamok és árak ellenörzése, bevitel javitva es index tábla nélkül tanárral megoldva
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
                else if (/*arak[i] >= 30000 &&*/ arak[i] <= 50000)  // nem érdekes mert már a 30000 egyzser le volt kérdezve
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
    }
}