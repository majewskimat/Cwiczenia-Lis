using System;


namespace Cwiczenia_Lis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(" /---\\  |----\\  /----\\\n|     | |    |  |\n|     | |    /  |\n|-----| |----   |" +
                "\n|     | |    \\  |\n|     | |    |  |\n|     | |----/  \\----/");
            */
            //Console.WriteLine("111\t+\t222\t=\t333\n +\t\t +\t\t +\n333\t+\t444\t=\t777\n =\t\t =\t\t =\n444\t+\t666\t=\t1110");
            /*int a = 15, b = 4, c = 2, wynik;
            wynik = (a % b) % c;
            Console.WriteLine(wynik);*/
            /*int wartosc = 256;
            Console.WriteLine(wartosc<<2);
            Console.WriteLine(wartosc>>2);
            */
            /*int wartosc1=100, wartosc2=200;
            Console.WriteLine(wartosc1&wartosc2);
            Console.WriteLine(wartosc1|wartosc2);
            */
            /* int wartosc1 = 100, wartosc2 = 200, wartosc3, wartosc4;
            wartosc3 = (wartosc1 ^ wartosc2);
            wartosc3 = (wartosc1 ^ wartosc2);
            Console.WriteLine(wartosc3);
            */
            /*int jeden = 1, dwa = 1, cztery;
            int trzy = 1;
            Console.WriteLine(jeden++);
            jeden++; jeden++;
            Console.WriteLine(jeden++);
            jeden++; jeden++;
            Console.WriteLine(jeden++);
            jeden++; jeden++;
            Console.WriteLine(jeden++);
            jeden++; jeden++;
            Console.WriteLine(jeden++);
            Console.WriteLine(dwa);
            ++dwa; ++dwa; ++dwa;
            Console.WriteLine(dwa);
            ++dwa; ++dwa; ++dwa;
            Console.WriteLine(dwa);
            ++dwa; ++dwa; ++dwa;
            Console.WriteLine(dwa);
            ++dwa; ++dwa; ++dwa;
            Console.WriteLine(dwa);
            Console.WriteLine(trzy); //mozna zrobic inaczej/lepiej wrocic do tego
            Console.WriteLine(trzy<<2);
            trzy = trzy << 3;
            Console.WriteLine(--trzy);
            trzy++; trzy++; trzy++;
            Console.WriteLine(trzy);
            
            trzy++;trzy++;trzy++;
            Console.WriteLine(trzy);
            */

            /*int liczba1 =150, liczba2= 100; // ćw 7,6 do poprawy nie um
            liczba1 = liczba2;
            Console.WriteLine(liczba1);
            liczba2 = liczba2 ^ liczba1;
            Console.WriteLine(liczba2);
            */
            //ćwiczenie 8.1 
            /*int a = 5, b= 3;
            if (a % b!=0)
            {
                Console.WriteLine("Reszta z dzielenia nie wynosi 0");
            }
            else
            {
                Console.WriteLine("Reszta z dzielenia wynosi 0");
            }
            */
            //ćwiczenie 8.2 mozna zmodyfikowac aby uztykownik sam wybieral z menu jakie dane posiada i na bazie tego wyliczac rozwiazanie
            /*float x, a=2, b=3, c=4, wynik;
            wynik  = a + b + c;
            x = wynik;
            if (x>=0)
            {
                Console.WriteLine("Rozwiązanie równiania znajduje sie w zbiorze liczb rzeczywistych");
            }
            else
            {
                Console.WriteLine("Rozwiązanie równiania nie znajduję sie w zbiorze liczb rzeczywistych");
            }
            */
            //ćw 8.3, po przerobieniu
            /*
            double zmienna = 10;
            Console.WriteLine("Podaj wartość zmiennej aby użyc na niej wartości bezwzględnej");
            string zmienna_ = Console.ReadLine();
            double.TryParse(zmienna_, out zmienna);
            if  (zmienna<0)
            {
                zmienna = zmienna * -1;
                Console.WriteLine("Wartość zmiennej po przekształceniu wynosi {0}", zmienna);
            }
            else
            {
                Console.WriteLine("Wartosc zmiennej jest dodatnia i wynosi {0}", zmienna);
            }
            */
            //ćwiczenie 8.4
            /*
            int a1 = 2, a2 = 2, b1 = 3, b2 = 3;
            */

            /* int liczba = 10; /cw9.1
            switch (liczba)
            {
               case 0:
                   if (liczba != 0)
                   {
                       goto case 1;
                   }
                   else
                   {
                       Console.WriteLine("liczba jest równa 0");
                   }
                   break;
               case 1:
                   if (liczba != 1)
                   {
                       goto case 2;
                   }
                   else
                   {
                       Console.WriteLine("Liczba jest równa 1");
                   }
                   break;
               case 2:
                   if (liczba != 2)
                   {
                       goto case 3;
                   }
                   else
                   {
                       Console.WriteLine("Liczba jest równa 2");
                   }
                   break;
               case 3:
                   if (liczba != 3)
                   {
                       goto case 4;
                   }
                   else
                   {
                       Console.WriteLine("liczba jest równa 3");
                   }
                   break;
               case 4:
                   if (liczba != 4)
                   {
                       goto case 5;
                   }
                   else
                   {
                       Console.WriteLine("liczba jest równa 4");
                   }
                   break;
               case 5:
                   if (liczba != 5)
                   {
                       goto case 6;
                   }
                   else
                   {
                       Console.WriteLine("liczba jest równa 5");
                   }
                   break;
               case 6:
                   if (liczba != 6)
                   {
                       goto case 7;
                   }
                   else
                   {
                       Console.WriteLine("liczba jest równa 6");
                   }
                   break;
               case 7:
                   if (liczba != 7)
                   {
                       goto case 8;
                   }
                   else
                   {
                       Console.WriteLine("liczba jest równa 7");
                   }
                   break;
               case 8:
                   if (liczba != 8)
                   {
                       goto case 9;
                   }
                   else
                   {
                       Console.WriteLine("liczba jest równa 8");
                   }
                   break;
               case 9:
                   if (liczba != 9)
                   {
                       goto default;
                   }
                   else
                   {
                       Console.WriteLine("liczba jest równa 9");
                   }
                   break;
               default:
                   Console.WriteLine("jeb sie");
                   break;
                  */

            /*//cw 9.2
            bool zmienna =true&false;
            double liczba = 10, liczba1 = 10, liczba3 = liczba%liczba1;
            switch (zmienna)
            {
                case false:
                    if (liczba3 != 0)
                        Console.WriteLine("zjebałeś");
                    else goto case true;
                    break;

                case true:
                        Console.WriteLine("nie zjebałeś");
                    break;
            }
            */
            ///cw 9.3
            /*bool zmienna = false;
            double liczba = 10, liczba1 = 10, liczba3 = liczba % liczba1;
            zmienna = liczba3 != 0 ? false : true;
            switch (zmienna)
            {
                case true:
                    Console.WriteLine("Jest dobrze");
                    break;
                case false:
                    Console.WriteLine("Jest zle");
                    break;
            }
            */ //cw 9.4
               /*
               int liczba = -10;
               int liczba2;
               //liczba2 = liczba < 0 ? -1 : 1;
               if (liczba<0)
               {
                   liczba2 = -1;
                   Console.WriteLine(liczba2);
               }
               else
               {
                   liczba2 = 1;
                   Console.WriteLine(liczba2);
               }
               //cwiczenie 9.5
               */
               /*
               int z;
               string zmienna;
               Console.WriteLine("Podaj zmienna: ");
               zmienna = Console.ReadLine();
               int.TryParse(zmienna, out z);
               switch (z)
               { 
                   case 1:
                   case 4:
                   case 8:
                       Console.WriteLine("zmienna ma wartość 1,4,8");
                       break;
                   case 2:
                   case 3:
                   case 7:
                       Console.WriteLine("zmienna ma wartość 2,3,7");
                       break;
                   default:
                       Console.WriteLine("zmienna znajduje sie w pozostalych przypadkach");
                       break;

               }
               */
               //ćw 10.1 liczby od 1 do 10 podzielne przez 2
               /*
               int i;
               for (i=2 ; i <= 10; i =i + 2)
               {
                   Console.WriteLine("Liczba podzielnie przez 2 od 1 do 10 to :{0}", i);
               }
               */
               /*
               //Ćwiczenie 10.2
               int i = 1; //druga z możliwości to zamienic z 0 na 1
               while (i++ < 10) //jedna z mozliwosc to zapisac (i++<9)
               {
                   Console.WriteLine("[numer: {0}]Pętle w C#",i);
               }
               */
               /*
               //ćwiczenie 10.3
               double liczba=1;
               while (liczba<20)
               {
                   if (liczba % 3 != 0)
                   {
                       liczba++;
                   }
                   else
                   {
                       Console.WriteLine("liczba od 1 do 20 podzielna przez 3 to:{0}", liczba);
                       liczba++;
                   }
               }
               */
               //ćwiczenie 10.4
               /*
               int i = 0; //druga zmienia tresc ale wyglada i=1
               do
               {
                   Console.WriteLine("[i = {0}] Pętle w C#", i);
               }
               while (i++ <= 8); //pierwsza opcja i++<=8
               */
               //ćwiczenie 10.5
               /*
               int i=1, j = 1, k=1;
               for (; i<=20;i++) //a
               {
                   if (i%2!=0)
                   {
                       Console.WriteLine("Liczba {0} jest liczbą nieparzystą", i);
                   }
                   else
                   {
                       Console.WriteLine("Liczba {0} jest liczbą parzystą", i);
                   }
               }
               Console.WriteLine("\n\n");
               while (j<=20) //b
               {
                   if(j%2!=0)
                   {
                       Console.WriteLine("Liczba {0} jest liczbą nieparzystą", j);
                       j++;
                   }
                   else
                   {
                       Console.WriteLine("Liczba {0} jest liczą parzystą", j);
                       j++;
                   }
               }
               do //c
               {
                   if (k % 2 != 0)
                   {
                       Console.WriteLine("Liczba {0} jest liczbą nieparzystą", k);
                       k++;
                   }
                   else
                   {
                       Console.WriteLine("Liczba {0} jest liczbą parzystą", k);
                       k++;
                   }
               } while (k <= 20);
               */
               //ćwiczenie 10.6
               /*
            int i = 100, j = 100, k = 100; //a
            /*for (;i>1;i--)
            {
                if (i % 3 != 0) { }
                else if (i % 2 != 0)
                {
                    Console.WriteLine("liczby te to {0}", i);
                }
            }
            */
               /*while (j>1) //b
               {
                   --j;
                   if (j % 3 != 0) { }
                   else if (j % 2 != 0)
                   {
                       Console.WriteLine("Liczby te to {0}", j);
                   }
               }   
               */
               /*
               do //c
               {
                   k--;
                   if (k % 3 != 0) { }
                   else if (k % 2 != 0)
                   {
                       Console.WriteLine("Liczby te są następujące {0}", k);
                   }
               } while (k > 1);
               */
               //problem znajduje sie w 177-187
               //ćwiczenie 11.1
               /*
               for (int i = 1; i <= 20; i++)
               {
                   if (i % 2 != 0) { }
                  else continue;
                   Console.WriteLine(i);

               }
               */
               
               int i = 0; //ćwiczenie 11.2
               while(i<20)
               {
                   ++i;
                   if (i % 2 != 0) { }
                   else continue;
                   Console.WriteLine(i);
               }
               
               //ćwiczenie 11.3
   
 /*
           int i = 100, j = 100;
            for (; i > 1; i--)
            {

                if (i % 3 != 0) continue;
                else if (i % 4 != 0) { Console.WriteLine(i); }
            }

           while (j>1)
           {
               j--;
               if ((j % 3 != 0) == true) { }
               else if (j % 4 != 0) { Console.WriteLine(j); }
           }
           */


            Console.ReadKey();
}
}
}
