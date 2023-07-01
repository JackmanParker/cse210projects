using System;
namespace Develop05
{

    public class CheckListGoal : Goal
    {
        private int _completionCount;
        private int _completionRequirement;
        private int _bounusPointValue;
        

        public CheckListGoal(string name, int pointValue, string description, int bounusPointValue, int completionRequirement): base(name, pointValue, description)
        {
            
            _completionCount = 0;
            _completionRequirement =completionRequirement;
            _bounusPointValue = bounusPointValue;
        }
        public CheckListGoal(string name, int pointValue, string description, bool completionStatus, int bounusPointValue, int completionRequirement, int completionCount): base(name, pointValue, description, completionStatus)
        {
            _completionCount = completionCount;
            _completionRequirement =completionRequirement;
            _bounusPointValue = bounusPointValue;
        }
        public override void MarkComplete()
        {
            _completionCount++;
        }
        public override int AwardPoints()
        {
            this.MarkComplete();
            if (_completionCount == _completionRequirement)
            {
                _completion = true;
                return _bounusPointValue + _pointValue;
            }
            else if (_completionCount < _completionRequirement)
            {
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
            if (_completionCount >= _completionRequirement)
            {
                completionSign = "X";
            }
            
            return($"[{completionSign}], {_name}, ({_description}) -- Curently completed {_completionCount}/{_completionRequirement}");
        }
        public override string SerializeAsString()
        {
            return $"ChecklistGoal,,{_name},,{_pointValue},,{_description},,{_completion},,{_bounusPointValue},,{_completionRequirement},,{_completionCount}";
        }

        
    }
}