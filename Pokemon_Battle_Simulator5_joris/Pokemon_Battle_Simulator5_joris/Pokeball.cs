using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Pokeball
    {
        private bool inBall = true;
        private readonly Pokemon containedPokemon;

        // Constructor that adds the Pokémon to the Pokeball.
        public Pokeball(Pokemon pokemon)
        {
            containedPokemon = pokemon;
        }

        // Getter method for containedPokemon.
        public Pokemon ContainedPokemon()
        {
            return containedPokemon;
        }

        public void Throw()
        {
            if (!inBall)
            {
                Console.WriteLine("The Pokeball is already open!");
            }
            else
            {
                Console.WriteLine($"You threw the Pokeball! {ContainedPokemon().GetNickname()} appears!");
                inBall = false;
            }
        }

        public void Return()
        {
            if (!inBall)
            {
                Console.WriteLine($"{ContainedPokemon().GetNickname()} returns to its Pokeball. The lid closes up.");
                inBall = true;
            }
            else
            {
                Console.WriteLine("The Pokeball is already closed.");
            }
        }
    }
}