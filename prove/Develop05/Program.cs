using System;
namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Goals currentGoals = new Goals();
            UserInput userInput = new UserInput();
            GoalDisplays goalDisplays = new GoalDisplays();

            int userChoice = -1;
            while (userChoice!= 6)
            {

                goalDisplays.DisplayMainMenu();
                userChoice = userInput.GetUserIntiger("");
                
                if (userChoice == 1 )
                {
                    goalDisplays.DisplayGoalMenu();
                    userChoice = userInput.GetUserIntiger("");
                    if(userChoice == 1)
                    {
                        SimpleGoal testSimpleGoal = new SimpleGoal(userInput.GetGoalName(), userInput.GetPointsFromUser(), userInput.GetGoalDescripton());
                        currentGoals.AddGoal(testSimpleGoal);
                    }
                    if(userChoice == 2)
                    {
                        EternalGoal testEternalGoal = new EternalGoal(userInput.GetGoalName(), userInput.GetPointsFromUser(), userInput.GetGoalDescripton());
                        currentGoals.AddGoal(testEternalGoal);
                    }
                    if(userChoice == 3)
                    {
                        CheckListGoal testCheckListGoal = new CheckListGoal (userInput.GetGoalName(), userInput.GetPointsFromUser(), userInput.GetGoalDescripton(), userInput.GetBounusPointsFromUser(), userInput.GetRequirementCount());
                        currentGoals.AddGoal(testCheckListGoal);
                    }
                }
                else if (userChoice == 2)
                {
                    goalDisplays.DisplayCurrentGoals(currentGoals);
                    goalDisplays.DisplayTotalPoints(currentGoals);
                    Console.ReadLine();
                }
                else if (userChoice == 3)
                {
                    currentGoals.SaveGoalsToFile("Goals.txt");
                    goalDisplays.DisplayDone();
                    Console.ReadLine();
                }
                else if (userChoice == 4)
                {
                    currentGoals.GetGoalsFromFile(userInput.GetFileName());
                    goalDisplays.DisplayDone();
                    Console.ReadLine();
                }
                else if (userChoice == 5)
                {
                    goalDisplays.DisplayCurrentGoals(currentGoals);
                    int goalIndex = userInput.GetGoalChoiceToMarkComplete() - 1;
                    int pointsEarned = currentGoals[goalIndex].AwardPoints();
                    currentGoals.AddPoints(pointsEarned);
                    goalDisplays.DisplayEarnedPoints(pointsEarned);
                    goalDisplays.DisplayTotalPoints(currentGoals);
                    
                }
                
            }



            
        }
    }
}
