using System;


namespace Develop03
{class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Scripture testscripture = new Scripture();
        Content newcontent = new Content();
        Reference defaultRef = new Reference();
        // string filename = "scriptures.txt";
        // Content content = new Content();
        // List<Word> words = content.Load(filename);
        
        // Scripture scripture = new Scripture();
        // scripture.Hold(words);
        testscripture.Hold(defaultRef.MakeString(), newcontent.GiveWords());
        Console.Clear();
        while(userInput != "quit"){
            
            Console.WriteLine($"\n\n{testscripture.ConvertToString()}\n\n");
            Console.WriteLine("Press enter to hide four words.");
            Console.WriteLine("Type \"quit\" to close this program.");
            Console.WriteLine("Type \"show\" to show one hidden word.");
            userInput = Console.ReadLine();
            if (testscripture.CheckHidden() == true)
            {
                Console.Clear();
                userInput = "quit";
            }
            
            if (userInput == "show")
            {
                if (testscripture.CheckShown() == false)
                    {testscripture.ShowWord();}
                else{
                    Console.Clear();
                }
            }
            if (userInput != "quit" && userInput != "show")
            {
                
                for (int i = 0; i < 4; i++)
                    {testscripture.HideWord();}
            }
            
           
        }
        
        
    }
}
}