using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiekty_Cwiczenia
{
    /*
    class LiczbaCalkowita
    {
        int x;

        int PobierzLiczbe()
        {
            return x;
        }
        void WyswietlLiczbe()
        {
            Console.WriteLine("Współrzędna x = " + x);
        }
        static void Main(string[] args)
        {

            LiczbaCalkowita liczba = new LiczbaCalkowita();

            liczba.x = 100;
            int wspX = liczba.PobierzLiczbe();
            liczba.WyswietlLiczbe();

            Console.ReadKey();

        }
        */

    /*
class Prostokat
{
    int aX = 3, aY = 3;
    int bX, bY;
    int cX, cY;
    int dX = 12, dY = 8;
    int wspAX, wspAY;
    int wspBX, wspBY;
    int wspCX, wspCY;
    int wspDX, wspDY;

    int PobierzAX()
    {
        return aX;  
    }
    int PobierzAY()
    {
        return aY;
    }
    int PobierzBX()
    {
        return bX;
    }
    int PobierzBY()
    {
        return bY;
    }
    int PobierzCX()
    {
        return cX;
    }
    int PobierzCY()
    {
        return cY;
    }
    int PobierzDX()
    {
        return dX;
    }
    int PobierzDY()
    {
        return dY;
    }
    void Wspolrzedne()
    {
        Prostokat róg = new Prostokat();
        róg.aX = aX; róg.aY = aY;
        róg.dX = dX; róg.dY = dY;
        róg.bX = róg.dX; róg.bY = róg.aY;
        róg.cX = róg.aX; róg.cY = róg.dY;

        róg.wspAX = róg.PobierzAX();
        róg.wspBX = róg.PobierzBX();
        róg.wspCX = róg.PobierzCX();
        róg.wspDX = róg.PobierzDX();
        róg.wspAY = róg.PobierzAY();
        róg.wspBY = róg.PobierzBY();
        róg.wspCY = róg.PobierzCY();
        róg.wspDY = róg.PobierzDY();


        róg.WyswietlWspolrzedne();

    }
    void WyswietlWspolrzedne()
    {
        Console.WriteLine("Punkt A : x = {0} , y = {1}", wspAX,wspAY);
        Console.WriteLine("Punkt B : x = {0} , y = {1}", wspBX, wspBY);
        Console.WriteLine("Punkt C : x = {0} , y = {1}", wspCX, wspCY);
        Console.WriteLine("Punkt D : x = {0} , y = {1}", wspDX, wspDY);
    }

    static void Main(string[] args)
    {
        Prostokat róg = new Prostokat();

        róg.Wspolrzedne();


        Console.ReadKey();
    }

*/

    class Punkt
    {
        int x = 0;
        int y;

        int PobierzX()
        {
            return x;
        }

        int PobierzY()
        {
            return y;
        }
        void UstawX(int wspX)
        {
            x = wspX;
            PobierzX();
            
        }

        void UstawY(int wspY)
        {
            y = wspY;
            PobierzY();
            
        }
        void UstawX(Punkt punkt1)
        {
            x = punkt1.x;
        }

        void UstawY(Punkt punkt2)
        {
            y = punkt2.y;
        }


        void WyswietlWspolrzedneX()
        {
            Console.WriteLine("Wspolrzedna x = " + x);
            
        }
        void WyswietlWspolrzedneY()
        {
            
            Console.WriteLine("Wspolrzedna y = " + y);
        }

        public static void Main()
        {
            Punkt punktX = new Punkt();
            Punkt punktY = new Punkt();


            punktX.UstawX(100);
            punktY.UstawY(100);

            Console.WriteLine("Pierwszy punkt:");
            punktX.WyswietlWspolrzedneX();
            punktY.WyswietlWspolrzedneY();

            

            

            Console.ReadKey();
        }

    }
}
    
