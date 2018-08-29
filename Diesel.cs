using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180829_001
{
    public class Diesel
    {
        public static double gemprijs; //Gemiddelde brandstofprijs

        public static void ProgramX()
        {
            Console.WriteLine("U heeft gekozen voor {0}, de actuele gemiddelde literprijs in {1} is € {2}", Program.brandstofInput, Program.keuzeland, gemprijs);
            Console.WriteLine("Hoeveel heeft u betaald per liter?");
            string betaaldePrijsString = Console.ReadLine();
            double betaaldePrijs;
            Double.TryParse(betaaldePrijsString, out betaaldePrijs);
            Console.WriteLine("U heeft € {0} per liter betaald", betaaldePrijs);
            if (betaaldePrijs > gemprijs)
            {
                double prijsverschil = betaaldePrijs - gemprijs;
                string prijsverschilString = string.Format("{0:N3}", prijsverschil); //string.Format("{0:N3}", prijsverschil) is maximaal 3 decimalen achter de komma
                Console.WriteLine("U heeft meer dan het gemiddelde betaald. " +
                    "Een reden hiervoor kan zijn is dat u langs de snelweg" +
                    " of premium brandstof getankt hebt");
                Console.WriteLine("Het verschil tov van het landelijk gemiddelde (per liter) is € {0}", prijsverschilString);
            }
            else if (betaaldePrijs < gemprijs)
            {
                double prijsverschil = gemprijs - betaaldePrijs;
                string prijsverschilString = string.Format("{0:N3}", prijsverschil);
                Console.WriteLine("U heeft minder betaald per liter dan het landelijk gemiddelde!");
                Console.WriteLine("Uw besparing tov van het landelijk gemiddelde (per liter) is € {0}", prijsverschilString);
            }
            else if (betaaldePrijs == gemprijs)
            {
                Console.WriteLine("U heeft precies hetzelfde bedrag per liter betaald van het landelijk gemiddelde");
            }
            else
            {
                Console.WriteLine("Er is iets fout gegaan. Herstart het programma.");
            }
        }
        public static void DieselLand()
        {
            if (Program.keuzeland == "NL")
            {
                gemprijs = prijzen.dieselprijsNL;
                ProgramX();
            }
            else if (Program.keuzeland == "B")
            {
                gemprijs = prijzen.dieselprijsB;
                ProgramX();
            }
            else if (Program.keuzeland == "D")
            {
                gemprijs = prijzen.dieselprijsD;
                ProgramX();
            }
            else if (Program.keuzeland == "E")
            {
                gemprijs = prijzen.dieselprijsE;
                ProgramX();
            }
            else if (Program.keuzeland == "F")
            {
                gemprijs = prijzen.dieselprijsF;
                ProgramX();
            }
            else
            {
                Console.WriteLine("Fout. Druk op een toets om af te sluiten!");
                Console.ReadLine();
                Program.Afsluiten();
            }
        }
        public static void BenzineLand()
        {
            if (Program.keuzeland == "NL")
            {
                gemprijs = prijzen.benzineprijsNL;
                ProgramX();
            }
            else if (Program.keuzeland == "B")
            {
                gemprijs = prijzen.benzineprijsB;
                ProgramX();
            }
            else if (Program.keuzeland == "D")
            {
                gemprijs = prijzen.benzineprijsD;
                ProgramX();
            }
            else if (Program.keuzeland == "E")
            {
                gemprijs = prijzen.benzineprijsE;
                ProgramX();
            }
            else if (Program.keuzeland == "F")
            {
                gemprijs = prijzen.benzineprijsF;
                ProgramX();
            }
            else
            {
                Console.WriteLine("Fout. Druk op een toets om af te sluiten!");
                Console.ReadLine();
                Program.Afsluiten();
            }
        }
        public static void LPGLand()
        {
            if (Program.keuzeland == "NL")
            {
                gemprijs = prijzen.LPGprijsNL;
                ProgramX();
            }
            else if (Program.keuzeland == "B")
            {
                gemprijs = prijzen.LPGprijsB;
                ProgramX();
            }
            else if (Program.keuzeland == "D")
            {
                gemprijs = prijzen.LPGprijsD;
                ProgramX();
            }
            else if (Program.keuzeland == "E")
            {
                gemprijs = prijzen.LPGprijsE;
                ProgramX();
            }
            else if (Program.keuzeland == "F")
            {
                gemprijs = prijzen.LPGprijsF;
                ProgramX();
            }
            else
            {
                Console.WriteLine("Fout. Druk op een toets om af te sluiten!");
                Console.ReadLine();
                Program.Afsluiten();
            }
        }
    }
}
