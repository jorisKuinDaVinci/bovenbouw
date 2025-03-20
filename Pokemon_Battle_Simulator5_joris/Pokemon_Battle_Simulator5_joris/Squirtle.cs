using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string nickname) : base(nickname, "water", "leaf")
        {
            Console.WriteLine(BattleCry());
        }
    }
}
