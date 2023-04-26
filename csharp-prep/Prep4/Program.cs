using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int usernum = (-1);
        int sum = 0;
        int avg = 0;
        int max = 0;
        Console.WriteLine("Enter a list of numbers. Type 0 when finished. ");
        while (usernum != 0){
            Console.Write("Enter number: ");
            usernum = int.Parse(Console.ReadLine());
            if (usernum != 0){
                numbers.Add(usernum);}
        }
        foreach(int num in numbers){
            sum += num;
            if (num > max){
                max = num;
            }
        }
        avg = sum / numbers.Count;
        Console.WriteLine($"Your sum is: {sum}");
        Console.WriteLine($"Your avg is: {avg}");
        Console.WriteLine($"Your largest value is: {max}");
    }
}