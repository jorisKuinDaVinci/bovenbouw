using System;

namespace Pokemon_Battle_Simulator3_joris
{
    public class Charmander : Pokemon
    {
        public Charmander(string nickname) : base(nickname, "fire", "water")
        {
            BattleCry();
        }
    }
}