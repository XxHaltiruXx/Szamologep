using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

internal class Program

{
    static int Alltipp = 0;
    static string beallitasokFile = "beallitasok.json";
    static string ver = "0.1.0";
    class Beallitasok
    {
        public string Szin { get; set; } = "White";
        public string Tipps { get; set; } = "0";
    }


    static void SaveSettings()
    {
        var beallitasok = new Beallitasok { Szin = szin.ToString() };
        string json = JsonConvert.SerializeObject(beallitasok);
        File.WriteAllText(beallitasokFile, json);
    }

    static void LoadSettings()
    {
        if (File.Exists(beallitasokFile))
        {
            string json = File.ReadAllText(beallitasokFile);
            var betoltott = JsonConvert.DeserializeObject<Beallitasok>(json);
            if (betoltott != null)
            {
                szin = Enum.Parse<ConsoleColor>(betoltott.Szin);
                Console.ForegroundColor = szin;
                Alltipp = Convert.ToInt32(betoltott.Tipps);
            }
        }
    }



    static ConsoleColor szin = ConsoleColor.White;
    static ConsoleColor Color()
    {

        while (true)
        {
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("|-------------| Beállítások |-------------|");
            Console.WriteLine("|---------| Készítette: Haltiru |---------|");
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Írd be: ");
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}]   - a 'v' betűt, hogy visszalépj!");
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Milyen színűre akarod a szöveget színezni?");
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Választható színek:");
            Console.WriteLine("fekete \nsötétkék \nsötétzöld \nsötétcián \nsötétvörös \nsötétlila \nsötétsárga \nszürke \nsötétszürke \nkék \nzöld \ncián \nvörös \nlila \nsárga \nfehér");
            Console.Write("> ");
            string color = Console.ReadLine();

