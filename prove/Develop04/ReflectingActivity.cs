//Child to Activity
using System;

class ReflectingActivity : Activity
{
    //Attributes
    private List<string> _refList;
    //STRETCH: Attribute used to see if an item
    //has already been used in the list
    private List<string> _usedList = new List<string>();
    private int _listUsed;

    //Constructors
        public ReflectingActivity(string name, string description, List<string>messageList, int pauseStyle, string fileLocation) : base(name, description, messageList, pauseStyle, fileLocation)
    {
        //Everything gets saved to parent, and we need to set items in the local list
        _refList = new List<string>{"Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};

        //Add a value to _listUsed
        _listUsed = 0;
    }

    //Methods
    public void Run()
    {
        //Run the intro
        DisplayIntro();

        //Display blank line
        Console.WriteLine();

        //Get the prompt
        string selectedPrompt = GetPrompt();

        //Display Prompt
        DisplayPrompt(selectedPrompt);

        //Activity
        LoopActivity(_pauseStyle);

        //Display ending
        DisplayFinish();
    }

    private void DisplayPrompt(string prompt)
    {
        //Displayed text
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");

        //Waits till they press enter
        Console.ReadLine();

        //Second half of the prompt section
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this expiriance.");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        //display numbers
        DisplayCounter(5, 1000);
    }

    private void LoopActivity(int deration)
    {
        //Clear the Console for the activity
        Console.Clear();
        //Get current time
        DateTime activityTime = DateTime.Now;
        //End activity time
        DateTime activityStop = activityTime.AddSeconds(deration);

        //Create a loop that gets the question and uses it
        while (activityTime < activityStop)
        {
            //Get a question to use
            string question = GetQuestion();

            //Display it to the console
            Console.WriteLine();
            Console.Write($"> {question} ");
            DisplayAnimation(15);

            //Add 15 seconds to the activity time
            activityTime = activityTime.AddSeconds(15);
        }
        //Write blank line for next part
        Console.WriteLine();
    }

    private string GetQuestion()
    {
        //Get a question from the list in this class
        //Create a random number to grab from the list
        Random generateNum = new Random();

        //Get the length of the list
        int listLength = _refList.Count();

        //Add a question checker that checks to see if a question has already been asked, and only
        //grabs a similar question only when the questions are all used.
        bool test = true;

        //Get a random number to get a prompt from the list, using it's index
        int refIndex = generateNum.Next(0, listLength);
        
        //Add an if statement, that contains a while loop
        //The if statement tests to see if this has looped
        //Through enough to need to keep things unique each
        //run.
        if (_listUsed < listLength)
        {
            while (test == true)
            {
                if (_usedList.Contains($"{refIndex}") == true)
                {
                    //Calculate a new number
                    refIndex = generateNum.Next(0, listLength);

                    //Stay in loop
                    test = true;
                }

                else
                {
                    //Use this only if the top is not true
                    _usedList.Add($"{refIndex}");

                    //Break the loop
                    test = false;
                }
            }
        }

        //Set the question to this
        string selectedQuestion = _refList[refIndex];

        //Add to list used
        _listUsed += 1;

        return(selectedQuestion);
    }


}