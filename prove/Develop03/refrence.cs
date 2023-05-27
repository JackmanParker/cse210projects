using System;
using System.Collections.Generic;


namespace Develop03{

    class Reference{

        private string _book;
        private string _chapter;
        private string _verse;

        public  Reference(){
            _book = "Mark";
            _chapter = "12";
            _verse = "30";
        }
        public  Reference(string book, string chapter, string verse){
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }
        public string MakeString(){
            return $"{_book}, {_chapter}:{_verse}";
        }
    }


}