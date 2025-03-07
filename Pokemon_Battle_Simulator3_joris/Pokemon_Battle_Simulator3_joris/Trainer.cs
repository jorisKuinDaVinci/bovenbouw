using System;
using System.Collections.Generic;

namespace Pokemon_Battle_Simulator3_joris
{
    public class Trainer
    {
        public string name;
        public List<Pokeball> belt = new List<Pokeball>(6);

        public Trainer(string name)
        {
            this.name = name;

            for (int i = 1; i <= 6; i++)
            {
                belt.Add(new Pokeball(new Charmander("Charmander" + i)));
            }
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
