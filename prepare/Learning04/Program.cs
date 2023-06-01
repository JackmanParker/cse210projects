using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        MathAssignment testMath = new MathAssignment();
        Console.WriteLine($"{testMath.GetSummary()} \n{testMath.GetHomework()}\n");
        

        WritingAssignment testWrite = new WritingAssignment("John", "programming", "Privte Classes");
        Console.WriteLine($"{testWrite.GetSummary()} \n{testWrite.GetWritingInformation()}");
        
    }
}