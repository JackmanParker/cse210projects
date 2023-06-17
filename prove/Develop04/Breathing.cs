using System;
using System.Collections.Generic;
using System.Threading;
namespace Develop04{

    class Breathing : Activity{
        private int _breathCount;
        public Breathing(float time, string activityName) : base(time, activityName) 
        {
            _breathCount = 2;
        }

        private void BreatheIn(){
            Console.Write("Breathe in...");
            for (int i = 5; i >0; i--)
            {
                
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        private void BreatheOut(){
            Console.Write("Breathe out...");
            for (int i = 5; i >0; i--)
            {
                
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        private void FullBreath(){
            // will do a breathe in and out
            for (int breathes = _breathCount; breathes >0; breathes--)
            {
                Console.WriteLine("\n");
                this.BreatheIn();
                Console.WriteLine();
                this.BreatheOut();
            }

        }
        
        public void FullBreathingActivity(){
            //Runs and fromats the whole breathing activity based on the spesfications. 
            Console.WriteLine(this.CreateWelcome());
            //Get the amount of time the user wants to and convert that into loop counts
            _breathCount = (int)Math.Round(this.GetTime()/10);
            // formatting
            Console.Clear();
            Console.WriteLine("Get ready...");
            this.Pause();
            //start the breathing loop
            this.FullBreath();
            //finsih activity
            this.DisplayCompleteMessege();
            this.Pause();


        }


    }
}