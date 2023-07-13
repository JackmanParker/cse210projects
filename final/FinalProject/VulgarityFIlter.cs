using System;
using System.Linq;

namespace FinalProject
{
    public class VulgarityFilter : StringFilter
    {
        private List<string> _vulgarWordList = new List<string>()
        {
            "fuck", "shit", "ass", "cunt", "damn", "bitch", "bastard"
        };
        public VulgarityFilter() 
        {

        }
        public VulgarityFilter(string prefiltered) : base(prefiltered)
        {
        }
        public override void Filter()
        {
            foreach (string word in _vulgarWordList)
            {
                _updatedText = _updatedText.Replace($"{word}", "___");
            }
            
        }

    

    }
}
