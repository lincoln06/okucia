using System;

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
            Console.WriteLine("Minimalne wymiary to: 550x550 mm");
            int szer = 300;
            int wys = 300;
            while(szer<550 || wys<550)
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
            float pop2 = 0;
            float pop3 = 0;
            float pop4 = 0;
            float pop5 = 0;
            string klasa = "";
            switch(k)
            {
                case 1:
                    klasa = "Standard";
                    pop1 = y / 2 - 195;
                    pop3 = x - 506;
                    Console.WriteLine("Potrzebne elementy:\n");
                    Console.WriteLine("MMBS0220-52501\t\tZestaw zawiasów");
                    Console.WriteLine("MMGI0090-10001\t\tRyglowanie centralne");
                    Console.WriteLine("MSKK0300-00001\t\tRozwórka");
                    Console.WriteLine("MMMV0040-10001\t\tZestaw narożnika");
                    Console.WriteLine($"VL59\t\t\tPopychacz\tZamek dół\t{pop1}mm");
                    Console.WriteLine($"VL59\t\t\tPopychacz\tZamek góra\t{pop1}mm");
                    Console.WriteLine($"VL59\t\t\tPopychacz\tskrzydło góra\t{pop3}mm");

                    if (x>1250)
                    {
                        pop5 = x / 2;
                        Console.WriteLine($"VL59\t\t\tPopychacz\tskrzydło dół\t{pop5} mm");
                        Console.WriteLine("MMMV0040-10001\t\tNarożnik z przeniesieniem napędu");
                    }
                    if(y>1250)
                    {
                        pop4 = y / 2;
                        Console.WriteLine($"VL59\t\t\tPopychacz\tStrona zawiasu\t{pop4} mm");
                        Console.WriteLine("MMMV0040-10001\t\tNarożnik z przeniesieniem napędu");
                    }

                    break;
                case 2:
                    pop1 = y / 2 - 229;
                    pop2 = y / 2 - 195;
                    pop3 = x - 506;
                    int vr = 0;
                    int cn = 0;
                   
                    Console.WriteLine("Potrzebne elementy:\n");
                    Console.WriteLine("MMBS0220-52501\t\tZestaw zawiasów");
                    Console.WriteLine("MMGI0060-10001\t\tRyglowanie centralne");
                    Console.WriteLine("MSKK0300-00001\t\tRozwórka");
                    Console.WriteLine("MMVS0450-10001\t\tZestaw narożnika");
                    Console.WriteLine($"VL59\t\t\tPopychacz\tZamek dół\t{pop1}mm");
                    Console.WriteLine($"VL59\t\t\tPopychacz\tZamek góra\t{pop2}mm");
                    Console.WriteLine($"VL59\t\t\tPopychacz\tSkrzydło góra\t{pop3}mm");
                    if (y <= 1400) vr = 4;
                    if (y > 1400 && y <= 2000) { vr = 6;cn = 1; }
                    if (y > 2000) { vr = 6; cn = 3; }
                   
                    
                    if (x > 900)
                    {
                        vr = vr + 2;
                        pop5 = x / 2-114;
                        Console.WriteLine($"VL59\t\t\tPopychacz\tskrzydło dół\t{pop5} mm");
                        Console.WriteLine("MMMV0040-10001\t\tNarożnik z przeniesieniem napędu");
                    }
                        pop4 = y -302;
                        Console.WriteLine($"VL59\t\t\tPopychacz\tstrona zawiasu\t{pop4} mm");
                        Console.WriteLine("MMMV0040-10001\t\tNarożnik z przeniesieniem napędu");
                        Console.WriteLine($"MMVR0050-10001\t\tElement zamykający\t\t{vr} szt.");
                        Console.WriteLine($"857076\t\t\tZaczep regulowany\t\t{cn} szt.");
                    break;
            }
            Console.WriteLine($"\nWybrałeś okno rozwierno - uchylne o klasie odporności {klasa} i wymiarach {x}x{y}mm.");
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