using System;

class Program
{
    static void Hello(){
        Console.WriteLine("Welcome to the program");
    }
    static int getnum(){
        Console.Write("What is your fav number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static string getname(){
        Console.Write("What is your  name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int square(int numb){
        int square = numb * numb;
        return square;
    }
    static void display(int square, string name){
        Console.WriteLine($"{name}, The square of your number is {square}");
    }
    static void Main(string[] args)
    {
        Hello();
        string name = getname();
        int num = getnum();
        int squar = square(num);
        display(squar, name);

        
    }
}