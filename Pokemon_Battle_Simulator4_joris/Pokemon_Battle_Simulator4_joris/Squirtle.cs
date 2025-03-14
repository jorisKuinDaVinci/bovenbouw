using System;

namespace Pokemon_Battle_Simulator4_joris
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string nickname) : base(nickname, "water", "leaf") { }

        // Overriding the BattleCry method
        public override string BattleCry()
        {
            return nickname + "! Squirtle!";
        }
    }
}
