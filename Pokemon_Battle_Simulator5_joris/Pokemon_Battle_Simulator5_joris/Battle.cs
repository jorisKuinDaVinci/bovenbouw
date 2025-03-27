using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Battle
    {
        private Trainer trainer1;
        private Trainer trainer2;
        public static int roundsFought = 0;
        public static int battlesFought = 0;

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
        }

        public void Start()
        {
            battlesFought++;
            Random random = new Random();

            while (true)
            {
                roundsFought++;
                Console.WriteLine($"Round {roundsFought}:");

                // Check if both trainers have Pokémon
                if (trainer1.GetBeltSize() == 0 || trainer2.GetBeltSize() == 0)
                {
                    Console.WriteLine("One of the trainers has no Pokémon left. The battle is over!");
                    break;
                }

                // Trainer 1 chooses a random Pokémon
                int index1 = random.Next(0, trainer1.GetBeltSize());
                trainer1.ThrowPokeball(index1);
                Pokemon pokemon1 = trainer1.GetPokemonFromBelt(index1);

                // Trainer 2 chooses a random Pokémon
                int index2 = random.Next(0, trainer2.GetBeltSize());
                trainer2.ThrowPokeball(index2);
                Pokemon pokemon2 = trainer2.GetPokemonFromBelt(index2);

                if (pokemon1.GetStrength() == pokemon2.GetWeakness())
                // Determine the winner based on Pokémon types
                {
                    Console.WriteLine($"{pokemon1.GetNickname()} wins the round!");
                    trainer2.ReturnPokemon(index2);
                }
                else if (pokemon2.GetStrength() == pokemon1.GetWeakness())
                {
                    Console.WriteLine($"{pokemon2.GetNickname()} wins the round!");
                    trainer1.ReturnPokemon(index1);
                }
                else
                {
                    Console.WriteLine("It's a draw!");
                    trainer1.ReturnPokemon(index1);
                    trainer2.ReturnPokemon(index2);
                }

                Console.WriteLine("\nPress Enter to continue to the next round...");
                Console.ReadLine();
            }
        }
    }
}