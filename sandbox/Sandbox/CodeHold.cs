using System;
namespace Develop05
{

    public class SimpleGoal : Goal
    {
        private string _description;
        private string _name;
        private bool _completion;
        private int _pointValue;

        public SimpleGoal(string name, int pointValue, string description): base(name, pointValue, description)
        {
            _name = name;
            _pointValue = pointValue;
            _description = description;
        }
        public new void MarkComplete()
        {
            _completion = true;
        }
        public new int AwardPoints(){
            if (_completion == false)
            {
                this.MarkComplete();
                _completion = true;
                return _pointValue;
            }
            else
            {
                return 0;
            }
        }
            public override string ConvertToString()
        {
            string completionSign = " ";
            if (_completion == true)
            {
                completionSign = "X";
            }
            
            return($"[{completionSign}], {_name}, ({_description})");
        }

        // SimpleGoal testSimpleGoal = new SimpleGoal("jump", 2, "Get more than 1 foot off the air");
            // SimpleGoal tesSimpleGoal = new SimpleGoal("jump", 2, "Get more than 1 foot off the air");
            // EternalGoal testEternalGoal = new EternalGoal("Read", 1, "Read 1 Ch of Scripture today");
            // CheckListGoal testCheckListGoal = new CheckListGoal ("Go to temple", 1, "Go to the temple for endowment", 10, 3, 0);
            // EternalGoal test2EternalGoal = new EternalGoal("Read", 1, "Read 1 Ch of Scripture today");
            // currentGoals.AddGoal(testSimpleGoal);
            // currentGoals.AddGoal(tesSimpleGoal);
            // currentGoals.AddGoal(testEternalGoal);
            // currentGoals.AddGoal(testCheckListGoal);
            // Console.WriteLine(currentGoals.GoalsToString());
            // Console.WriteLine(tesSimpleGoal.AwardPoints());
            // Console.WriteLine(testEternalGoal.AwardPoints());
            // Console.WriteLine(testEternalGoal.AwardPoints()); 
            // Console.WriteLine(testCheckListGoal.AwardPoints());
            // Console.WriteLine(currentGoals.GoalsToString());
            // Console.WriteLine(testCheckListGoal.AwardPoints());
            // Console.WriteLine(testCheckListGoal.AwardPoints()); 
            // Console.WriteLine(testCheckListGoal.AwardPoints());
            // Console.WriteLine(tesSimpleGoal.SerializeAsString());                     
            // Console.WriteLine(testCheckListGoal.SerializeAsString());
            // Console.WriteLine(testEternalGoal.SerializeAsString());
            // Console.WriteLine(testSimpleGoal.SerializeAsString());
            // Console.WriteLine(currentGoals.GoalsToString());
            // currentGoals.GetGoalsFromFile("Goals.txt");
            // currentGoals.AddPoints(currentGoals[0].AwardPoints());

            // currentGoals.SaveGoalsToFile("Goals.txt");
            // Console.WriteLine(currentGoals.GoalsToString());
        
        
    }
}