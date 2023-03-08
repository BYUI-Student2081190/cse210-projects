//The Goal Base Class
using System;
using System.IO;

class Goal 
{
    //Attributes
    protected string _name;
    protected string _descript;
    //My replacement for _value, _goalType is a varible to
    //store what type of goal this is.
    protected int _goalType;
    //My replacement for _compComp, _goalSetPoints job is to
    //hold how many points a goal is worth when created.
    protected int _goalSetPoints;
    //This bool value will be used to test and see if the goal is completed,
    //it is default false.
    protected bool _completed;

    //Constructors
    public Goal(int goalType, string name, string descript, int goalPoints, bool completed)
    {
        //From my research these methods will get called first
        //when a child is created.

        //Set the _goalType
        _goalType = goalType;

        //Set the rest
        _name = name;

        _descript = descript;

        _goalSetPoints = goalPoints;

        //Set _completed
        _completed = completed;
    }

    //methods

    //Setters
    public void SetName()
    {
        //Write the question to the console
        Console.Write(" What is the name of your goal? ");

        //Read the response
        string userInput = Console.ReadLine();

        //Set _name
        _name = userInput;
    }

    public void SetDescript()
    {
        //Write the question to the console
        Console.Write(" What is a short description of your goal? ");

        //Read the response
        string userInput = Console.ReadLine();

        //Set _name
        _descript = userInput;
    }

    public void SetGoalSetPoints()
    {
        //Write the question to the console
        Console.Write(" What is the amount of points associated with this goal? ");

        //Read the response
        string userInput = Console.ReadLine();

        //Turn it into an int
        int userInputInt = int.Parse(userInput);

        //Set _name
        _goalSetPoints = userInputInt;
    }

    //This Complete function returns true if the goal has been completed, and
    //false if not. Right now it defaults to true, until a child class says otherwise.
    public virtual void SetComplete()
    {
        _completed = true;
    }

    //Getters
    public string GetName()
    {
        return _name;
    }

    public string GetDescript()
    {
        return _descript;
    }

    public int GetGoalType()
    {
        return _goalType;
    }

    public int GetGoalSetPoints()
    {
        return _goalSetPoints;
    }

    public bool GetStatusComplete()
    {
        return _completed;
    }

    public virtual int GetBonusPointValue()
    {
        return 0;
    }

    //Converts the objects into a string that can later displayed
    //by the GoalManager.
    public virtual string ToDisplayString()
    {
        if (_completed == false)
        {
            string goalWritten = $"[ ] {_name} ({_descript})"; 
            return goalWritten;
        }

        else
        {
            string goalWritten = $"[X] {_name} ({_descript})";
            return goalWritten;
        }      
    }

    //Two overrides in Checklist to get the additional info
    public virtual int GetCompleteTimes()
    {
        return 0;
    }

    public virtual int GetCompletedCount()
    {
        return 0;
    }
}