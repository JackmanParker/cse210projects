using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, what grade percentage did you get in your Class: ");
        string letter = "";
        int score = int.Parse(Console.ReadLine());
        if (score > 90)
        {
            letter = "A";
        }
        else if (score > 80)
        {
            letter = "B";
        }
         else if (score > 70)
        {
            letter = "C";
        }
         else if (score > 60)
        {
            letter = "D";
        }
         else 
        {
            letter = "F";
        }
        Console.WriteLine($"You received a {letter}.");
        if (score > 70)
        {
            Console.WriteLine("You passed Congrats!!");
        }
        else
        {
            Console.WriteLine("You failed, but next time you will pass.");
        }

    }
}