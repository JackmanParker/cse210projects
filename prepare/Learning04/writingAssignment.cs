

public class WritingAssignment : Assignment
{
    
    private string _title;
    

    public WritingAssignment() : base() 
    {
        _title = "Inheritence";
        
    }
    public WritingAssignment(string name, string topic, string title) : base (name, topic)
    {
        _title = title;
    }
    public string GetWritingInformation(){
        return $"What to write about {_title}"; 
    }
}