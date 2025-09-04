using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Szamologep;

internal class Program
{   
   

    //static void Settings()
    //{
    //    Console.Clear();
    //    Thread.Sleep(100);
    //    Console.WriteLine("---------------Beállítások---------------");
    //    Console.WriteLine("------------Készítette: Haltiru------------");
    //    Console.WriteLine("---------A kilépéshez nyomj: 'k'-t---------");
    //    Console.WriteLine("----A visszalépéshez nyomj 'backspace'-t----");
    
    //}
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        while (true)
        {
            Thread.Sleep(100);
            Console.WriteLine($"|-------------| Számológép! |-------------|");
            Console.WriteLine($"|---------| Készítette: Haltiru |---------|");
            Console.WriteLine($"|----| A kilépéshez írj: 'kilépés'-t |----|");
            //Console.WriteLine("----A beállításokhoz nyomdd meg: 'b'----");
            Console.WriteLine();
            Console.Write("Add meg az első számot: ");
            string input = "0";
            string muvelet = "";
            string input2 = "0";
            List<string> kilepes = ["kilépés", "kilepes", "exit", "ex"];

            input = Console.ReadLine();
            //ConsoleKeyInfo keyInfo = Console.ReadKey(true); // true = nem írja ki a karaktert

            //if (keyInfo.Key == ConsoleKey.B) // ha a user 'b'-t nyom
            //{
            //    Settings();
            //}
            if (kilepes.Contains(input.ToLower()))
            {
            break;
            }
            if (!double.TryParse(input, out double szam1))
            {
                Console.WriteLine("Hibás adat, számot kell megadni!");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            Console.Write("Add meg a műveletet (+, -, *, /): ");
            muvelet = Console.ReadLine();
            if (kilepes.Contains(muvelet.ToLower()))
            {
                break;
            }

            if (muvelet != "+" && muvelet != "-" && muvelet != "*" && muvelet != "/")
            {
                Console.WriteLine("Hibás művelet, csak +, -, * vagy / lehet!");
                Console.ReadKey();
                Console.Clear();
                continue; // vissza a ciklus elejére
            }
            Console.Write("Add meg a második számot: ");

            input2 = Console.ReadLine();

            if (kilepes.Contains(input2.ToLower()))
            {
                break;
            }
            if (!double.TryParse(input2, out double szam2))
            {
                Console.WriteLine("Hibás adat, számot kell megadni!");
                Console.ReadKey();
                Console.Clear();
                continue; // vissza a ciklus elejére
            }
            double eredmeny = 0;
            switch (muvelet)
            {
                case "+": eredmeny = szam1 + szam2; break;
                case "-": eredmeny = szam1 - szam2; break;
                case "*": eredmeny = szam1 * szam2; break;
                case "/": eredmeny = szam1 / szam2;
                    if (szam2 == 0)
                    {
                        Console.WriteLine("Nullával nem lehet osztani!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    eredmeny = szam1 / szam2;
                    break;
            }
            Console.WriteLine($"A művelet eredménye: {szam1} {muvelet} {szam2} = {eredmeny}");
            Console.ReadKey();
            Console.Clear();
        }
        
    }
}
