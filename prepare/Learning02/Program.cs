using System;
using System.Collections;
using System.Collections.Generic;
namespace Learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Job job1 = new Job();
            job1._jobTitle = "Software Engineer";
            job1._companyName ="Apple";
            job1._startYear = 2005;
            job1._endYear = 2022;
            
            Job job2 = new Job();
            job2._jobTitle = "Milk man";
            job2._companyName = "TheDairy";
            job2._startYear = 1990;
            job2._endYear = 2005;
            
            Resume resume1 = new Resume();
            resume1._name = "Parker Jackman";
            resume1._jobs.Add(job1);
            resume1._jobs.Add(job2);
            resume1.Display();

        }

    }
    
}
// Namespaces: We can not name two variables with the same name in the same scope. It will create a collicion and bad. 
// namespace keyword spesfies if fa block of code is in a global or named namespace. 
// code will never be ru if it does not work its way into the main function
//  try dotnet new console, play around see what you can do. 
