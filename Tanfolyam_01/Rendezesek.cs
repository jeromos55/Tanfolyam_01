using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam_01
{
    class Rendezesek
    {       
        public static void Maximum(int[] tomb)                                         // Maximum rendezes
        {
            /*************************************************************/
            // Rendezes maximum kivalasztassal
            /*************************************************************/

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Rendezes maximum kivalasztassal");
            Console.ResetColor();

            //Kiíratás rendezés előtt

            Console.Write("  Rendezes elott: \n    ");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + "    ");
            }
            Console.WriteLine();

            for (int i = tomb.Length - 1; i > 0; i--)
            {
                int max = i;
                for (int j = 0; j <= i; j++)
                {
                    if (tomb[j] > tomb[max])
                    {
                        max = j;
                    }
                }
                int swap = tomb[i];
                tomb[i] = tomb[max];
                tomb[max] = swap;
            }

            //Kiíratás rendezés utan    

            Console.Write("  Rendezes utan: \n    ");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + "    ");
            }
            Console.WriteLine();
        }
        public static void Buborek(int[] tomb)                                         // Buborek rendezes
        {
            /*************************************************************/
            // Buborék rendezés
            /*************************************************************/

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Buborek rendezes");
            Console.ResetColor();

            //int[] tomb = new int[] { 5, 4, 9, 3, 7 };
            int n = tomb.Length;

            //Kiíratás rendezés előtt

            Console.Write("  Rendezes elott: \n    ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}    ", tomb[i]);
            }
            Console.WriteLine();

            //Rendezes

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        int tmp = tomb[j + 1];
                        tomb[j + 1] = tomb[j];
                        tomb[j] = tmp;
                    }
                }
            }

            //Kiíratás rendezés után

            Console.Write("  Rendezes utan: \n    ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}    ", tomb[i]);
            }
            Console.WriteLine();
        }
        public static void Cseres(int[] tomb)                                          // Cseres rendezes
        {
            /*************************************************************/
            // Cseres rendezes
            /*************************************************************/

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cseres rendezes");
            Console.ResetColor();

            //int[] tomb = { 22, 5, 4, 33, 9, 3, 7, 15, 20 };
            int n = tomb.Length;

            //Kiíratás rendezés előtt

            Console.Write("  Rendezes elott: \n    ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}    ", tomb[i]);
            }
            Console.WriteLine();

            //Cserés rendezés

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                        int swap = tomb[j];
                        tomb[j] = tomb[i];
                        tomb[i] = swap;
                    }
                }
            }

            //Kiíratás rendezés után

            Console.Write("  Rendezes utan: \n    ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}    ", tomb[i]);
            }
            Console.WriteLine();
        }    
        public static void Beszurasos(int[] tomb)                                      // Beszurasos rendezes
        {
            /*************************************************************/
            // Beszurasos rendezes
            /*************************************************************/

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Beszurasos rendezes rendezes");
            Console.ResetColor();

            //Rendezes elott

            Console.Write("  Rendezes elott: \n    ");
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + "    ");
            }
            Console.WriteLine();

            for (int i = 1; i < tomb.Length; i++)
            {
                int kulcs = tomb[i];
                int j = i - 1;
                while (j >= 0 && tomb[j] > kulcs)
                {
                    tomb[j + 1] = tomb[j];
                    j = j - 1;
                }
                tomb[j + 1] = kulcs;

            }

            //Rendzes utan

            Console.Write("  Rendezes utan: \n    ");
            for (int i = 0; i < tomb.Length; i++)
                Console.Write(tomb[i] + "    ");
            Console.WriteLine();
        }
        public static void GyorsRekurziv_main(int[] tomb)                              // Gyors rekurziv fugveny
        {
            /*************************************************************/
            // Gyors rendezés rekurzív megoldással 
            /*************************************************************/

            int n = tomb.Length;

            for (int i = 0; i < n; i++)
                Console.Write(tomb[i] + " ");
            Console.WriteLine();

            GyorsRekurziv(tomb, 0, 6);

            for (int i = 0; i < n; i++)
                Console.Write(tomb[i] + " ");
            Console.WriteLine();
        }
        public static void GyorsRekurziv(int[] tomb, int also, int felso)              // Gyors rekurziv metodus
        {
            /*************************************************************/
            // Gyors rendezés rekurzív megoldással 
            /*************************************************************/

            int i = also, j = felso;
            int kozep = tomb[(felso + also) / 2];
            while (also <= felso)
            {
                while (also < j && tomb[also] < kozep)
                    also++;
                while (felso > i && tomb[felso] > kozep)
                    felso--;
                if (also <= felso)
                {
                    int tmp = tomb[also];
                    tomb[also] = tomb[felso];
                    tomb[felso] = tmp;
                    ++also;
                    --felso;
                }
            }
            if (also < j) GyorsRekurziv(tomb, also, j);
            if (i < felso) GyorsRekurziv(tomb, i, felso);

        }  //TODO -- komentezni, kiiratas
        public static void Shell_rendzes(int[] t, int[] h)                             // Shell rendezes
        {
            int n = t.Length;

            //Kiíratás rendezés előtt
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", t[i]);
            Console.WriteLine();

            //Shell rendezés
            for (int k = 0; k < h.Length; k++)
            {
                int lepes = h[k];
                for (int j = lepes; j < n; j++)
                {
                    int i = j - lepes;
                    int x = t[j];
                    while (i >= 0 && t[i] > x)
                    {
                        t[i + lepes] = t[i];
                        i = i - lepes;
                    }
                    t[i + lepes] = x;
                }
            }

            //Kiíratás rendezés után
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", t[i]);
            Console.WriteLine();
        }   //TODO -- komentezni, kiiratas
        public static void CseresrendezesList(List<string> downlistbox)                // Cseres rendezés listákkal
        {
            foreach (string d in downlistbox)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine();

            List<string> idlist = new List<string>();

            foreach (string s in downlistbox)
                idlist.Add(s);

            int n = idlist.Count;

            //Cserés rendezés
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    if (Convert.ToInt32(idlist[i].Split('.')[0]) > Convert.ToInt32(idlist[j].Split('.')[0]))
                    {
                        string swap = idlist[j];
                        idlist[j] = idlist[i];
                        idlist[i] = swap;
                    }
                }
            downlistbox.Clear();

            downlistbox.AddRange(idlist.ToArray());

            foreach (string d in downlistbox)
            {
                Console.WriteLine(d);
            }
        }     
    }
}
