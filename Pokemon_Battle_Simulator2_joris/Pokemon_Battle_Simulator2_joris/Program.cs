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
    public class Pokeball
    {
        public bool inBall = true;
        public Charmander containedPokemon;

        public Pokeball(Charmander pokemon)
        {
            containedPokemon = pokemon;
        }

        public void Throw()
        {
            if (!inBall)
            {
                Console.WriteLine("The pokeball is already open!");
            }
            else
            {
                Console.WriteLine("You threw the pokeball! A " + containedPokemon.GetType().Name + " appears!");
                inBall = false;
            }
        }

        public void Return()
        {
            if (!inBall)
            {
                Console.WriteLine("The Charmander returns to its Pokéball. The lid closes up.");
                inBall = true;
            }
            else
            {
                Console.WriteLine("The Pokéball is already closed.");
            }
        }
    }
}