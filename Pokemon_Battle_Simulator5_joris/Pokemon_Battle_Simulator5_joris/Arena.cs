using System;

namespace Pokemon_Battle_Simulator5_joris
{
    public class Arena
    {
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
