using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Battle
    {
        private Trainer trainer1;
        private Trainer trainer2;
        private static int roundsFought = 0;
        private static int battlesFought = 0;

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            trainer1 = trainer1;
            trainer2 = trainer2;
        }

        public void Start()
        {
            battlesFought++;
            Random random = new Random();

            while (true)
            {
                roundsFought++;
                Console.WriteLine($"Round {roundsFought}:");

                // Check if both trainers have Pokémon.
                if (trainer1.GetBeltSize() == 0 || trainer2.GetBeltSize() == 0)
                {
                    Console.WriteLine("Een van de trainers heeft geen Pokémon meer. De strijd is voorbij!");
                    break;
                }

                // Trainer 1 chooses a random Pokémon.
                int index1 = random.Next(0, trainer1.GetBeltSize());
                trainer1.ThrowPokeball(index1);
                Pokemon pokemon1 = trainer1.GetPokemonFromBelt(index1);

                // Trainer 2 chooses a random Pokémon.
                int index2 = random.Next(0, trainer2.GetBeltSize());
                trainer2.ThrowPokeball(index2);
                Pokemon pokemon2 = trainer2.GetPokemonFromBelt(index2);

                // Determine the winner.
                if (pokemon1.GetStrength() == pokemon2.GetWeakness())
                {
                    Console.WriteLine($"{pokemon1.GetNickname()} wint de ronde!");
                    trainer2.ReturnPokemon(index2);
                }
                else if (pokemon2.GetStrength() == pokemon1.GetWeakness())
                {
                    Console.WriteLine($"{pokemon2.GetNickname()} wint de ronde!");
                    trainer1.ReturnPokemon(index1);
                }
                else
                {
                    Console.WriteLine("Het is een gelijkspel!");
                    trainer1.ReturnPokemon(index1);
                    trainer2.ReturnPokemon(index2);
                }

                Console.WriteLine("\nDruk op Enter om door te gaan naar de volgende ronde...");
                Console.ReadLine();
            }
        }
    }
}