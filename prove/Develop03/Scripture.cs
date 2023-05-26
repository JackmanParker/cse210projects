using System;
using System.Collections.Generic;


namespace Develop03{



    class Scripture
    {
        private string _refrence;

        private List<Word> _wordList;
    
        public void Hold(string reference, List<Word> words){
            this._refrence = reference;
            this._wordList = words;

        }

        public string ConvertToString(){
            List<string> textList = new List<string>();
            
            foreach (Word word in _wordList){
                textList.Add(word.Display());

            }
            string text = String.Join(" ", textList);
            
            
            return $"{_refrence}\n\n\"{text}\"";
        }

        public void HideWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _wordList.Count);
            Word randomWord = _wordList[randomIndex];
            
            randomWord.Hide();
        }

    }


    





}