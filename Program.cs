using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180829_001
{
    public class Program
    {
        public static string brandstofInput;
        public static string keuzeland;

        public static void Main(string[] args)
        {
            int mainLoop = 1;
            do
            {
                Console.WriteLine("Welkom! Vergelijk hier uw betaalde benzine- of dieselprijs met het landelijk gemiddelde*!");
                Console.WriteLine("*Bron: ANWB, 29 augustus 2018");
                KiesLand();
                SoortBrandstof();
                Console.WriteLine("");
                Console.WriteLine("Wilt u nog een vergelijking uitvoeren? J/N");
                string extraVergelijking = Console.ReadLine();
                if (extraVergelijking == "J")
                {
                    Console.WriteLine("");
                }
                else if (extraVergelijking == "N")
                {
                    Console.WriteLine("Programma wordt gesloten...");
                    Console.WriteLine("Made by Luuk Walhout - 2018");
                    Console.WriteLine("Written in C# for Windows and .NET Core");
                    mainLoop = 0;
                    Afsluiten();
                }
                else
                {
                    Afsluiten();
                }
            } while (mainLoop == 1);
            
        }
        public static void SoortBrandstof()
        {
            string bsInput = "false";
            do
            {
                Console.WriteLine("Diesel, Benzine of LPG? (hoofdlettergevoelig)");
                brandstofInput = Console.ReadLine();
            
                if (brandstofInput == "Diesel")
                {
                    Diesel.DieselLand();
                    bsInput = "true";
                }
                else if (brandstofInput == "Benzine")
                {
                    Diesel.BenzineLand();
                    bsInput = "true";
                }
                else if (brandstofInput == "LPG")
                {
                    Diesel.LPGLand();
                    bsInput = "true";
                }
                else if (brandstofInput == "afsluiten")
                {
                    Afsluiten();
                    bsInput = "true";
                }
                else
                {
                    Console.WriteLine("Fout! Probeer opnieuw of typ afsluiten");
                }
            } while (bsInput == "false");

        }
        public static void KiesLand()
        {
            Console.WriteLine("Kies uit een van de volgende landen: NL, B, D, E of F");
            keuzeland = Console.ReadLine();
        }
        public static void Afsluiten()
        {
            Environment.Exit(0);
        }
    }
}
