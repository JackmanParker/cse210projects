using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your fistname? ");
        string firstname = Console.ReadLine();
        Console.Write("What is your Last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {firstname}");
        Console.WriteLine($"\nYour name is {lastname}, {firstname} {lastname}.");
    }
}