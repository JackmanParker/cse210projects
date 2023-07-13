using System;
using System.Linq;

namespace FinalProject
{
    class RawValidator
    {
        private string [] _dangrousCharcters = new string [] {"\n", "\\", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "\"", "\'",  "<", ">", ";", ":"};

        public RawValidator()
        {
        }
       

        public bool CheckIfSafe(string userInput)
        {
            //Will look for dangrous charcters if there are some it will let the user know to try again
                 
                if (_dangrousCharcters.Any(c => userInput.Contains(c))) 
                {
                    return false;
                }
                else
                {
                    return true;
                }
            
        }

    }
}
