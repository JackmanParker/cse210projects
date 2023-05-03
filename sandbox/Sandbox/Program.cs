using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgen = new Random();
        int rannum = randomgen.Next(1,101);
        
        Console.WriteLine(rannum);
        
    }
}
//cd
// vertion control is what allows us to go back to old vertions git
//git push
// dotnet build makes the exe
// dotnet run runs the program
// 
// When planning for clsasses go 
// Class name
// Responsiblility
// Methods needed
// attributes
// 