            switch (color.ToLower())
            {
                case "fekete": szin = ConsoleColor.Black; SaveSettings(); return ConsoleColor.Black;
                case "sötétkék": szin = ConsoleColor.DarkBlue; SaveSettings(); return ConsoleColor.DarkBlue;
                case "sötétzöld": szin = ConsoleColor.DarkGreen; SaveSettings(); return ConsoleColor.DarkGreen;
                case "sötétcián": szin = ConsoleColor.DarkCyan; SaveSettings(); return ConsoleColor.DarkCyan;
                case "sötétvörös": szin = ConsoleColor.DarkRed; SaveSettings(); return ConsoleColor.DarkRed;
                case "sötétlila": szin = ConsoleColor.DarkMagenta; SaveSettings(); return ConsoleColor.DarkMagenta;
                case "sötétsárga": szin = ConsoleColor.DarkYellow; SaveSettings(); return ConsoleColor.DarkYellow;
                case "szürke": szin = ConsoleColor.Gray; SaveSettings(); return ConsoleColor.Gray;
                case "sötétszürke": szin = ConsoleColor.DarkGray; SaveSettings(); return ConsoleColor.DarkGray;
                case "kék": szin = ConsoleColor.Blue; SaveSettings(); return ConsoleColor.Blue;
                case "zöld": szin = ConsoleColor.Green; SaveSettings(); return ConsoleColor.Green;
                case "cián": szin = ConsoleColor.Cyan; SaveSettings(); return ConsoleColor.Cyan;
                case "vörös": szin = ConsoleColor.Red; ; SaveSettings(); return ConsoleColor.Red;
                case "lila": szin = ConsoleColor.Magenta; SaveSettings(); return ConsoleColor.Magenta;
                case "sárga": szin = ConsoleColor.Yellow; ; SaveSettings(); return ConsoleColor.Yellow;
                case "fehér": szin = ConsoleColor.White; ; SaveSettings(); return ConsoleColor.White;
                default: return szin;
            }
        }
    }

    //static void History()
    //{
    //    while (true)
    //    {
    //        Thread.Sleep(100);
    //        Console.Clear();
    //        Console.WriteLine("|-------------| Előzmények! |-------------|");
    //        Console.WriteLine("|---------| Készítette: Haltiru |---------|");
    //        Console.WriteLine();
    //        Console.WriteLine("Írd be: ");
    //        Console.WriteLine("  - a 'v' betűt, hogy visszalépj!");
    //        Console.WriteLine();
    //        Console.Write("> ");
    //        string h_input = Console.ReadLine();
    //        Console.Clear();
    //        switch (h_input.ToLower())
    //        {
    //            case "v": return;
    //            default: continue;
    //        }
    //    }
    //}

    static void Szamkitalalos()
    {
        Random rnd = new Random();
        int randomSzam = rnd.Next(1, 21);
        int tipp = 0;
        int tippSzam = randomSzam + 1;
        while (tippSzam != randomSzam)
        {


            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("|-------------| Számkitalálós játék |-------------|");
            Console.WriteLine("|-------------| Készítette: Haltiru |-------------|");
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Írj be egy számot 1 és 20 között!");
            if (tipp != 0)
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Eddig {tipp} tippeltél!");
            }
            if (Alltipp != 0)
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Eddig összesen {Alltipp} tippeltél!");
            }
            Console.Write($"[{DateTime.Now.ToString("HH:mm:ss")}] > ");
            try
            {
                tippSzam = Convert.ToInt32(Console.ReadLine());
                tipp++;
                Alltipp++;
            }
            catch (Exception)
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Hibás adat, számot kell megadni!");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            if (tippSzam < 1 || tipp > 20)
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] A számnak 1 és 20 között kell lennie!");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            if (tippSzam < randomSzam)
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] A szám nagyobb!");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            if (tippSzam > randomSzam)
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] A szám kisebb!");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            if (tippSzam == randomSzam)
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Gratulálok, kitaláltad a számot: {randomSzam}!");
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Nyomj meg egy gombot a kilépéshez!");
                Console.ReadKey();
                Console.Clear();
                return;
            }
        }
    }



    static void Settings()
    {
        while (true)
        {
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("|-------------| Beállítások |-------------|");
            Console.WriteLine("|---------| Készítette: Haltiru |---------|");
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Írd be: ");
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}]   - a 'v' betűt, hogy visszalépj!");
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}]   - a 'c' betűt, hogy a console színeit módosítsd!");
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}]   - az 'sz' betűt, hogy számkitalálós játékba lépj!");
            //Console.WriteLine("  - a 'h' betűt, hogy engedélyezd az előzményeket!");
            Console.WriteLine();
            Console.Write($"[{DateTime.Now.ToString("HH:mm:ss")}] > ");
            string s_input = Console.ReadLine();
            Console.Clear();
            switch (s_input.ToLower())
            {
                case "v": return;
                case "c":; Console.ForegroundColor = Color(); break;
                //case "h": History(); break;
                case "sz": Szamkitalalos(); break;
                default: continue;

            }
        }
    }

    static void Main(string[] args)
    {

        while (true)
        {
            Console.Title = ($"Számológép V: {ver} - Készítette: Haltiru");
            LoadSettings();
            Thread.Sleep(100);
            Console.WriteLine($"|-------------| Számológép! |-------------|");
            Console.WriteLine($"|---------| Készítette: Haltiru |---------|");
            Console.WriteLine($"|-----| A beállításokhoz írj: 'b'-t |-----|");
            Console.WriteLine($"|----| A kilépéshez írj: 'kilépés'-t |----|");
            Console.WriteLine();
            Console.Write($"[{DateTime.Now.ToString("HH:mm:ss")}] Add meg az első számot: ");
            string input = "0";
            string muvelet = "";
            string input2 = "0";
            List<string> kilepes = ["kilépés", "kilepes", "exit", "ex"];
            List<string> muveletek = ["+", "-", "*", "/", "^", "pow", "hatvany", "maradékos osztás", "%",];
            List<string> beallitas = ["b", "beallitasok", "beállítások", "s", "settings"];

            //Első szám
            input = Console.ReadLine();

            if (kilepes.Contains(input.ToLower()))
            {
                break;
            }
            if (beallitas.Contains(input.ToLower()))
            {
                Settings();
                continue;
            }
            if (!double.TryParse(input, out double szam1))
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Hibás adat, számot kell megadni!");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            //Művelet
            Console.Write($"[{DateTime.Now.ToString("HH:mm:ss")}] Add meg a műveletet (+, -, *, /, ^, %): ");
            muvelet = Console.ReadLine();
            if (kilepes.Contains(muvelet.ToLower()))
            {
                break;
            }
            if (beallitas.Contains(muvelet.ToLower()))
            {
                Settings();
                continue;
            }
            if (!muveletek.Contains(muvelet.ToLower()))
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Hibás művelet, csak +, -, *, /, ^ vagy % lehet!");
                Console.ReadKey();
                Console.Clear();
                continue;
            }

            //Második szám
            Console.Write($"[{DateTime.Now.ToString("HH:mm:ss")}] Add meg a második számot: ");
            input2 = Console.ReadLine();

            if (kilepes.Contains(input2.ToLower()))
            {
                break;
            }
            if (beallitas.Contains(input2.ToLower()))
            {
                Settings();
                continue;
            }
            if (!double.TryParse(input2, out double szam2))
            {
                Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Hibás adat, számot kell megadni!");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
            double eredmeny = 0;
            muvelet = muvelet.ToLower();
            switch (muvelet)
            {
                case "+": eredmeny = szam1 + szam2; break;
                case "-": eredmeny = szam1 - szam2; break;
                case "*": eredmeny = szam1 * szam2; break;
                case "/":
                    eredmeny = szam1 / szam2;
                    if (szam2 == 0)
                    {
                        Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] Nullával nem lehet osztani!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    eredmeny = szam1 / szam2;
                    break;
                case "^": eredmeny = (Math.Pow(szam1, szam2)); break;
                case "pow": eredmeny = (Math.Pow(szam1, szam2)); break;
                case "hatvany": eredmeny = (Math.Pow(szam1, szam2)); break;
                case "%": eredmeny = eredmeny = szam1 % szam2; break;
                case "maradékos osztás": eredmeny = eredmeny = szam1 % szam2; break;

            }
            switch (muvelet)
            {
                case "pow": Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] A művelet eredménye: {szam1} ^ {szam2} = {eredmeny}"); break;
                default: Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] A művelet eredménye: {szam1} {muvelet} {szam2} = {eredmeny}"); break;
            }
            Console.ReadKey();
            Console.Clear();
        }

    }
}