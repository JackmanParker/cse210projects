using System;
using System.Collections.Generic;


namespace Develop03{
    class Content{
        
        private string _text;
        public Content(string words){
           _text = words;
        }

        public Content(){
            _text = "And thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind, and with all thy strength: this is the first commandment.";
        }

        public List<Word> GiveWords(){
            
            
            List<Word> textList = new List<Word>();
            List<string> stringlist;
            stringlist = _text.Split(" ").ToList();
            foreach (string item in stringlist){
                Word newword = new Word(item);
                textList.Add(newword);
            }
            
            return textList;
        }

    }
    
}