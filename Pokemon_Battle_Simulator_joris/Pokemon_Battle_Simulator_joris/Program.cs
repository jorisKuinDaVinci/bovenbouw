using System;

namespace PokemonBattleSimulator
{
    //Charmander class
    public class Charmander
    {
        public string Nickname;
        public string Strength = "Fire";
        public string Weakness = "Water";

        //Constructor
        public Charmander(string nickname)
        {
            Nickname = nickname;
        }

        //battle cry
        public void BattleCry()
        {
            Console.WriteLine(Nickname + "! " + Nickname + "!");
        }

        //rename Charmander
        public void Rename(string newName)
        {
            if (newName != "")
            {
                Nickname = newName;
            }
            else
            {
                Console.WriteLine("Invalid name. Try again.");
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            //The player starts the game.
            Console.WriteLine("Welcome to the Pokémon battle simulator!");

            //The player gives a name to a Charmander.
            Console.Write("Enter a name for your Charmander: ");
            string name = Console.ReadLine();
            Charmander charmander = new Charmander(name);

            while (true)
            {
                //The Charmander does its battle cry ten times.
                for (int i = 0; i < 10; i++)
                {
                    charmander.BattleCry();
                }

                //The player can give a new name to the same Charmander.
                Console.Write("Enter a new name for your Charmander (or type 'quit' to exit): ");
                string newName = Console.ReadLine();

                if (newName.ToLower() == "quit")
                {
                    break;
                }

                charmander.Rename(newName);
            }

            Console.WriteLine("Game over. Thanks for playing!");
        }
    }
}