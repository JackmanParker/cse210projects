using System;
using System.Linq;


class Sample
{
    public static void Main()
    {
        string teststring = "abcd";
        new[] { "a", "b", "c" }.Any(c => teststring.Contains(c));
        string [] safeCharcters = new string [] {"F", "t", "e"};
        Console.WriteLine(safeCharcters.Any(c => teststring.Contains(c)));
        Console.WriteLine(teststring.Contains("a"));
        
    }
//     {
//     string m1 = "\nType a string of text then press Enter. " +
//                 "Type '+' anywhere in the text to quit:\n";
//     string m2 = "Character '{0}' is hexadecimal 0x{1:x4}.";
//     string m3 = "Character     is hexadecimal 0x{0:x4}.";
//     char ch;
//     int x;
// //
//     Console.WriteLine(m1);
//     do
//         {
//         x = Console.Read();
//         try
//             {
//             ch = Convert.ToChar(x);
//             if (Char.IsWhiteSpace(ch))
//                {
//                Console.WriteLine(m3, x);
//                if (ch == 0x0a)
//                    Console.WriteLine(m1);
//                }
//             else
//                 {
//                     Console.WriteLine(m2, ch, x);
//                 }
//             }
//         catch (OverflowException e)
//             {
//             Console.WriteLine("{0} Value read = {1}.", e.Message, x);
//             ch = Char.MinValue;
//             Console.WriteLine(m1);
//             }
//         } while (ch != '+');
//    }
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