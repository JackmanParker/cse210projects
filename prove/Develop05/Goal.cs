using System;
namespace Develop05
{
// Abstract Goal

// Responsibility: Track completion, description, and points associated with the goal.

// Att:
// 	Private _description: string
// 	Private _name: string
// 	Private _completion: bool
// 	Private _pointValue: int 


// Meth:
// public Goal()
// public Goal(Name, points, description)
// public abstract AwardPoints()
// public abstract MarkComplete()



    public abstract class Goal 
    {
        protected string _description;
        protected string _name;
        protected bool _completion;
        protected int _pointValue;
        public Goal(string name, int pointValue, string description)
        {
            _name = name;
            _pointValue = pointValue;
            _description = description;
        }
        public Goal(string name, int pointValue, string description, bool completionStatus)
        {
            _name = name;
            _pointValue = pointValue;
            _description = description;
            _completion = completionStatus;
        }   
        private string GetName()
        {
            return _name;
        }
        public virtual void MarkComplete()
        {
            _completion = true;
        }
        public virtual int AwardPoints(){
            if (_completion == false)
            {
                this.MarkComplete();
                return _pointValue;
            }
            else
            {
                return 0;
            }
        }
        public virtual string ConvertToString()
        {
            string completionSign = " ";
            if (_completion == true)
            {
                completionSign = "X";
            }
            
            return($"[{completionSign}], {_name}, ({_description})");
        }
        public abstract string SerializeAsString();
        


    }
}