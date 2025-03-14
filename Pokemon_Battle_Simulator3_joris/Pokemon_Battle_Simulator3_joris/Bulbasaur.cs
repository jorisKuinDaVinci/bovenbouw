using System;

namespace Pokemon_Battle_Simulator3_joris
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname) : base(nickname, "grass", "fire")
        {
            BattleCry();
        }
    }
}