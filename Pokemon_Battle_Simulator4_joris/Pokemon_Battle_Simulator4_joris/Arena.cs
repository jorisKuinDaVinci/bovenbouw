using System;

namespace Pokemon_Battle_Simulator4_joris
{
    public class Arena
    {
        public static int totalRounds = 0;
        public static int totalBattles = 0;

        public void StartBattle(Trainer trainer1, Trainer trainer2)
        {
            Console.WriteLine("The battle begins!\n");
            Battle battle = new Battle(trainer1, trainer2);
            battle.Start();
        }

        public void ShowScore()
        {
            Console.WriteLine("Total Battles Fought: " + Battle.battlesFought);
            Console.WriteLine("Total Rounds Fought: " + Battle.roundsFought);
        }
    }
}