using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace Develop05
{
    public class Goals
    {
        private List<Goal> _goalList = new List<Goal>();
        private int _totalPoints = 0;
        public Goal this[int index]
    {
        get { return _goalList[index]; }
        set { _goalList[index] = value; }
    }
        public Goals()
        {
        }
        public void AddPoints(int points)
        {
            _totalPoints += points;
        }
        public void AddGoal(Goal newGoal){
            _goalList.Add(newGoal);
        }
        public string GoalsToString()
        {
            string goalListString = string.Join("\n", _goalList.Select( (x, index)=> $"{index + 1}. {x.ConvertToString()}"));
            return goalListString;
            
        }
        public void SaveGoalsToFile(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine(_totalPoints);
                foreach (Goal goal in _goalList)
                    {
                        outputFile.WriteLine(goal.SerializeAsString());
                    }
            }
        }
        public void GetGoalsFromFile(string fileName)
        {
            
            List<Goal> savedEntries = new List<Goal>();
            
            string[] lines = System.IO.File.ReadAllLines(fileName);
            _totalPoints = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++) // Start the loop from index 1 to skip the first line
            {
                string line = lines[i];
                string[] parts = line.Split(",,");
                string goalType = parts[0];
                if (goalType == "SimpleGoal")
                {
                    SimpleGoal oldGoal = new SimpleGoal(parts[1],int.Parse(parts[2]), parts[3], bool.Parse(parts[4]));
                    this.AddGoal(oldGoal);
                }
                if (goalType == "EternalGoal")
                {
                    EternalGoal oldGoal = new EternalGoal(parts[1],int.Parse(parts[2]), parts[3], bool.Parse(parts[4]));
                    this.AddGoal(oldGoal);
                }
                if (goalType == "ChecklistGoal")
                {
                    CheckListGoal oldGoal = new CheckListGoal(parts[1],int.Parse(parts[2]), parts[3], bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                    this.AddGoal(oldGoal);
                }
            }
            
            
        }
        public int GetPoints()
            {
                return _totalPoints;
            }


    }
}