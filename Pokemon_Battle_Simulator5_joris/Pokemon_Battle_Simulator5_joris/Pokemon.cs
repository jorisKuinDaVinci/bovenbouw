using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public abstract class Pokemon
    {
        public string nickname;
        public string strength;
        public string weakness;

        public Pokemon(string nickname, string strength, string weakness)
        {
            this.nickname = nickname;
            this.strength = strength;
            this.weakness = weakness;
        }

        public void ShowInfo()
        {
            Console.WriteLine(nickname + ": Strength = " + strength + ", Weakness = " + weakness);
        }

        public string BattleCry()
        {
            return nickname + "! " + nickname + "!";
        }
    }
}
