using System;

namespace Pokemon_Battle_Simulator4_joris
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname) : base(nickname, "grass", "fire")
        {
            Console.WriteLine(BattleCry());
        }
    }
}