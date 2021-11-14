using System;

namespace okucia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program obliczy okucia potrzebne do wykonania pojedyczego skrzydła okiennego o właściwościach zadanych przez użytkownika");
            Console.ReadKey();
            Console.WriteLine("Podaj typ skrzydła");
            Console.WriteLine("1 - Uchylne\n2 - Rozwierne\n3 - Rozwierno - uchylne\n4 - Rozwierno - uchylne + rozwierne ze słupkiem ruchomym");
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
