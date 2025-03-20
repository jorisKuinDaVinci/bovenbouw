using System;
using System.Collections.Generic;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Trainer
    {
        public string name;
        public List<Pokeball> belt = new List<Pokeball>(6);

        public Trainer(string name)
        {
            this.name = name;
            Console.WriteLine(name + ", geef je Pokémon een nickname!");

            // Adding two of each Pokémon type to the belt
            belt.Add(new Pokeball(new Charmander(GetPokemonNickname("Charmander"))));
            belt.Add(new Pokeball(new Charmander(GetPokemonNickname("Charmander"))));
            belt.Add(new Pokeball(new Squirtle(GetPokemonNickname("Squirtle"))));
            belt.Add(new Pokeball(new Squirtle(GetPokemonNickname("Squirtle"))));
            belt.Add(new Pokeball(new Bulbasaur(GetPokemonNickname("Bulbasaur"))));
            belt.Add(new Pokeball(new Bulbasaur(GetPokemonNickname("Bulbasaur"))));
        }

        public string GetPokemonNickname(string species)
        {
            Console.Write("Voer een nickname in voor " + species + ": ");
            return Console.ReadLine();
        }

        public void ThrowPokeball(int index)
        {
            if (index < 0 || index >= belt.Count)
            {
                Console.WriteLine("Invalid Pokeball index.");
                return;
            }

            Console.WriteLine(name + " throws a Pokeball!");
            belt[index].Throw();
        }

        public void ReturnPokemon(int index)
        {
            if (index < 0 || index >= belt.Count)
            {
                Console.WriteLine("Invalid Pokeball index.");
                return;
            }

            Console.WriteLine(name + " returns the Pokémon.");
            belt[index].Return();
        }
    }
}
