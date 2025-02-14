using System;

namespace Pokemon_Battle_Simulator2_joris
{
    public class Charmander
    {
        public bool field = false;
        public bool constructor = true;
        public string nickname;
        public string strength = "fire";
        public string weakness = "water";

        public Charmander(string nickname)
        {
            this.nickname = nickname;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Charmander " + nickname + ": Strength = " + strength + ", Weakness = " + weakness);
        }
    }
}