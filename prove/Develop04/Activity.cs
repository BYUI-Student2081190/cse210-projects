//Parent Class Activity
using System;
using System.IO;

class Activity
{
    //Attributes
    protected string _name;
    protected string _description;
    protected List<string> _messageList;
    protected int _pauseStyle;
    //STRETCH: Attributes
    private string _fileLocation;
    private List<string> _fileList = new List<string>();

    //Constructors
    public Activity(string name, string description, List<string>messageList, int pauseStyle, string fileLocation)
    {
        //Set the variables to what they need to be
        _name = name;
        _description = description;
        _messageList = messageList;
        _pauseStyle = pauseStyle;
        _fileLocation = fileLocation;
    }

    //Methods
    public void DisplayIntro()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");

        //Get User Input
        IntroUserInput();

        //Clear the console and move on to the activity
        Console.Clear();

        Console.WriteLine("Get Ready...");

        DisplayAnimation(3);
    }

    private void IntroUserInput()
    {
        //Get the response from the user
        string userInput = Console.ReadLine();
        //Change to int
        int numInput = int.Parse(userInput);
        //Set _pauseStyle to Input
        _pauseStyle = numInput;
    }

    public void DisplayAnimation(int loopTime)
    {
        //Added loopTime variable to help change the duration of how long the animation displays
        //Create a loop
        DateTime animationStart = DateTime.Now;
        DateTime animationEnd = animationStart.AddSeconds(loopTime);

        while(animationStart < animationEnd)
        {
            //Create animation, that changes frames every half second
            Console.Write("^");

            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write(">");

            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("v");

            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("<");

            Thread.Sleep(250);
            Console.Write("\b \b");

            //add seconds to animationStart, so you can close the loop.
            animationStart = animationStart.AddSeconds(1);
        }
        Console.Write("\b \b");
    }

    public void DisplayCounter(int seconds, int sleepTime)
    {
        //This counter always pauses by one second(1000)
        //Create a while loop that subtracts the seconds by 1 each second
        //NOTE: This can only do numbers in the ones place, cannot do 10 or higher currently
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(sleepTime);

            //Remove previous sec
            Console.Write("\b \b");

            //Subtract Seconds by 1
            seconds -= 1;
        }
    }

    public string GetPrompt()
    {
        //Get a prompt from the list in the base class
        //Create a random number to grab from the list
        Random generateNum = new Random();

        //Get the length of the list
        int listLength = _messageList.Count();

        //Get a random number to get a prompt from the list, using it's index
        int promptIndex = generateNum.Next(0, listLength);

        string selectedPrompt = _messageList[promptIndex];

        return(selectedPrompt); 
    }

    public void DisplayFinish()
    {
        //Display the end of each program
        Console.WriteLine();
        Console.WriteLine("Well done!!");

        DisplayAnimation(4);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_pauseStyle} seconds of the {_name}.");

        //STRETCH: Added an ability to write to a file, calls a new function called write that writes
        //"What activity", "How long activity was", "Date".
        SaveFile();

        DisplayAnimation(4);
    }

    private void SaveFile()
    {
        //Get the date to save in the file
        DateTime currentDate = DateTime.Now;

        //Load file into list for saving
        _fileList = File.ReadAllLines(_fileLocation).ToList();
        
        //Save to the file list
        _fileList.Add($"{currentDate} -- Activity: {_name}, Time: {_pauseStyle}secs");

        //Add back to file
        File.WriteAllLines(_fileLocation, _fileList);
    }
}