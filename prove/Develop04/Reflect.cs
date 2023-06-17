using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04{

    class  Reflect : Activity{
        private string[] _promptList = {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        private string[] _questionList = {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
        private int _questioncount;
        public Reflect(float time, string activityName) : base(time, activityName) 
        {
            _questioncount = 2;
        }

        private void Displayprompt(){
            //Gets the prompt for the user to see
            Random rnd = new Random();
            var randomIndex = rnd.Next(0, _promptList.Length);
            Console.WriteLine($"Consider the following prompt:\n\n --- {_promptList[randomIndex]}---\n\nWhen you have something in mind, press enter.");
            Console.ReadLine();
        }
        private void DisplayQuestion(){
            //Pulls random guestions every time this is called
            Random rnd = new Random();
            var randomIndex = rnd.Next(0, _questionList.Length);
            Console.Write($"\n> {_questionList[randomIndex]}");
        }
        private void DisplayQuestions(){
            //sets up a loop so questons come up to equal the amount of time the user chose.
            for (int questions = _questioncount; questions >0; questions--)
            {
                this.DisplayQuestion();
                this.Pause();

            }

        }
        private void DisplayReflectCountdown(){
            //is the animation used to make the countdown with aproprate text
            Console.Write("Now ponder on cach of the following questions as they related to this experince. \n\nYou may begin in: ");
            for (int i = 5; i >0; i--)
            {
                
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        public void FullRefelctActivity(){
            //Formats all the parts with the fuctions made in each class. Is the activty displayed
            Console.WriteLine(this.CreateWelcome());
            //Figures out how many questions to generate based on the time given by the user.
            _questioncount = (int)Math.Round(this.GetTime()/5);
            Console.Clear();
            Console.WriteLine("Get ready... \n");
            this.Pause();
            this.Displayprompt();
            this.DisplayReflectCountdown();
            Console.Clear();
            this.DisplayQuestions();
            this.DisplayCompleteMessege();
            this.Pause();
        }
    }
}