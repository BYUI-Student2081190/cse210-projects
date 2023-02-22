//Child to Activity
using System;

class BreathingActivity : Activity
{
    //Attributes
    //None

    //Constructors
    public BreathingActivity(string name, string description, List<string>messageList, int pauseStyle, string fileLocation) : base(name, description, messageList, pauseStyle, fileLocation)
    {
        //This sets all the values in the Base class so nothing really needs to go in here.
    }

    //Methods
    public void Run()
    {
        //Get the intro from parent
        DisplayIntro();

        //Now run things specific to this class
        //Now go to the breath in and out loop
        Console.WriteLine();

        Loop(_pauseStyle);

        //Finish the program
        DisplayFinish();
    }

    private void Loop (int deration)
    {
        //Get the time for the loop
        DateTime loopTime = DateTime.Now;
        DateTime stopTime = loopTime.AddSeconds(deration);

        //Now loop the breathing activity until it is completed
        while (loopTime < stopTime)
        {
            //Write a blank
            Console.WriteLine();

            //Write Activity
            Console.WriteLine();
            Console.Write("Breath in...");
            //Add number counter
            DisplayCounter(4, 1000);

            //Add the seconds
            loopTime = loopTime.AddSeconds(4);

            //Now breath out
            Console.WriteLine();
            Console.Write("Breath out...");
            //Add number counters
            DisplayCounter(6, 1000);

            //Add the seconds
            loopTime = loopTime.AddSeconds(6);
        }
        
        Console.WriteLine();
    }
}