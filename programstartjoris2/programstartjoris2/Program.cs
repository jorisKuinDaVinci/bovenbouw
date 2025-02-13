using System;

namespace Openbaar_Vervoer
{
    class Train
    {
        public int aantalWielen;
        public int aantalPlaatsen;
        public string conducteur;

        public Train(int wielAantal, int plaatsen, string conducteursnaam)
        {
            this.aantalWielen = wielAantal;
            this.aantalPlaatsen = plaatsen;
            this.conducteur = conducteursnaam;
        }

        public int rijden()
        {
            return 130;
        }

        public int remmen()
        {
            return 0;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Train eigenTrein = new Train(7, 30, "Eugene");
            Console.WriteLine(eigenTrein.aantalWielen);
            Console.WriteLine("Hello World");
        }
    }
}