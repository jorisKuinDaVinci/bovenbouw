using System;

namespace Openbaar_Vervoer
{
    public class Train
    {
        public int aantalWielen;
        public int aantalPlaatsen;
        public Person conducteur;

        public Train(int wielAantal, int plaatsen)
        {
            this.aantalWielen = wielAantal;
            this.aantalPlaatsen = plaatsen;
        }

        public int rijden()
        {
            return 130;
        }

        public int remmen()
        {
            return 0;
        }

        public void giveControl(Person nieuweConducteur)
        {
            this.conducteur = nieuweConducteur;
        }
    }

    public class Person
    {
        public string name;
        public string lastName;
        public int age;

        public Person(string name, string lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public void bemanTrein(Train trein)
        {
            //neem controle over de trein
            trein.giveControl(this);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Person persoon1 = new Person("kees", "Panda", 93);

            Train eigenTrein = new Train(7, 30);
            Train tweedeTrein = new Train(20, 29);

            persoon1.bemanTrein(eigenTrein);

            Console.WriteLine(eigenTrein.conducteur.name);

            Console.WriteLine(eigenTrein.aantalWielen);
            Console.WriteLine(tweedeTrein.aantalWielen);
        }
    }
}