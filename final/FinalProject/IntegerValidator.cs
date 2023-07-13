using System;
using System.Linq;

namespace FinalProject
{
    class IntegerValidator : RawValidator
    {
        public IntegerValidator()
        {

        }
        public bool CheckIfInteger(string userInput)
        {
            return int.TryParse(userInput, out _);
        }
        public bool CheckIfPossitve(string userInput)
        {
            if(this.CheckIfInteger(userInput))
            {
                int userInteger = int.Parse(userInput);
                if ((userInteger) > 0)
                    {
                        return true;
                    }
                else
                    {
                        return false;
                    }
            }
            else
            {
                return false;
            }
        }
        public bool CheckRange(string userInput, int minimum, int maximum)
        {
            
            if(this.CheckIfInteger(userInput))
            {
                int userInteger = int.Parse(userInput);
                if ((userInteger) >= minimum && (userInteger) <= maximum)
                    {
                        return true;
                    }
                else
                    {
                        return false;
                    }
            }
            else
            {
                return false;
            }
  
        }

    }
}
