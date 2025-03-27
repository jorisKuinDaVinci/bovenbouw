using System;
using System.Collections.Generic;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Trainer
    {
        private const int MaxPokeballs = 6;
        private string name;
        private List<Pokeball> belt = new List<Pokeball>(MaxPokeballs);

        public Trainer(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}, geef je Pokémon een nickname!");
            AddPokemonToBelt(new Charmander(GetPokemonNickname("Charmander")));
            AddPokemonToBelt(new Charmander(GetPokemonNickname("Charmander")));
            AddPokemonToBelt(new Squirtle(GetPokemonNickname("Squirtle")));
            AddPokemonToBelt(new Squirtle(GetPokemonNickname("Squirtle")));
            AddPokemonToBelt(new Bulbasaur(GetPokemonNickname("Bulbasaur")));
            AddPokemonToBelt(new Bulbasaur(GetPokemonNickname("Bulbasaur")));
        }

        // Getter method for Name
        public string Name()
        {
            return name;
        }

        // Return a copy of the belt list to prevent modification from outside the class
        public List<Pokeball> Belt()
        {
            return new List<Pokeball>(belt);
        }

        private string GetPokemonNickname(string species)
        {
            Console.Write($"Voer een nickname in voor {species}: ");
            return Console.ReadLine();
        }

        private void AddPokemonToBelt(Pokemon pokemon)
        {
            if (belt.Count < MaxPokeballs)
                belt.Add(new Pokeball(pokemon));
            else
                Console.WriteLine("Cannot add more Pokémon, belt is full!");
        }

        public void ThrowPokeball(int index)
        {
            if (index >= 0 && index < Belt().Count)
            {
                Console.WriteLine($"{Name()} throws a Pokeball!");
                Belt()[index].Throw();
            }
            else
            {
                Console.WriteLine("Invalid Pokeball index.");
            }
        }

        public void ReturnPokemon(int index)
        {
            if (index >= 0 && index < Belt().Count)
            {
                Console.WriteLine($"{Name()} returns the Pokémon.");
                Belt()[index].Return();
            }
            else
            {
                Console.WriteLine("Invalid Pokeball index.");
            }
        }
    }
}