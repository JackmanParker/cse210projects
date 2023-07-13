using System;
namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationTestHarnesss testHarnesss = new ValidationTestHarnesss();
            int userChoice = -1;
            while (userChoice != 4)
            {
                Console.Clear();
                Console.Write("Menu Options:\n  1. Test user input \n  2. Test filters\n  3. Both\n  4. Quit\nSelect a choice from the menu: ");
                //Check to make sure the user inputs an int
                while(!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    Console.WriteLine("That was invalid. Enter a valid option.");
                }
                if (userChoice == 1)
                {
                    
                    testHarnesss.RunValidationTests();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                if (userChoice == 2)
                {
                    testHarnesss.TestFilters();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
            }
        }
    }
}
