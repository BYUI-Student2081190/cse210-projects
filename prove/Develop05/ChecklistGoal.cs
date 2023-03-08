//Sub-class ChecklistGoal to base class Goal.

using System;
using System.IO;

class ChecklistGoal : Goal 
{
    //Attributes
    private int _bonusPointValue;
    private int _completeTimes;
    private int _completedCount;

    //Constructors
    public ChecklistGoal(int goalType, string name, string descript, int goalPoints, bool completed, int bonusPoint, int completeTimes, int completedCount) : base(goalType, name, descript, goalPoints, completed)
    {
        //Set all for loading
        _bonusPointValue = bonusPoint;
        _completeTimes = completeTimes;
        _completedCount = completedCount;
    }

    //methods

    public void SetCompleteTimes()
    {
        //Write the question to the console
        Console.Write(" How many times does this goal need to be accomplished for a bonus? ");

        //Read the response
        int userInput = int.Parse(Console.ReadLine());

        //Set _name
        _completeTimes = userInput;
    } 

    public void SetBonusPointValue()
    {
        //Write the question to the console
        Console.Write(" How much will be the bonus point value when completed? ");

        //Read the response
        int userInput = int.Parse(Console.ReadLine());

        //Set _name
        _bonusPointValue = userInput;
    }

    //Create a Getter for bonusPoints
    public override int GetBonusPointValue()
    {
        return _bonusPointValue;
    }

    public override int GetCompletedCount()
    {
        return _completedCount;
    }

    public override int GetCompleteTimes()
    {
        return _completeTimes;
    }

    //Create overrides
    public override string ToDisplayString()
    {
        if (_completed == false)
        {
            string goalWritten = $"[ ] {_name} ({_descript}) --- Currently Completed {_completedCount}/{_completeTimes}"; 
            return goalWritten;
        }

        else
        {
            string goalWritten = $"[X] {_name} ({_descript}) --- Currently Completed {_completedCount}/{_completeTimes}";
            return goalWritten;
        } 
    }

    public override void SetComplete()
    {
        //Each time this is completed add one to the variable
        _completedCount += 1;

        //Create a check to see if it is completed.
        if (_completedCount == _completeTimes)
        {
            _completed = true;
        }
        
        else
        {
            _completed = false;
        }
    }
}