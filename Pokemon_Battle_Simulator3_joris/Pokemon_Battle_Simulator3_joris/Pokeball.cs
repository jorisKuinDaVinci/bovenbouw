using System;

namespace Pokemon_Battle_Simulator3_joris
{
    public class Pokeball
    {
        public bool inBall = true;
        public Charmander containedPokemon;

        public Pokeball(Charmander pokemon)
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
                Console.WriteLine("You threw the Pokeball! A " + containedPokemon.nickname + " appears!");
                Console.WriteLine(containedPokemon.BattleCry()); //Charmander battle cry
                inBall = false;
            }
        }

        public void Return()
        {
            if (!inBall)
            {
                Console.WriteLine("The " + containedPokemon.nickname + " returns to its Pokeball. The lid closes up.");
                inBall = true;
            }
            else
            {
                Console.WriteLine("The Pokeball is already closed.");
            }
        }
    }
}