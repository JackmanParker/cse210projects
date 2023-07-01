using System;
namespace Develop05
{
    public class UserInput
    {
       
        public int GetUserIntiger(string question)
        {
            int userIntiger = -1;
            Console.WriteLine(question);
            while(!int.TryParse(Console.ReadLine(), out userIntiger))
                {
                    Console.WriteLine("That was invalid. Enter a valid option.");
                }

            return userIntiger;
        }
        public int GetPointsFromUser()
        {
            string pointQuestion = "How many points is this Goal worth?";
            return this.GetUserIntiger(pointQuestion);
        }
        public int GetBounusPointsFromUser()
        {
            string pointQuestion = "How many bonus points is this Goal worth when you complete it?";
            return this.GetUserIntiger(pointQuestion);
        }
        public int GetRequirementCount()
        {
            string pointQuestion = "How many times do you wish to complete this goal?";
            return this.GetUserIntiger(pointQuestion);
        }
        public int GetGoalChoiceToMarkComplete()
        {
            string pointQuestion = "Which goal do you want to mark completed?";
            return this.GetUserIntiger(pointQuestion);
        }
        public string GetString(string Question)
        {
            
            Console.WriteLine(Question);
            string userString = Console.ReadLine();
            return userString;
        }
        public string GetGoalName()
        {
            
            string GoalNameQuestion = "What is the name of your Goal";
            
            return this.GetString(GoalNameQuestion);
        }
        public string GetGoalDescripton()
        {
            
            string GoalQuestion = "What is a description of your Goal?";
            
            return this.GetString(GoalQuestion);
        }
        public string GetFileName()
        {
            
            string GoalNameQuestion = "What is the name of your File? (Don't for get the extention)";
            
            return this.GetString(GoalNameQuestion);
        }
    }
}