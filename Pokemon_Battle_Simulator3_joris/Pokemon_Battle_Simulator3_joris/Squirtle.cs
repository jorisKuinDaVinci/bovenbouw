using System;

namespace Pokemon_Battle_Simulator3_joris
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string nickname) : base(nickname, "water", "leaf")
        {
            BattleCry();
        }
    }
}