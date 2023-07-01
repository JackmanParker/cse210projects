using System;
namespace Develop05
{

    public class EternalGoal : Goal
    {

        public EternalGoal(string name, int pointValue, string description): base(name, pointValue, description)
        {
        }
        public EternalGoal(string name, int pointValue, string description, bool completionStatus): base(name, pointValue, description, completionStatus)
        {   
        }
        public override void MarkComplete()
        {
            _completion = false;
        }
        public override string SerializeAsString()
        {
            return $"EternalGoal,,{_name},,{_pointValue},,{_description},,{_completion}";
        }
    }
}