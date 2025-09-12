using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Matematika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int pontszam = 19 * 3 + 12 * 1 + 7 * 0 - 8;
            //Console.WriteLine($"A milán pontszáma a kérdéses szezonban {pontszam}");

            //Console.WriteLine();
            //Console.WriteLine("szam1:");
            //int szam1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("szam2: ");
            //int szam2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine( (double)(szam1+szam2) / (szam1-szam2));
            //Console.WriteLine();
            //Console.WriteLine("Négyzet oldal hossza: ");

            //double oldalhossz = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{4* oldalhossz} cm, {Math.Pow(oldalhossz,2)} cm^2");
            //Console.WriteLine();
            //Console.WriteLine($"Négyzetgyök szorzat: {Math.Sqrt(szam1)*Math.Sqrt(szam2)}");

            //const double Sier = 2.58498;
            //const double Euler = 0.5772;

            //Console.WriteLine($"{Math.Pow(Sier+Euler,2)-(Sier*Euler)}");

            //Console.WriteLine("Oldalak száma 2 nél nagyobb:");
            //int oldal = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{oldal * (oldal - 3) / 2} átlok száma");
            //Console.WriteLine($"{(oldal - 2) * 180} oldalak száma");


            //int emberek = Convert.ToInt32(Console.ReadLine());
            //int asztalok = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{Math.Ceiling((double)emberek / asztalok)}");

            //const double gyok2= 1.41;
            //const double gyok3 = 1.73;
            //Console.WriteLine($"{gyok3-gyok2}");

            //double szam1 = Convert.ToDouble(Console.ReadLine());
            //double szam2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{(szam1 + szam2)/2}");
            //Console.WriteLine($"{Math.Sqrt(szam1 * szam2)}");

            //double alfka = Convert.ToDouble(Console.ReadLine());
            //double betka = Convert.ToDouble(Console.ReadLine());
            //double gammka = 180 - (alfka + betka);
            //Console.WriteLine($"{gammka}");

            //int Fahr = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"{((Fahr-32)/9)*5}");


            // double cm = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine($"{(cm*22):F2}");

            //double szelesseg = Convert.ToDouble(Console.ReadLine());
            //double hosszusag = Convert.ToDouble(Console.ReadLine());
            //double magassag = Convert.ToDouble(Console.ReadLine());
            //double felszin = szelesseg * hosszusag + hosszusag * magassag + magassag * szelesseg;
            //double terfogat = szelesseg * hosszusag * magassag;
            //Console.WriteLine($"{felszin}, {terfogat}");

            //double testsuly = Convert.ToDouble(Console.ReadLine());
            //double testmagassag = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"{testsuly/(Math.Pow(testmagassag,2))}");


            //double szam1 = Convert.ToDouble(Console.ReadLine()); 
            //double szam2 = Convert.ToDouble(Console.ReadLine());
            //double h = 2 / (1 / szam1 + 1 / szam2);
            //Console.WriteLine(h);

            //double ellenalas1 = Convert.ToDouble(Console.ReadLine());
            //double ellenalas2 = Convert.ToDouble(Console.ReadLine());
            //double eredmeny = (ellenalas1 * ellenalas2)/ (ellenalas1+ellenalas2);
            //Console.WriteLine(eredmeny);

            //int matterhorn = 4478;
            //int toblerone = 1608;
            //Console.WriteLine($"{(double)(matterhorn - toblerone)/100}");

            //double Sugar = Convert.ToDouble(Console.ReadLine());
            //double sugar = Convert.ToDouble(Console.ReadLine());
            //double Terulet = Math.Pow(Sugar, 2) * Math.PI;
            //double terulet = Math.Pow(sugar, 2) * Math.PI;
            //double kter = Terulet - terulet;
            //Console.WriteLine($"{kter:F1}");

            //int netto = Convert.ToInt32(Console.ReadLine());
            //int afa = Convert.ToInt32(Console.ReadLine());
            //double brutto = netto * ((double)(100 + afa) / 100);
            //Console.WriteLine($"{brutto:C0}");

            //int fhossz_perc= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{fhossz_perc/60} {fhossz_perc%60}");

            //const double aranymetszes= 1.618;
            //const double euler = 2.71;
            //Console.WriteLine($"{(aranymetszes*euler):F3}");
            //Console.WriteLine($"{Math.Round(aranymetszes * euler,3)}");


            double befogo1 = Convert.ToDouble(Console.ReadLine());
            double befogo2 = Convert.ToDouble(Console.ReadLine());
            double atfogo = Math.Sqrt(Math.Pow(befogo1, 2) + Math.Pow(befogo2, 2));
            double terulet = (befogo1 * befogo2)/2;
            Console.WriteLine($"{atfogo:F3}; {terulet:F0}");
























            Console.ReadKey();
        }
    }
}
