using System;
using System.Collections.Generic;
using System.IO;
//I added an additional function that reverses the order in which the journal is saved so you can save it chronologically.
//Then when you load it back you can use the same function to flip it back for more writing. I also added a couple more prompts. 
namespace Develop02{
    class Program
    {
        static List<Entry> readFromFile(string filename){
            List<Entry> savedEntries = new List<Entry>();
            
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines){
                string[] parts = line.Split(",,");

                Entry oldentry = new Entry();
                oldentry._date =parts[0];
                oldentry._response = parts[2];
                oldentry._prompt = parts[1];
                savedEntries.Add(oldentry);
            }
            return savedEntries;
        }
        static void Main(string[] args)
        {
           Jounal currentJournal = new Jounal();
           Prompt currentPrompt = new Prompt();
           
           int userchoice = 0;
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("dddd, dd MMMM yyyy"));
            string fileName = "myJournal.txt";

           Console.WriteLine("Welcome to the journal Program \nPlease select one of the following");
           while (userchoice != 6) 
            {    
                Console.Write("\n1. Write\n2. Read\n3. Load\n4. Save\n5. Reverse order of entries\n6. Quit\n");
                userchoice = int.Parse(Console.ReadLine());
                if(userchoice == 1)
                {
                    
                    string currentPromptString = currentPrompt.GetPrompt();
                    Console.WriteLine($"{currentPromptString}");
                    string response = Console.ReadLine();
                    Entry currentEntry = new Entry();
                    currentEntry.Hold(currentPromptString, response, currentDate.ToString("dddd dd MMMM yyyy"));
                    currentJournal.AddEntry(currentEntry);

                }
            
                else if (userchoice == 2)
                {
                    List<Entry> entries = currentJournal.GetAllEntries();
                    foreach (Entry entry in entries)
                    {
                        string message = entry.convertToSting();
                        Console.WriteLine(message);
                    }
                }
                else if (userchoice == 3)
                {
                    Console.WriteLine("What is the name of your file?");
                    fileName = Console.ReadLine();

                    List<Entry> newentries = readFromFile(fileName);
                    currentJournal._entries = newentries;

                }

                else if (userchoice == 4)
                {
                 
                 using (StreamWriter outputFile = new StreamWriter(fileName))
                 {
                    List<Entry> entries = currentJournal.GetAllEntries();
                    foreach (Entry entry in entries)
                    {
                        outputFile.WriteLine(entry.makeCommaSeperated());
                    }
                    

                 }
                }
                else if (userchoice == 5)
                {
                    List<Entry> entries = currentJournal.GetAllEntriesBackwards();

                }
            }
           


           
           
           
           
           
           
           
           
           
           
           
           
           
           
        //    Prompt myprompt = new Prompt();
           
        //     Entry myEntry = new Entry();
        //     myEntry.Hold(myprompt.GetPrompt(), "Parker jackman", "May 8 2023");

        //     Jounal journal = new Jounal();
        //     journal.AddEntry(myEntry);


        }
    }
}