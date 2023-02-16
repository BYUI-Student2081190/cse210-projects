using System;

public class MathAssignment : Assignment
{
    //Attributes
    private string _textbookSection = "";
    private string _problems = "";

    //Constructors
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    //Methods
    public string GetHomeworkList()
    {
        return($"{_textbookSection} {_problems}");
    }
}