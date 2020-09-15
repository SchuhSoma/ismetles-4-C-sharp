using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Feladat1();
            Console.WriteLine("\n---------------------------\n");
            Feladat2();
            Console.WriteLine("\n---------------------------\n");
            Feladat3();
            Console.WriteLine("\n---------------------------\n");
            Feladat4();
            Console.WriteLine("\n---------------------------\n");
            Feladat5();
            Console.WriteLine("\n---------------------------\n");
            Console.ReadKey();
        }

        private static void Feladat5()
        {
            Console.WriteLine("Feladat 5: átlag sebesség");
            Console.Write("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            Console.Write("Kérem adja meg a kocsi által megtett út hosszát: ");
            double Ut = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg mennyi idő alatt tette meg az utat: ");
            double Ido = double.Parse(Console.ReadLine());
            double AtlagSebesseg = Ut / Ido;
            Console.WriteLine("{0} átlag sebessége: {1:0.00}", Nev, AtlagSebesseg);
        }

        private static void Feladat4()
        {
            Console.WriteLine("Feladat 5: Henger felszíne, térfogata");
            Console.Write("Kérem adja meg a henger magassagát: ");
            double Magassag = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg a henger sugár: ");
            double Sugar = double.Parse(Console.ReadLine());
            double Terfogat = Math.PI * Math.Pow(Sugar, 2) * Magassag;
            double Felszin = 2*Math.PI * Sugar*(Sugar + Magassag);
            Console.WriteLine("A henger térfogata: {0}", Terfogat);
            Console.WriteLine("A henger felszíne: {0}", Felszin);
        }

            private static void Feladat3()
        {
            Console.WriteLine("Feladat 3: lakosság");
            Console.Write("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            Console.Write("Kérem adja meg a települése nevét: ");
            string TelepuesNeve = Console.ReadLine();
            eleje:
            Console.Write("Kérem adja meg a település lélekszámát: ");
            int Lelekszam = int.Parse(Console.ReadLine());
            if(Lelekszam<0)
            {
                Console.WriteLine("Hibás adatot adott meg kezdje újra");
                goto eleje;
                
            }
            else
            {
                if(Lelekszam>1000000)
                { Console.WriteLine("{0} az Ön {1} egy Metropolisban él", Nev, TelepuesNeve); }
                if(100000<Lelekszam && Lelekszam<=1000000)
                { Console.WriteLine("{0} az Ön {1} egy Nagyvárosban él", Nev, TelepuesNeve); }
                if (20000 < Lelekszam && Lelekszam <= 100000)
                { Console.WriteLine("{0} az Ön {1} egy Közepesvárosban él", Nev, TelepuesNeve); }
                if (5000 < Lelekszam && Lelekszam <= 20000)
                { Console.WriteLine("{0} az Ön {1} egy Kisvárosban él", Nev, TelepuesNeve); }
                if (0< Lelekszam && Lelekszam <= 5000)
                { Console.WriteLine("{0} az Ön {1} egy Községben él", Nev, TelepuesNeve); }
            }
        }

        private static void Feladat2()
        {
            Console.WriteLine("Feladat 2: bűvös kocka");
            int KockaDobas;
            double Osszeg = 0;
            int db = 0;
            for (int i = 1; i < 15; i++)
            {
                KockaDobas = rnd.Next(1, 9);
                Osszeg += KockaDobas;
                if(KockaDobas==7)
                { db++; }
                Console.WriteLine("{0} dobás : {1}", i,KockaDobas);
            }
            double Atlag = (double)Osszeg / 14;
            Console.WriteLine("\n\tA dobások összege: {0}", Osszeg);
            Console.WriteLine("\n\tA dobások átlaga: {0:0.00}", Atlag);
            Console.WriteLine("\n\tEnnyi alkalommal dobtunk 7-et: {0}",db);
        }

        private static void Feladat1()
        {
            Console.WriteLine("Feldat 1 számok kiiratása");
            int Keresetett;
            for (int i = 0; i < 21; i++)
            {
                Keresetett = 6 * i;
                if(Keresetett%4==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} , ", Keresetett);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("{0} , ", Keresetett);
                }
            }
        }
    }
}
