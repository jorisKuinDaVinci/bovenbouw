using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Battle
    {
        private Trainer _trainer1;
        private Trainer _trainer2;
        private static int _roundsFought = 0;
        private static int _battlesFought = 0;

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            _trainer1 = trainer1;
            _trainer2 = trainer2;
        }

        public void Start()
        {
            _battlesFought++;
            Pokemon pokemon1 = null;
            Pokemon pokemon2 = null;
            Random random = new Random();

            while (true)
            {
                _roundsFought++;
                Console.WriteLine($"Round {_roundsFought}:");

                // Trainer 1 throws a random Pokeball
                int index1 = random.Next(0, 6);
                _trainer1.ThrowPokeball(index1);
                pokemon1 = _trainer1.Belt[index1].ContainedPokemon;

                // Trainer 2 throws a random Pokeball
                int index2 = random.Next(0, 6);
                _trainer2.ThrowPokeball(index2);
                pokemon2 = _trainer2.Belt[index2].ContainedPokemon;

                // Determine winner
                if (pokemon1.Strength == pokemon2.Weakness)
                {
                    Console.WriteLine("Pokemon1 wins the round!");
                    _trainer2.ReturnPokemon(index2);
                }
                else if (pokemon2.Strength == pokemon1.Weakness)
                {
                    Console.WriteLine("Pokemon2 wins the round!");
                    _trainer1.ReturnPokemon(index1);
                }
                else
                {
                    Console.WriteLine("It's a draw!");
                    _trainer1.ReturnPokemon(index1);
                    _trainer2.ReturnPokemon(index2);
                }

                Console.WriteLine("\nPress Enter to continue to the next round...");
                Console.ReadLine();
            }
        }
    }
}
