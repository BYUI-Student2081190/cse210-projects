//Simple Goal sub class, it's job is to take care of simple goals.

using System;
using  System.IO;

class SimpleGoal : Goal
{
    //Attributes
    //No new ones, all inherited by the base class

    //Constructors
    public SimpleGoal(int goalType, string name, string descript, int goalPoints, bool completed) : base(goalType, name, descript, goalPoints, completed)
    {
        //Done in the base class
    }

    //methods
    //All come from Base Class
}