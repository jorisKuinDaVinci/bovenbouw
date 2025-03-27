using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Pokeball
    {
        private bool _inBall = true;
        private Pokemon containedPokemon;

        public Pokeball(Pokemon pokemon)
        {
            containedPokemon = pokemon;
        }

        public Pokemon ContainedPokemon()
        {
            return containedPokemon;
        }

        public void Throw()
        {
            if (!_inBall)
            {
                Console.WriteLine("The Pokeball is already open!");
            }
            else
            {
                Console.WriteLine($"You threw the Pokeball! {ContainedPokemon().GetNickname()} appears!");
                _inBall = false;
            }
        }

        public void Return()
        {
            if (!_inBall)
            {
                Console.WriteLine($"{ContainedPokemon().GetNickname()} returns to its Pokeball. The lid closes up.");
                _inBall = true;
            }
            else
            {
                Console.WriteLine("The Pokeball is already closed.");
            }
        }
    }
}
