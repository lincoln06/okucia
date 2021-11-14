﻿using System;

namespace okucia
{
    class Program
    {
        static void Main(string[] args)
        {
            int rodzaj = 0;
            int klasa = 0;
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
            Console.WriteLine("Minimalne wymiary to: 350x450 mm");
            int szer = 300;
            int wys = 300;
            while(szer<350 || wys<450)
            {
                Console.Clear();
                Console.WriteLine("Podaj szerokość skrzydła w mm");
                szer = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokość skrzydła w mm");
                wys = int.Parse(Console.ReadLine());
            }
            while(klasa<1 || klasa>2)
            {
                Console.Clear();
                Console.WriteLine("Podaj klasę okuć");
                Console.WriteLine("1 - Standard");
                Console.WriteLine("2 - RC2");
                klasa = int.Parse(Console.ReadLine());
            }
            oblicz(rodzaj, szer, wys, klasa);
            
            Console.ReadKey();

        }
        static void oblicz(int r,int x, int y, int k)
        {
            switch(r)
            {
                case 1:
                    Uchyl(k, x, y);
                    break;
                case 2:
                    roz(k, x, y);
                    break;
                case 3:
                    ru(k, x, y);
                    break;
                case 4:
                    ruch(k, x, y);
                    break;
            }
           
        }
        static void Uchyl(int k,int x,int y)
        {
            Console.WriteLine($"Wybrałeś okno uchylne o klasie odporności {k} i wymiarach {x}x{y}mm.");
        }
        static void ru(int k,int x, int y)
        {
            float pop1 = 0;
            float pop3 = 0;
            string klasa = "";
            switch(k)
            {
                case 1:
                    klasa = "Standard";
                    pop1 = y / 2 - 195;
                    pop3 = x / 2 - 133;
                    Console.WriteLine("Potrzebne elementy:");
                    Console.WriteLine("Ryglowanie centralne\nNarożnik RU\nRozwórka");
                    Console.WriteLine($"Popychacz - Zamek dół {pop1} mm");
                    Console.WriteLine($"Popychacz - Zamek góra {pop1} mm");
                    Console.WriteLine($"Popychacz - skrzydło góra {pop3} mm");

                    if (x>1250)
                    {
                        int pop5 = x / 2;
                        Console.WriteLine($"Popychacz - skrzydło dół {pop5} mm");
                        Console.WriteLine("Narożnik MMMV0040-10001_701");
                    }
                    if(y>1250)
                    {
                        int pop4 = y / 2;
                        Console.WriteLine($"Popychacz - strona zawiasowa {pop4} mm");
                        Console.WriteLine("Narożnik MMMV0040-10001_701");
                    }

                    break;
                case 2:
                    klasa = "RC2";
                    break;
            }
            Console.WriteLine($"Wybrałeś okno rozwierno - uchylne o klasie odporności {klasa} i wymiarach {x}x{y}mm.");
        }
        static void roz(int k,int x, int y)
        {
            Console.WriteLine($"Wybrałeś okno rozwierne o klasie odporności {k} i wymiarach {x}x{y}mm.");
        }
        static void ruch(int k,int x, int y)
        {
            Console.WriteLine($"Wybrałeś okno rozwierno - uchylne + rozwierne na słupku ruchomym o klasie odporności {k} i wymiarach {x}x{y}mm.");
        }
    }
}
