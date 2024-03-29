using System;
using System.Linq;

namespace FinalProject
{
    class ValidationTestHarnesss
    {
       public ValidationTestHarnesss()
       {

       }
       public void RunValidationTests()
       {    
            Console.WriteLine("Type Number or phrase you would like to validate: ");
            string userInput = Console.ReadLine();
            IntegerValidator testIntegerValidator = new IntegerValidator();
            StringValidator testStringValidator = new StringValidator(); 
            Console.WriteLine("Checking integer Validation");
            Console.WriteLine($"Safe: {testIntegerValidator.CheckIfSafe(userInput)}");
            Console.WriteLine($"Integer: {testIntegerValidator.CheckIfInteger(userInput)}");
            Console.WriteLine($"InRange 1,10: {testIntegerValidator.CheckRange(userInput, 1, 10)}");
            Console.WriteLine("Now Checking String Validation");
            Console.WriteLine($"Safe: {testStringValidator.CheckIfSafe(userInput)}");
            Console.WriteLine($"Is \"yes\" or \"no\": {testStringValidator.YesOrNo(userInput)}");
            Console.WriteLine($"Length is in range of 1, 10: {testStringValidator.LengthCheck(userInput, 1, 10)}");
       }

       public void TestFilters()
        {
            Console.WriteLine("Type string you would like to filter: ");
            string prefitered = Console.ReadLine();
            Console.WriteLine("Sexual Filter");
            SexualFilter sexual = new SexualFilter(prefitered);
            sexual.Filter();
            sexual.displayFilterChanges();
            VulgarityFilter vular = new VulgarityFilter(prefitered);
            vular.Filter();
            vular.displayFilterChanges();
            SlangFilter slang = new SlangFilter(prefitered);
            slang.Filter();
            slang.displayFilterChanges();
            
        }

    }
}
