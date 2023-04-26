using System;
class Program
{
    static void Main(string[] args)
    {
        Random randomgen = new Random();
        int guess = (-1);
        
        //creating the variable for the magic number and reading
        int magnum = randomgen.Next(1,101);
       
       while (guess != magnum){
            //Get user input for a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if(magnum == guess){
                Console.WriteLine("Your guess is correct!");
            }
            else if (magnum > guess){
                Console.WriteLine($"Your guess of {guess} is too low.");
            }
            else{
                Console.WriteLine($"Your guess of {guess} is too high.");
            }
    }
    }
}