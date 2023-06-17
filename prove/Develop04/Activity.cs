using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04{



    public class Activity 
    {
        private float _time;
        private string _activityName;


        public Activity(float time, string activityName)
        {
            
            _time = time;
            _activityName = activityName;
            

        }
        public string CreateWelcome(){
            if (_activityName == "Breathing")
                {
                    return $"Welcome to the {_activityName} Activity \n\nIn this activity you will relax by breathing in and out slowly. Clear your mind and focus on your breathing.\n";
                }
            else if (_activityName == "Listing")
            {
                return  $"Welcome to the {_activityName} Activity \n\nIn this activity you will relax by Listing good things in your life.\n";
            }
            else
            {
                return $"Welcome to the {_activityName} Activity \n\nIn this activity you will relax by Reflecting on an experince from your life.\n";
            }
        }
        public float GetTime()
        {
            Console.WriteLine("How long in seconds would you like to do this activity? ");
            _time = int.Parse(Console.ReadLine());
            while (_time < 10){
                Console.WriteLine("The minimum amount of time you can do is 10 seconds.");
                Console.WriteLine("How long in seconds would you like to do this activity? ");
                _time = int.Parse(Console.ReadLine());

            }
            
            return _time;
        }
        public void Pause(){
            // Create the pause animation list
            List<string> pauseAnimation = new List<string>();
            // adding to the List 
            pauseAnimation.Add("|");
            pauseAnimation.Add("/");
            pauseAnimation.Add("-");
            pauseAnimation.Add("\\");
            pauseAnimation.Add("|");
            

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(5);

            // prep the loop that will run throuth the index
            int animationIndex = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write(pauseAnimation[animationIndex]);
                Thread.Sleep(500);
                Console.Write("\b \b");

                animationIndex++;
                if (animationIndex >= 5)
                {
                    animationIndex = 0;
                }
            }
        }

        public void DisplayCompleteMessege(){
            Console.WriteLine("\n\nWell Done!!\n");
            this.Pause();
            Console.WriteLine($"You have completed {_time} seconds of the {_activityName} activity.");
        }

    }


    


}