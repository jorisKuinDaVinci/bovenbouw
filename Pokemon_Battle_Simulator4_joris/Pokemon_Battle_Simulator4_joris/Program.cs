using System;

namespace Pokemon_Battle_Simulator4_joris
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

                // Create and start the battle in the arena
                Arena arena = new Arena();
                arena.StartBattle(trainer1, trainer2);

                // Show battle results and score
                arena.ShowScore();

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