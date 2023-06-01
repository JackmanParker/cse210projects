

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic){
        _studentName = name;
        _topic = topic;
    }
    public Assignment()
    {
        _studentName = "Parker";
        _topic = "Programming with classes";
    }
    
    
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
    






}