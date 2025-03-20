using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Pokeball
    {
        public bool inBall = true;
        public Pokemon containedPokemon;

        public Pokeball(Pokemon pokemon)
        {
            containedPokemon = pokemon;
        }

        public void Throw()
        {
            if (!inBall)
            {
                Console.WriteLine("The Pokeball is already open!");
            }
            else
            {
                Console.WriteLine("You threw the Pokeball! " + containedPokemon.nickname + " appears!");
                inBall = false;
            }
        }

        public void Return()
        {
            if (!inBall)
            {
                Console.WriteLine(containedPokemon.nickname + " returns to its Pokeball. The lid closes up.");
                inBall = true;
            }
            else
            {
                Console.WriteLine("The Pokeball is already closed.");
            }
        }
    }
}
