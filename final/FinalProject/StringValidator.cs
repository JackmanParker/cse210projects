using System;
using System.Linq;

namespace FinalProject
{
    class StringValidator : RawValidator
    {
        public StringValidator()
        {
        }
        private string _prepareForValidation(string userInput)
        {
            userInput = userInput.Trim();
            userInput = userInput.ToLower();
            return userInput;
        }
        public bool YesOrNo(string userInput)
        {
            string [] yesOrNo = new string [] {"yes", "no"};
            userInput = this._prepareForValidation(userInput);
           
            if (yesOrNo.Any(c => userInput.Contains(c))) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool LengthCheck (string userInput, int lengthMinimum, int lengthMaximum)
        {
            int lengthOfUserString = userInput.Length;
            if(lengthOfUserString >= lengthMinimum && lengthOfUserString <= lengthMaximum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}
