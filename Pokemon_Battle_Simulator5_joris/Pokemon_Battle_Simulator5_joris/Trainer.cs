using System;
using System.Collections.Generic;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Trainer
    {
        private const int MaxPokeballs = 6;
        public string Name { get; }

        private List<Pokeball> _belt = new List<Pokeball>(MaxPokeballs);
        public IReadOnlyList<Pokeball> Belt => _belt;

        public Trainer(string name)
        {
            Name = name;
            Console.WriteLine($"{Name}, geef je Pokémon een nickname!");
            AddPokemonToBelt(new Charmander(GetPokemonNickname("Charmander")));
            AddPokemonToBelt(new Charmander(GetPokemonNickname("Charmander")));
            AddPokemonToBelt(new Squirtle(GetPokemonNickname("Squirtle")));
            AddPokemonToBelt(new Squirtle(GetPokemonNickname("Squirtle")));
            AddPokemonToBelt(new Bulbasaur(GetPokemonNickname("Bulbasaur")));
            AddPokemonToBelt(new Bulbasaur(GetPokemonNickname("Bulbasaur")));
        }

        private string GetPokemonNickname(string species)
        {
            Console.Write($"Voer een nickname in voor {species}: ");
            return Console.ReadLine();
        }

        private void AddPokemonToBelt(Pokemon pokemon)
        {
            if (_belt.Count < MaxPokeballs)
                _belt.Add(new Pokeball(pokemon));  // Gebruik de private lijst in plaats van de readonly getter
            else
                Console.WriteLine("Cannot add more Pokémon, belt is full!");
        }

        public void ThrowPokeball(int index)
        {
            if (index >= 0 && index < Belt.Count)
            {
                Console.WriteLine($"{Name} throws a Pokeball!");
                Belt[index].Throw();
            }
            else
            {
                Console.WriteLine("Invalid Pokeball index.");
            }
        }

        public void ReturnPokemon(int index)
        {
            if (index >= 0 && index < Belt.Count)
            {
                Console.WriteLine($"{Name} returns the Pokémon.");
                Belt[index].Return();
            }
            else
            {
                Console.WriteLine("Invalid Pokeball index.");
            }
        }
    }
}
