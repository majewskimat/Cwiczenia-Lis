using System;

namespace Cwiczenia_2_Lis
{
    class Program
    {
        static void Main(string[] args)
        {
            // CW 11.3

            // int i = 100, j = 100;
            /*
            for (; i > 1; i--)
            {

                if (i % 3 > 0)
                {
                    if (i % 4 > 0) { Console.WriteLine("{0}", i); }
                } 
                continue;
            }
            */
            /*
            while (j > 1)
            {
                j--;
                if ((j % 3 > 0) == true) 
                {
                    if (j % 4 > 0) { Console.WriteLine(j); }
                }  
            }
            */

            // CW 11.5
            /*
            
            for (int i = -100; i<=100; i++)
            {

                if (i % 4 == 0)
                {
                    if (i % 8 > 0)
                    {
                        if (i % 10 > 0)
                        {
                            Console.WriteLine("{0}",i);
                        }
                        continue;
                    }
                }

            }
            */
            /*
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                { 
                    Console.WriteLine(i); 
                }


                //CW 10.6
            }
            */
            /*
            int i = 0, k = 0; //przykład a
            for (; i <= 20; i++)
            {
                Console.WriteLine();
                k++;
                for (int j = 20; j >= k; j--)
                
                {
                    Console.Write("{0}  ", j);

                }
            }
            */

            //TABLICE CW 12.1
            /*
            int[] tablica = new int[110];
            for (int i = 101; i < tablica.Length; i++)
            {
                tablica[i] = i;
            }
            for( int i = 101; i < tablica.Length; i++)
            {
                Console.WriteLine("tablica[{0}] = {1}", i, tablica[i]);
            }
            */

            // CW 12.2
            /*
            int[] tablica = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("tab[{0}] = {1}", i, tablica[i]);
            }
            */


            /*
            int[] tablica = new int[110];
            for (int i = 10; i < tablica.Length; i += 10)
            {
                tablica[i] = i;
            }
            for (int i = 10; i < tablica.Length; i += 10)
            {
                Console.WriteLine("tab[{0}] = {1}", i / 10, tablica[i]);
            }
            */

            //CW 12.3
            /*
            bool[] tab = new bool[20];

            for (int i = 0; i < tab.Length; i++)
            {
                if (i % 2 != 0)
                {
                    tab[i] = false;
                    Console.WriteLine("False");
                }
                else
                {
                    tab[i] = true;
                    Console.WriteLine("True");
                }
            }
            */

            //CW 12.4

            /*
            int[] tablica = new int[100]; 
            for (int i = 0; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 0 "); }
            Console.WriteLine();
            for (int i = 1; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 1 "); }
            Console.WriteLine();
            for (int i = 2; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 2 "); }
            Console.WriteLine();
            for (int i = 3; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 3 "); }
            Console.WriteLine();
            for (int i = 4; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 4 "); }
            Console.WriteLine();
            for (int i = 5; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 5 "); }
            Console.WriteLine();
            for (int i = 6; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 6 "); }
            Console.WriteLine();
            for (int i = 7; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 7 "); }
            Console.WriteLine();
            for (int i = 8; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 8 "); }
            Console.WriteLine();
            for (int i = 9; i < tablica.Length; i += 10)
            { tablica[i] = i; Console.Write(" {0}", tablica[i] + " = 9 "); }
            */


            //CW 12.5

            /*
            char[] tablica = new char[123];
            for (char a = 'a'; a < tablica.Length ; a++)
            {
                tablica[a] = a; Console.WriteLine(a);
            }
            */

            // /\ Dziwne \/ Logiczne

            /*
            char[] tablica = new char[26];

            char k = 'a';

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = k++;
                Console.WriteLine("Tablica[" + i + "] = " + tablica[i]);
            }
            */

            //CW 12.6

            /*
            int[] tablica = new int[10];

            int i = -1;
            while (i < tablica.Length)
            {
                if (i == tablica.Length - 1)
                {
                    break;
                }
                else
                {
                    i++;
                    tablica[i] = i;
                    Console.WriteLine("Tablica [{0}] = {1}", i, tablica[i]);
                }
            }
            */

            // CW 13.1
            /*
            int[][] tab = new int[4][];
            tab[0] = new int[4];
            tab[1] = new int[2];
            tab[2] = new int[1];
            tab[3] = new int[3];

            int licznik = 10;

            for (int i = 0; i < tab.Length; i++)
            {
                for(int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = licznik--;
                }
            }

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("tab[{0}] = ", i);
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write("{0} ", tab[i][j]);

                }
                Console.WriteLine("");
              */

            //CW 13.2
            /*
            int[][] tab = new int[4][];
            tab[0] = new int[4];
            tab[1] = new int[3];
            tab[2] = new int[2];
            tab[3] = new int[1];

            int licznik = 1;
            int ai = 0;
            int bj;

            while (ai < tab.Length)
                
            {
                bj = 0;
                while (bj < tab[ai].Length)
                {

                    
                    tab[ai][bj] = licznik++;

                    bj++;
                }

                ai++;
            }
            


            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("tab[{0}] = ",i);

                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write("{0} ", tab[i][j]);
                }
                Console.WriteLine("");
            }
            */

            //CW 13.3
            /*
            int[][] tab = new int[4][]; // tworzę tablicę typu int z 4 wierszami

            tab[0] = new int[1]; // do każdego wiersza tworzę kolejno ilości komórek
            tab[1] = new int[2];
            tab[2] = new int[3];
            tab[3] = new int[4];

            int licznik = 10;  // tworzę wejściową wartość tablicy

            for (int i = 0; i < tab.Length; i++) // tworzę pętle for, która nadaje wartości tabeli (jeszcze nie widoczne)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = licznik--;
                }
            }
            
            for (int i = 0; i < tab.Length; i++) // za pomocą drugiej pętli for wyświetlam wartości które zostały nadane w pierwszej pętli
            {
                Console.Write("tab[{0}] = ", i);

                for (int j = 0;j < tab[i].Length; j++)
                {
                    Console.Write("{0} ", tab[i][j]);
                }
                Console.WriteLine("");
            }
            */

            //CW 13.4
            /*
            bool[][] tab = new bool[5][];

            for (int i = 0; i < 5; i++)
            {
                tab[i] = new bool[8];
            }

            bool p = true;
            bool f = false;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {

                    if (i % 2 != 0)
                    {
                        if (j % 2 != 0) { tab[i][j] = f; }

                        else { tab[i][j] = p; }

                    }

                    else if (j % 2 != 0) { tab[i][j] = f; }

                    else { tab[i][j] = p; }
                }
            }

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("tab[{0}] ",i);

                for (int j = 0; j < tab[i].Length; j++)
                {
                    if (tab[i][j] == true) { Console.Write("1 "); }
                    else { Console.Write("0 "); }
                }
                Console.WriteLine();
            }
            */






            Console.ReadLine();
        }
    }
}
