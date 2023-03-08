//Sub Class to the Goal base class. Functions similar to the Simple Goal Class.

using System;
using System.IO;

class EternalGoal : Goal 
{
    //Attributes
    //All inherited from the Goal Class

    //Constructors
    public EternalGoal(int goalType, string name, string descript, int goalPoints, bool completed) : base(goalType, name, descript, goalPoints, completed)
    {
        //Constructors handled in base class.
    }

    //methods
    //This always, always returns false to make it Eternal.
    public override void SetComplete()
    {
        _completed = false;
    }
}