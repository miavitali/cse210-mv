using System;

// Added a leveling system to enhance player engagement.
// - Players level up for every 100 points earned.
// - The current level is displayed alongside the score.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}