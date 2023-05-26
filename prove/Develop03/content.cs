using System;
using System.Collections.Generic;


namespace Develop03{
    class Content{
        private List<Word> _textList;
        public Content(string words){
            _textList = new List<Word>();
            List<string> stringlist;
            stringlist = words.Split(" ").ToList();
            foreach (string item in stringlist){
                Word newword = new Word(item);
                _textList.Add(newword);
            }
        }

        public Content(){
            string words = "This is my default scripture";
            _textList = new List<Word>();
            List<string> stringlist;
            stringlist = words.Split(" ").ToList();
            foreach (string item in stringlist){
                Word newword = new Word(item);
                _textList.Add(newword);
            }
        }

        public List<Word> GiveWords(){
            return _textList;
        }

    }
    
}