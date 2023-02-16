using System;

public class Assignment
{
    //Attributes
    private string _studentName = "";
    private string _topic = "";

    //Constructors
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    //Methods
    public string GetSummary()
    {
        return($"{_studentName} - {_topic}");
    }

    public string GetStudentName()
    {
        return(_studentName);
    }

}