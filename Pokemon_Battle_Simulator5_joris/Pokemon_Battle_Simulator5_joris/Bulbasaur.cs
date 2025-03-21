using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname) : base(nickname, PokemonType.Grass, PokemonType.Fire)
        {
            Console.WriteLine(BattleCry());
        }
    }
}
