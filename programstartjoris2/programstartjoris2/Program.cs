using System;
using programstartjoris2;

namespace Openbaar_Vervoer
{

    class Program
    {
        public static void Main(string[] args)
        {
            Person persoon1 = new Person("kees", "Panda", 93);

            //Train eigenTrein = new Train(7, 30);
            //Train tweedeTrein = new Train(20, 29);

            Tram tram1 = new Tram(38, 2, 8);
            Console.WriteLine(tram1.aantalOVPaaltjes);
            Console.WriteLine(tram1.aantalPlaatsen);

            //persoon1.bemanTrein(eigenTrein);

            //Console.WriteLine(eigenTrein.conducteur.name);

            //Console.WriteLine(eigenTrein.aantalWielen);
            //Console.WriteLine(tweedeTrein.aantalWielen);
        }
    }
}