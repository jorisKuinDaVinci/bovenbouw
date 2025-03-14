using System;

namespace Pokemon_Battle_Simulator4_joris
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string nickname) : base(nickname, "water", "leaf")
        {
            Console.WriteLine(BattleCry());
        }
    }
}
