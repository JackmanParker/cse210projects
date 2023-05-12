using System;
using System.Collections.Generic;

namespace Develop02{
//
// The Responibiligy  is to contain prompts

    public class Prompt{
        public string[] _prompts = {"Who was the most interesting person I interacted with today?","What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What was the most surprsing thing that happened today?", "What was the best thing you ate today?"};
        
        

        public Prompt()
        {
         
        }
        public string GetPrompt()
        {
            Random rnd = new Random();
            var randomIndex = rnd.Next(0, _prompts.Length);
            return(_prompts[randomIndex]);
        }


    }
}