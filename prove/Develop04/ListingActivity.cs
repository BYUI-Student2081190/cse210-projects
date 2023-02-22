//Child to Activity
using System;

class ListingActivity : Activity
{
    //Attributes
    //None

    //Constructors
    public ListingActivity(string name, string description, List<string>messageList, int pauseStyle, string fileLocation) : base(name, description, messageList, pauseStyle, fileLocation)
    {
        //This sets all the values in the Base class so nothing really needs to go in here.
    }

    //Methods
    public void Run()
    {
        //Get the intro from parent
        DisplayIntro();

        //Now run things specific to this class
        //Get prompt
        string currentPrompt = GetPrompt();

        //Display Prompt
        DisplayPrompt(currentPrompt);

        //Call the Activity Loop
        ActivityLoop();

        //Finish the program
        DisplayFinish();
    }

    private void DisplayPrompt(string prompt)
    {
        //Displayed text
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        //Give them a few seconds to read it and begin.
        Console.Write("You may begin in: ");
        //display numbers
        DisplayCounter(5, 1000);
    }

    private void ActivityLoop()
    {
        //Create a current time object
        DateTime currentTime = DateTime.Now;
        //End Time
        DateTime endTime = currentTime.AddSeconds(_pauseStyle);

        //Put a blank line before the loop to make it look nice for the user
        Console.WriteLine();

        //Create loop while the time is not yet above endTime
        while (currentTime < endTime)
        {
            //Here is the responces
            //Console.WriteLine();
            Console.Write(">");

            Console.ReadLine();

            //Change currentTime to break the loop when the condition is met
            currentTime = DateTime.Now;
        }
    }
}