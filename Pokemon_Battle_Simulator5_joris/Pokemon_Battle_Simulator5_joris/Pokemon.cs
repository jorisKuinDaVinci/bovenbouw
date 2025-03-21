using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public enum PokemonType
    {
        Fire,
        Water,
        Grass
    }

    public abstract class Pokemon
    {
        public string Nickname { get; private set; }
        public PokemonType Strength { get; private set; }
        public PokemonType Weakness { get; private set; }

        public Pokemon(string nickname, PokemonType strength, PokemonType weakness)
        {
            Nickname = nickname;
            Strength = strength;
            Weakness = weakness;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Nickname}: Strength = {Strength}, Weakness = {Weakness}");
        }

        public string BattleCry()
        {
            return $"{Nickname}! {Nickname}!";
        }
    }
}
