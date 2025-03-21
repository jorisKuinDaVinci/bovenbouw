using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Pokeball
    {
        private bool _inBall = true;
        public Pokemon ContainedPokemon { get; }

        public Pokeball(Pokemon pokemon)
        {
            ContainedPokemon = pokemon ?? throw new ArgumentNullException(nameof(pokemon));
        }

        public void Throw()
        {
            if (!_inBall)
            {
                Console.WriteLine("The Pokeball is already open!");
            }
            else
            {
                Console.WriteLine($"You threw the Pokeball! {ContainedPokemon.Nickname} appears!");
                _inBall = false;
            }
        }

        public void Return()
        {
            if (!_inBall)
            {
                Console.WriteLine($"{ContainedPokemon.Nickname} returns to its Pokeball. The lid closes up.");
                _inBall = true;
            }
            else
            {
                Console.WriteLine("The Pokeball is already closed.");
            }
        }
    }

}
