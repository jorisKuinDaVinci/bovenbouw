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
            Random random = new Random();

            while (true)
            {
                _roundsFought++;
                Console.WriteLine($"Round {_roundsFought}:");

                // Check of beide trainers Pokémon hebben
                if (_trainer1.GetBeltSize() == 0 || _trainer2.GetBeltSize() == 0)
                {
                    Console.WriteLine("Een van de trainers heeft geen Pokémon meer. De strijd is voorbij!");
                    break;
                }

                // Trainer 1 kiest een willekeurige Pokémon
                int index1 = random.Next(0, _trainer1.GetBeltSize());
                _trainer1.ThrowPokeball(index1);
                Pokemon pokemon1 = _trainer1.GetPokemonFromBelt(index1);

                // Trainer 2 kiest een willekeurige Pokémon
                int index2 = random.Next(0, _trainer2.GetBeltSize());
                _trainer2.ThrowPokeball(index2);
                Pokemon pokemon2 = _trainer2.GetPokemonFromBelt(index2);

                // Bepaal de winnaar
                if (pokemon1.Strength == pokemon2.Weakness)
                {
                    Console.WriteLine($"{pokemon1.Nickname} wint de ronde!");
                    _trainer2.ReturnPokemon(index2);
                }
                else if (pokemon2.Strength == pokemon1.Weakness)
                {
                    Console.WriteLine($"{pokemon2.Nickname} wint de ronde!");
                    _trainer1.ReturnPokemon(index1);
                }
                else
                {
                    Console.WriteLine("Het is een gelijkspel!");
                    _trainer1.ReturnPokemon(index1);
                    _trainer2.ReturnPokemon(index2);
                }

                Console.WriteLine("\nDruk op Enter om door te gaan naar de volgende ronde...");
                Console.ReadLine();
            }
        }
    }
}