using System;
using System.Linq;

namespace FinalProject
{
    public abstract class StringFilter
    {
        protected string _orginalText;
        protected string _updatedText;
        public StringFilter()
        {

        }
        public StringFilter(string prefiltered)
        {
            _orginalText = prefiltered;
            _updatedText = prefiltered.ToLower();
        }
        public void GetIntput(string prefiltered)
        {
            _orginalText = prefiltered;
            _updatedText = prefiltered.ToLower();
        }
        public abstract void Filter();
        public void displayFilterChanges()
        {
            Console.WriteLine($"String before Filter: {_orginalText}");
            Console.WriteLine($"String Post Filter: {this.GetFilteredtext()}");
        }
        public string GetFilteredtext()
        {
            if (!string.IsNullOrEmpty(_updatedText))
            {
                return char.ToUpper(_updatedText[0]) + _updatedText.Substring(1);
            }
            else
            {
                return _updatedText;
            }
        }

    

    }
}
