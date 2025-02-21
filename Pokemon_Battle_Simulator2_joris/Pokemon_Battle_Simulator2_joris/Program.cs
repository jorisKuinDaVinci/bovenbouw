using System;

namespace Pokemon_Battle_Simulator2_joris
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;

            while (playing)
            {
                Console.Clear();
                Console.WriteLine("=== Pokémon Battle Simulator ===\n");

                Console.Write("Enter the first trainer's name: ");
                string trainerName1 = Console.ReadLine();
                Trainer trainer1 = new Trainer(trainerName1);

                Console.Write("Enter the second trainer's name: ");
                string trainerName2 = Console.ReadLine();
                Trainer trainer2 = new Trainer(trainerName2);

                Console.WriteLine("\n--- The battle begins! ---\n");

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("Round " + (i + 1) + ":");

                    trainer1.ThrowPokeball(i);
                    trainer2.ThrowPokeball(i);

                    trainer1.ReturnPokemon(i);
                    trainer2.ReturnPokemon(i);

                    Console.WriteLine("\nPress Enter to continue to the next round...");
                    Console.ReadLine();
                }

                Console.WriteLine("\n--- All Pokémon have battled! ---");

                Console.WriteLine("\nWould you like to play again? (y/n)");
                string choice = Console.ReadLine().ToLower();

                if (choice != "y")
                {
                    playing = false;
                }
            }

            Console.WriteLine("\nThank you for playing the Pokémon Battle Simulator! Goodbye!");
        }
    }
}