using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Pokeball
    {
        public bool InBall { get; private set; } = true;
        public Pokemon ContainedPokemon { get; private set; }

        public Pokeball(Pokemon pokemon)
        {
            ContainedPokemon = pokemon;
        }

        public void Throw()
        {
            if (!InBall)
            {
                Console.WriteLine("The Pokeball is already open!");
            }
            else
            {
                Console.WriteLine($"You threw the Pokeball! {ContainedPokemon.Nickname} appears!");
                InBall = false;
            }
        }

        public void Return()
        {
            if (!InBall)
            {
                Console.WriteLine($"{ContainedPokemon.Nickname} returns to its Pokeball. The lid closes up.");
                InBall = true;
            }
            else
            {
                Console.WriteLine("The Pokeball is already closed.");
            }
        }
    }
}
