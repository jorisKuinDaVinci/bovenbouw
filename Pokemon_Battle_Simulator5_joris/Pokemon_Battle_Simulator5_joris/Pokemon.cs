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
        private string Nickname;
        private PokemonType Strength;
        private PokemonType Weakness;

        protected Pokemon(string nickname, PokemonType strength, PokemonType weakness)
        {
            Nickname = nickname;
            Strength = strength;
            Weakness = weakness;
        }

        // Getter methods
        public string GetNickname()
        {
            return this.Nickname;
        }

        public PokemonType GetStrength()
        {
            return this.Strength;
        }

        public PokemonType GetWeakness()
        {
            return this.Weakness;
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
