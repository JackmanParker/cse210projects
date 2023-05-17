using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstFraction = new Fraction();
        Fraction secondFraction = new Fraction(5);
        Fraction thirdFraction = new Fraction(4,6);
        Console.WriteLine(firstFraction.GetFractionString());
        Console.WriteLine(firstFraction.GetDecimalValue());
        Console.WriteLine(secondFraction.GetFractionString());
        Console.WriteLine(secondFraction.GetDecimalValue());
        Console.WriteLine(thirdFraction.GetFractionString());
        Console.WriteLine(thirdFraction.GetDecimalValue());

        firstFraction.SetBotInt(5);
        int bottom = firstFraction.GetBotInt();
        
        
        Console.WriteLine($"Test to see if set and get work {bottom}");
    }
}

//Keep you code as loose. minimize touch points between classes. 
