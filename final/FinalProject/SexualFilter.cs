using System;
using System.Linq;

namespace FinalProject
{
    public class SexualFilter : StringFilter
    {
        private List<string> _sexualWordList = new List<string>()
        {
            "sex", "cock", "deepthroat", "dick", "cumshot", "fuck", "sperm", "jerk off", "ass", "fingering", "masturbate", "bitch", "blowjob", "prostitute", "dickhead", "pussy", "boobs","dildo", "erection", "foreskin", "handjob", "penis", "porn", "viagra", "vagina", "vulva", "wet dream", "threesome", "orgy", "bdsm", "hickey", "condom", "sexting", "testicles", "anal", "bareback", "bukkake", "stripper", "strap-on", "clitoris", "cock ring", "doggy style", "fleshlight", "contraceptive", "makeup sex", "lingerie", "butt plug", "milf", "wank", "oral sex", "sucking","dirty talk","orgasm","scissoring", "slut", "cumming", "men\'s milk","prick", "cunt", "bastard", "faggot", "anal", "anus"
        };
        public SexualFilter() 
        {

        }
        public SexualFilter(string prefiltered) : base(prefiltered)
        {
        }
        public override void Filter()
        {
            foreach (string word in _sexualWordList)
            {
                _updatedText = _updatedText.Replace($"{word}", "___");
            }
            
        }

    

    }
}
