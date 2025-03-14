using System;

namespace Pokemon_Battle_Simulator4_joris
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname) : base(nickname, "grass", "fire") { }

        // Overriding the BattleCry method
        public override string BattleCry()
        {
            return nickname + "! Bulbasaur!";
        }
    }
}
