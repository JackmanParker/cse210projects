

public class MathAssignment : Assignment 
//Creates a class with a parent class after the :
{
    
    private string _textbookSection;
    private string _problems;

    public MathAssignment() : base() 
    {
        _problems = "1-10";
        _textbookSection = "section 3";
    }
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base (name, topic)
    {
        // The constructer still needs it all written out, but the constucets can be used rom the other class using Base
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomework(){
        return $"{_textbookSection} problems:{_problems}"; 
    }
}