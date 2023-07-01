using System;
namespace Develop05
{

    public class SimpleGoal : Goal
    {

        public SimpleGoal(string name, int pointValue, string description): base(name, pointValue, description)
        {
            
        }
        public SimpleGoal(string name, int pointValue, string description, bool completionStatus): base(name, pointValue, description, completionStatus)
        {
            
        }

        public override string SerializeAsString()
        {
            return $"SimpleGoal,,{_name},,{_pointValue},,{_description},,{_completion}";
        }
        
        
        
    }
}