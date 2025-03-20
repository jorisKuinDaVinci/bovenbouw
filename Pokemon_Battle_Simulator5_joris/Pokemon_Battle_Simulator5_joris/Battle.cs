using System;
using System.Collections.Generic;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Battle
    {
        public Trainer trainer1;
        public Trainer trainer2;
        public static int roundsFought = 0;
        public static int battlesFought = 0;

        public Battle(Trainer trainer1, Trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
        }

        public void Start()
        {
            battlesFought++;
            Pokemon pokemon1 = null;
            Pokemon pokemon2 = null;

            while (true)
            {
                if (trainer1.belt.Count == 0)
                {
                    break;  // Trainer 1 heeft geen Pokémon meer, stop de battle
                }

                if (trainer2.belt.Count == 0)
                {
                    break;  // Trainer 2 heeft geen Pokémon meer, stop de battle
                }

                roundsFought++;
                Console.WriteLine("Round " + roundsFought + ":");

                // Trainer 1 throws a random Pokeball
                int index1 = new Random().Next(0, trainer1.belt.Count);
                trainer1.ThrowPokeball(index1);
                pokemon1 = trainer1.belt[index1].containedPokemon;

                // Trainer 2 throws a random Pokeball
                int index2 = new Random().Next(0, trainer2.belt.Count);
                trainer2.ThrowPokeball(index2);
                pokemon2 = trainer2.belt[index2].containedPokemon;

                if (pokemon1.strength == "fire")
                {
                    if (pokemon2.strength == "grass")
                    {
                        Console.WriteLine("Pokemon1 wins the round!");
                        trainer2.ReturnPokemon(index2);
                    }
                    else
                    {
                        Console.WriteLine("Pokemon2 wins the round!");
                        trainer1.ReturnPokemon(index1);
                    }
                }
                else if (pokemon1.strength == "grass")
                {
                    if (pokemon2.strength == "water")
                    {
                        Console.WriteLine("Pokemon1 wins the round!");
                        trainer2.ReturnPokemon(index2);
                    }
                    else
                    {
                        Console.WriteLine("Pokemon2 wins the round!");
                        trainer1.ReturnPokemon(index1);
                    }
                }
                else if (pokemon1.strength == "water")
                {
                    if (pokemon2.strength == "fire")
                    {
                        Console.WriteLine("Pokemon1 wins the round!");
                        trainer2.ReturnPokemon(index2);
                    }
                    else
                    {
                        Console.WriteLine("Pokemon2 wins the round!");
                        trainer1.ReturnPokemon(index1);
                    }
                }

                // Return both pokemon if there is a draw or if both are returned after battle
                if (pokemon1.strength == pokemon2.strength)
                {
                    Console.WriteLine("It's a draw!");
                    trainer1.ReturnPokemon(index1);
                    trainer2.ReturnPokemon(index2);
                }

                Console.WriteLine("\nPress Enter to continue to the next round...");
                Console.ReadLine();
            }

            if (trainer1.belt.Count == 0)
            {
                Console.WriteLine(trainer2.name + " wins the battle!");
            }
            else if (trainer2.belt.Count == 0)
            {
                Console.WriteLine(trainer1.name + " wins the battle!");
            }
            else
            {
                Console.WriteLine("The battle ended in a draw!");
            }
        }
    }
}
