using System;


namespace Develop03
{class Program
{
    static void Main(string[] args)
    {
        
        Scripture testscripture = new Scripture();
        Content newcontent = new Content();
        // string filename = "scriptures.txt";
        // Content content = new Content();
        // List<Word> words = content.Load(filename);
        string reference = "test referance";
        Word testword1 = new Word("test");
        Word testword2 = new Word("word");
        
        List<Word> words = new List<Word>();
        words.Add(testword1);
        words.Add(testword2);
        // Scripture scripture = new Scripture();
        // scripture.Hold(words);
        testscripture.Hold(reference, newcontent.GiveWords());
        Console.WriteLine(testscripture.ConvertToString());
        testscripture.HideWord();
        Console.WriteLine(testscripture.ConvertToString());
        Console.WriteLine(newcontent.GiveWords());
        // if (menuItem == "1")
        // {
        //     scripture.DisplayWords();
        // }
        // else if (menuItem == "2")
        // {
        //     scripture.HideWord();
        // }

        // // inside scripture
        // public void HideWord()
        // {
        //     Random random = new Random();
        //     int randomIndex = random.Next();
        //     Word randomWord = _wordList[randomIndex];
        //     randomWord.Hide();
        // }

        // // inside Word class
        // public void Hide()
        // {
        //     _currentText = "_____";
        // }

        // public void Show()
        // {
        //     _currentText = _originalText; // "For"
        // }
    }
}
}