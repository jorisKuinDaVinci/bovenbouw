using System;
using System.Collections.Generic;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Battle
    {
        public Trainer Trainer1 { get; private set; }
        public Trainer Trainer2 { get; private set; }
        public static int RoundsFought { get; private set; }
        public static int BattlesFought { get; private set; }

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            Trainer1 = trainer1;
            Trainer2 = trainer2;
        }

        public void Start()
        {
            BattlesFought++;
            Pokemon pokemon1 = null;
            Pokemon pokemon2 = null;

            while (true)
            {
                if (Trainer1.BeltCount == 0 || Trainer2.BeltCount == 0)
                {
                    break;  // One trainer has no Pokémon left, end the battle
                }

                RoundsFought++;
                Console.WriteLine($"Round {RoundsFought}:");

                // Trainer 1 throws a random Pokeball
                int index1 = new Random().Next(0, Trainer1.BeltCount);
                Trainer1.ThrowPokeball(index1);
                pokemon1 = Trainer1.belt[index1].ContainedPokemon;

                // Trainer 2 throws a random Pokeball
                int index2 = new Random().Next(0, Trainer2.BeltCount);
                Trainer2.ThrowPokeball(index2);
                pokemon2 = Trainer2.belt[index2].ContainedPokemon;

                // Determine winner based on type advantage
                if (pokemon1.Strength == PokemonType.Fire && pokemon2.Strength == PokemonType.Grass ||
                    pokemon1.Strength == PokemonType.Water && pokemon2.Strength == PokemonType.Fire ||
                    pokemon1.Strength == PokemonType.Grass && pokemon2.Strength == PokemonType.Water)
                {
                    Console.WriteLine($"{pokemon1.Nickname} wins the round!");
                    Trainer2.ReturnPokemon(index2);
                }
                else if (pokemon1.Strength == pokemon2.Strength)
                {
                    Console.WriteLine("It's a draw!");
                    Trainer1.ReturnPokemon(index1);
                    Trainer2.ReturnPokemon(index2);
                }
                else
                {
                    Console.WriteLine($"{pokemon2.Nickname} wins the round!");
                    Trainer1.ReturnPokemon(index1);
                }

                Console.WriteLine("\nPress Enter to continue to the next round...");
                Console.ReadLine();
            }

            if (Trainer1.BeltCount == 0)
            {
                Console.WriteLine($"{Trainer2.Name} wins the battle!");
            }
            else if (Trainer2.BeltCount == 0)
            {
                Console.WriteLine($"{Trainer1.Name} wins the battle!");
            }
            else
            {
                Console.WriteLine("The battle ended in a draw!");
            }
        }
    }
}
