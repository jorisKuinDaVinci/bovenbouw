namespace Openbaar_Vervoer
{
    using System.Threading;
    
    class Program {
        public static void Main(string[] args)
        {
            Person persoon1 = new Person("Kees", "Panda", 93);
            Person persoon2 = new Person("Hans", "Kever", 54);

            Tram tram1 = new Tram(38, 2, 8);
            Tram tram2 = new Tram(44, 108, 11);
            Train trein1 = new Train(38, 2);
            persoon1.bemanVoertuig(trein1);
            persoon2.bemanVoertuig(tram1);

            persoon1.buyOVCard(OVTypes.BUSINESSOV);
            persoon2.buyOVCard(OVTypes.STUDENTOV);

            // ergens in de code 
                if(persoon1.OVType == OVTypes.STUDENTOV)
            //


            tram1.doCheckin();
            tram1.doCheckin();
            tram1.doCheckin();

            tram2.doCheckin();
            tram2.doCheckin();
            tram2.doCheckin();
            tram2.doCheckin();
            
            Console.WriteLine($"Het aantal OVPaaltjes in deze tram is {tram1.getAantalOVPaaltjes()}");
            tram1.setAantalOVPaaltjes(12);
            Console.WriteLine($"Het aantal OVPaaltjes in deze tram is {tram1.getAantalOVPaaltjes()}");
            Console.WriteLine($"Het naam van de conducteur van deze trein is {trein1.conducteur.name} {trein1.conducteur.lastName}");
            Console.WriteLine($"Het aantal checkins in deze tram is {Vervoersmiddel.aantalCheckins}");
        }
    }
}