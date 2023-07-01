using System;
namespace Develop05
{
    public class GoalDisplays
    {
       public void DisplayCurrentGoals(Goals goals)
       {
        Console.Clear();
        Console.WriteLine(goals.GoalsToString());
       }
       public void DisplayMainMenu()
       {
        Console.Clear();
        Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. SaveGoals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
       }
       public void DisplayGoalMenu()
       {
        Console.Clear();
        Console.WriteLine("What Kind of Goal do you want to make?\n  1. Simple\n  2. Eternal\n  3. Checklist");
       }
       public void DisplayTotalPoints(Goals goals)
       {
        Console.WriteLine($"\nYou have {goals.GetPoints()}!");
       }
       public void DisplayDone(){
        Console.WriteLine("\nDone\n");
       }
       public void DisplayEarnedPoints(int earnedPoints){
        Console.WriteLine($"You just earned {earnedPoints}!!");
       }
        
    }
}