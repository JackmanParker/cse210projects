using System;
namespace Develop04{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = -1;
            while (userChoice != 4){
                Console.Clear();
                Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
                //Check to make sure the user inputs an int
                while(!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.WriteLine("That was invalid. Enter a valid option.");
                }

                
                //creates and runs an instance of each activity based on the answer the user selects.
                if (userChoice == 1){
                    Console.Clear();
                    Breathing testBreath = new Breathing(10 ,"Breathing");
                    testBreath.FullBreathingActivity();
                    Console.Clear();
                }
                if (userChoice == 2){
                    Console.Clear();
                    Reflect reflectingActivity = new Reflect(10 ,"Reflecting");
                    reflectingActivity.FullRefelctActivity();
                    Console.Clear();
                }
                if (userChoice == 3){
                    Console.Clear();
                    Listing listingActivity = new Listing(10 ,"Listing");
                    listingActivity.FullListingActivity();
                    Console.Clear();
                }

            }

            // Console.Clear();
            // Console.WriteLine(test.CreateWelcome());
            // test.DisplayCompleteMessege();


            // Console.Clear();
            // Breathing testBreath = new Breathing(10 ,"Breathing");
            // testBreath.FullBreathingActivity();

            // Reflect testreflect = new Reflect(10, "Reflecting");
            // testreflect.FullRefelctActivity();

            // Listing testlist = new Listing(10, "Listing");
            // testlist.FullListingActivity();
            
           
            
        }
    }
}
