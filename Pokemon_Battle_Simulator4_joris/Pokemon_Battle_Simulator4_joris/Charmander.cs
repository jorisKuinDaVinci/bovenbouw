﻿using System;

namespace Pokemon_Battle_Simulator4_joris
{
    public class Charmander : Pokemon
    {
        public Charmander(string nickname) : base(nickname, "fire", "water")
        {
            Console.WriteLine(BattleCry());
        }
    }
}
