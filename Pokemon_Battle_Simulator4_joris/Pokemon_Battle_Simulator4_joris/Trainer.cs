using System;
using System.Collections.Generic;

namespace Pokemon_Battle_Simulator4_joris
{
    public class Trainer
    {
        public string name;
        public List<Pokeball> belt = new List<Pokeball>(6);

        public Trainer(string name)
        {
            this.name = name;

            // Adding two of each Pokémon type to the belt
            belt.Add(new Pokeball(new Charmander("Charmander1")));
            belt.Add(new Pokeball(new Charmander("Charmander2")));
            belt.Add(new Pokeball(new Squirtle("Squirtle1")));
            belt.Add(new Pokeball(new Squirtle("Squirtle2")));
            belt.Add(new Pokeball(new Bulbasaur("Bulbasaur1")));
            belt.Add(new Pokeball(new Bulbasaur("Bulbasaur2")));
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
