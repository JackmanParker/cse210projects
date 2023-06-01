

public class MathAssignment : Assignment
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
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomework(){
        return $"{_textbookSection} problems:{_problems}"; 
    }
}