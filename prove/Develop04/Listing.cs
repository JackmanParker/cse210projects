using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04{

    class  Listing : Activity{
        private string[] _promptList = {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        private List<string> _answerList = new List<string>();

        private int _answerTime;
        public Listing(float time, string activityName) : base(time, activityName) 
        {
            
        }

        private void Displayprompt(){
            //Pulls a prompt from the list and displays it
            Random rnd = new Random();
            var randomIndex = rnd.Next(0, _promptList.Length);
            Console.WriteLine($"List as many responses you can to the following prompt:\n\n --- {_promptList[randomIndex]}---");
            
        }
        private void ReciveAnswers(){
            //Starts a timer for the answers based on the time the user chose
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_answerTime);

            // prep the loop that will run through time and will let the user finsh the last answer.
            Console.WriteLine("");
            while (DateTime.Now < endTime){
                Console.Write(">");
                string response = Console.ReadLine();
                _answerList.Add(response);
            }
            Console.WriteLine($"You listed {_answerList.Count} items!");
        }
        
        private void DisplayListingCountdown(){
            //Countdown and words for said countdown
            Console.Write("\n\nYou may begin in: ");
            for (int i = 5; i >0; i--)
            {
                
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        public void FullListingActivity(){
            //formats the activity as a whole.
            Console.WriteLine(this.CreateWelcome());
            
            _answerTime = (int)Math.Round(this.GetTime());
            Console.Clear();
            Console.WriteLine("Get ready... \n");
            this.Pause();
            this.Displayprompt();
            this.DisplayListingCountdown();
            this.ReciveAnswers();
            this.DisplayCompleteMessege();
            this.Pause();
        }
    }
}