using System;

namespace okucia
{
    class Program
    {
        static void Main(string[] args)
        {
            int rodzaj = 0;
            Console.Clear();
            Console.WriteLine("Program obliczy okucia potrzebne do wykonania pojedyczego skrzydła okiennego o właściwościach zadanych przez użytkownika");
            Console.ReadKey();
            while (rodzaj < 1 || rodzaj > 4)
            {
                Console.Clear();
                Console.WriteLine("Podaj typ skrzydła");
                Console.WriteLine("1 - Uchylne\n2 - Rozwierne\n3 - Rozwierno - uchylne\n4 - Rozwierno - uchylne + rozwierne ze słupkiem ruchomym");
                rodzaj = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Minimalne wymiary to: 350x350 mm");
            int szer = 300;
            int wys = 300;
            while(szer<350 && wys<350)
            {
                Console.Clear();
                Console.WriteLine("Podaj szerokość skrzydła w mm");
                szer = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokość skrzydła w mm");
                wys = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();

        }
        static void Uchyl(int x,int y)
        {
            //Funkcja dla okna U
        }
        static void ru(int x, int y)
        {
            //funkcja dla okna RU
        }
        static void roz(int x, int y)
        {
            //funkcja dla okna r
        }
        static void ruch(int x, int y)
        {
            //funkcja dla ru+r na ruchomym
        }
    }
}
