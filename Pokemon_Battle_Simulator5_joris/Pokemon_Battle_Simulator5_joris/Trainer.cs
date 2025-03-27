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
            Console.WriteLine($"{this.name}, give your Pokémon a nickname!");
            AddPokemonToBelt(new Charmander(GetPokemonNickname("Charmander")));
            AddPokemonToBelt(new Charmander(GetPokemonNickname("Charmander")));
            AddPokemonToBelt(new Squirtle(GetPokemonNickname("Squirtle")));
            AddPokemonToBelt(new Squirtle(GetPokemonNickname("Squirtle")));
            AddPokemonToBelt(new Bulbasaur(GetPokemonNickname("Bulbasaur")));
            AddPokemonToBelt(new Bulbasaur(GetPokemonNickname("Bulbasaur")));
        }

        // Getter method for Name
        public string GetName()
        {
            return this.name;
        }

        private string GetPokemonNickname(string species)
        {
            Console.Write($"Enter a nickname for {species}: ");
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
            if (index >= 0 && index < belt.Count)
            {
                Console.WriteLine($"{GetName()} throws a Pokéball!");
                belt[index].Throw();
            }
            else
            {
                Console.WriteLine("Invalid Pokéball index.");
            }
        }

        public void ReturnPokemon(int index)
        {
            if (index >= 0 && index < belt.Count)
            {
                Console.WriteLine($"{GetName()} returns the Pokémon.");
                belt[index].Return();
            }
            else
            {
                Console.WriteLine("Invalid Pokéball index.");
            }
        }

        // Returns the number of Pokémon on the belt
        public int GetBeltSize()
        {
            return belt.Count;
        }

        // Retrieves a Pokémon from the Pokéball list
        public Pokemon GetPokemonFromBelt(int index)
        {
            if (index >= 0 && index < belt.Count)
            {
                return belt[index].ContainedPokemon(); // Return the Pokémon contained in the Pokéball at the given index
            }
            else
            {
                Console.WriteLine("Invalid index. No Pokémon found at this position.");
                return null; // Return null if the index is invalid
            }
        }
    }
}