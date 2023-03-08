//Goal Manager Class, called from program
//built for storage of Goal objects, and UI.

using System;
using System.IO;

class GoalManager
{
    //attributes
    private int _totalPoints;
    //List stores the Goal objects in a way
    //the user can read them.
    private List<Goal> _goalList = new List<Goal>();

    //Constructors
    public GoalManager()
    {
        //When a new object is created, _totalPoints
        //always = 0.
        _totalPoints = 0;
    }

    //Methods

    //Add Goal
    public void AddGoal(Goal currGoal)
    {
        //Add goal to the list
        _goalList.Add(currGoal);
    }

    //Display the goals
    public void Display()
    {
        //Make a blank space
        Console.WriteLine();

        //Make a for loop that obtains all the goals types, and makes a display for them.
        foreach (Goal goal in _goalList)
        {
            //Write out the goal with it's information
            string goalInfo = goal.ToDisplayString();

            //Display to console
            Console.WriteLine(goalInfo);
        }

        //After done pause a second
        Thread.Sleep(5000);
    }

    //Record completeing a goal.
    public void RecordEvent()
    {
        //Make Blank line
        Console.WriteLine();
        //Display opening line,
        Console.WriteLine("The goals are:");
        //Blank number variable to hold a count of how
        //many goals are in the code.
        int count = 0;

        //Display a list of goals, and allow the user to
        //select which goal to report on based on number selection.
        foreach (Goal goal in _goalList)
        {
            //Display all the goals by name and number,
            count += 1;

            Console.WriteLine($"{count}. {goal.GetName()}");
        }

        //Allow the user to then select the goal they want to edit
        Console.Write("Which goal did you accomplish? ");

        int userInput = int.Parse(Console.ReadLine());

        //Subtract 1 from the userInput to change it to a userIndex that can select the object to
        //change.
        userInput = userInput - 1;

        //Now grab the object from it's index
        Goal selectedGoal = _goalList[userInput];

        //Add a check to see if this goal has already been completed
        if (selectedGoal.GetStatusComplete() == true)
        {
            Console.WriteLine($"You have already completed the {selectedGoal.GetName()} goal, try a different one.");
        }

        else
        {
            //Create Check to see if it is a ChecklistGoal
            if (selectedGoal.GetGoalType() == 3)
            {
                selectedGoal.SetComplete();

                //Now add the points to the total
                _totalPoints += selectedGoal.GetGoalSetPoints();

                //Test to see if it got completed
                if (selectedGoal.GetStatusComplete() == true)
                {
                    _totalPoints += selectedGoal.GetBonusPointValue();

                    //Write a congrats for the bonus
                    Console.WriteLine($"Woohoo! Congrats on the {selectedGoal.GetBonusPointValue()} points! Way to stick with it till the end!");
                }

                //Replace List
                _goalList[userInput] = selectedGoal;

                //Add congradulations message
                Console.WriteLine($"Congrats! You have earned {selectedGoal.GetGoalSetPoints()} points!");
            }

            else
            {
                //Make the object become completed
                selectedGoal.SetComplete();

                //Now add the points to the total
                _totalPoints += selectedGoal.GetGoalSetPoints();

                //Replace List
                _goalList[userInput] = selectedGoal;

                //Add congradulations message
                Console.WriteLine($"Congrats! You have earned {selectedGoal.GetGoalSetPoints()} points!");
            }
        }
        //Put the Thread to sleep to let them look
        Thread.Sleep(3000);
    }

    //Create the Goal Function, creates the object to store the user info in.
    public void CreateGoal()
    {
        //Display the different type of goals here.

        Console.WriteLine("The Type of Goals are: \n 1. Simple Goal \n 2. Eternal Goal \n 3. CheckList Goal");

        //Ask the user which goal they would like to do.
        Console.Write(" Which type of goal would you like to create? ");

        //Now read the input
        string userInput = Console.ReadLine();

        //Convert to int
        int userInputInt = int.Parse(userInput);

        //Now create a goal using if statements, based on the User input.
        //Create a SimpleGoal
        if (userInputInt == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(1, "", "", 0, false);
            //Call all the setters here, so the constructor can be
            //used to load old objects into objects.
            simpleGoal.SetName();
            simpleGoal.SetDescript();
            simpleGoal.SetGoalSetPoints();
            AddGoal(simpleGoal); 
        }

        else if (userInputInt == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(2, "", "", 0, false);
            eternalGoal.SetName();
            eternalGoal.SetDescript();
            eternalGoal.SetGoalSetPoints();
            AddGoal(eternalGoal);
        }

        else if (userInputInt == 3)
        {
            ChecklistGoal checkListGoal = new ChecklistGoal(3, "", "", 0, false, 0, 0, 0);
            checkListGoal.SetName();
            checkListGoal.SetDescript();
            checkListGoal.SetGoalSetPoints();
            //Now add the setters specific to this class
            checkListGoal.SetCompleteTimes();
            checkListGoal.SetBonusPointValue();
            AddGoal(checkListGoal);
        }

        //Handles if it does not work.
        else
        {
            Console.WriteLine("Goal Type not Reconized, please try again.");
            Thread.Sleep(3000);
        }
    }

    public int GetPoints()
    {
        return _totalPoints;
    }

    //Save goal function
    public void SaveGoals()
    {
        //Fist ask for the file,
        Console.Write("What is the filename for the goal file? ");

        //Then read what is inputed to the computer.
        string userResponse = Console.ReadLine();

        //Now open the file for saving,
        using (StreamWriter savefile = new StreamWriter(userResponse))
        {
            //Start by putting the points into the file first
            savefile.WriteLine($"{_totalPoints}");

            //Now loop through the list and save each object
            //in an serialized way that you can pull back out.
            foreach (Goal obj in _goalList)
            {
                //Get all the info we need to work with,
                //start by getting the importaint info
                string name = obj.GetName();
                string description = obj.GetDescript();
                int pointWorth = obj.GetGoalSetPoints();
                bool completed = obj.GetStatusComplete();
                int goalType = obj.GetGoalType();

                //Now gain additonal info if needed,
                //mainly if the goalType is 3.
                if (goalType == 3)
                {
                    //Get info specific to Checklist goals
                    //and save them the way they should be.
                    int bonusPoints = obj.GetBonusPointValue();
                    int completedTimes = obj.GetCompletedCount();
                    int completeTimes = obj.GetCompleteTimes();
                    //Now save the additional info at the end.
                    savefile.WriteLine($"{goalType}:{name},{description},{pointWorth},{completed},{bonusPoints},{completedTimes},{completeTimes}");
                }

                else
                {
                    //This is for everything else to get saved
                    savefile.WriteLine($"{goalType}:{name},{description},{pointWorth},{completed}");
                }
            }
        }
    }

    //Load Goals Function
    public void LoadGoals()
    {
        //Start by obtaining the file the user wants
        Console.Write("What file would you like to load the goals from? ");

        //Get the userinput
        string userInput = Console.ReadLine();

        //Now open the file for reading
        string[] sections = System.IO.File.ReadAllLines(userInput);

        //Grab the first line and convert it to a int
        _totalPoints = int.Parse(sections[0]);

        //Now remove the top line
        sections[0] = "";

        //Now split up the rest of the sections,
        foreach (string line in sections)
        {
            //Now split it so you can get the first part.
            string[] partOfLine = line.Split(":");

            string objTypeBeta = partOfLine[0];

            //Create a check to see if it is the first line
            if (objTypeBeta != "")
            {
                //Convert to int
                int objType = int.Parse(objTypeBeta);

                //Then add this so it actually has a
                //second half.
                string restOfLine = partOfLine[1];
            
                //Now split the rest of the line and create an
                //object.
                string[] splitRestOfLine = restOfLine.Split(",");

                //Now split up the stuff based on what type of
                //goal it is.
                if (objType == 1)
                {
                    //Create a Simple Goal
                    string name = splitRestOfLine[0];
                    string descript = splitRestOfLine[1];
                    int pointWorth = int.Parse(splitRestOfLine[2]);
                    bool completed = bool.Parse(splitRestOfLine[3]);

                    //Now create goal and add it to the list
                    SimpleGoal loadedGoal = new SimpleGoal(objType, name, descript, pointWorth, completed);

                    //Now add it to the list
                    _goalList.Add(loadedGoal);

                }

                else if (objType == 2)
                {
                    //Create a Eternal Goal
                    string name = splitRestOfLine[0];
                    string descript = splitRestOfLine[1];
                    int pointWorth = int.Parse(splitRestOfLine[2]);
                    bool completed = bool.Parse(splitRestOfLine[3]);

                    //Now create goal and add it to the list
                    EternalGoal loadedGoal = new EternalGoal(objType, name, descript, pointWorth, completed);

                    //Now add it to the list
                    _goalList.Add(loadedGoal);
                }

                else if (objType == 3)
                {
                    //Create a CheckList Goal
                    string name = splitRestOfLine[0];
                    string descript = splitRestOfLine[1];
                    int pointWorth = int.Parse(splitRestOfLine[2]);
                    bool completed = bool.Parse(splitRestOfLine[3]);

                    //Additional stuff
                    int bonusPoint = int.Parse(splitRestOfLine[4]);
                    int completedTimes = int.Parse(splitRestOfLine[5]);
                    int completeTimes = int.Parse(splitRestOfLine[6]);

                    //Now create goal and add it to the list
                    ChecklistGoal loadedGoal = new ChecklistGoal(objType, name, descript, pointWorth, completed, bonusPoint, completeTimes, completedTimes);

                    //Now add it to the list
                    _goalList.Add(loadedGoal);
                }

                else
                {
                    //Do nothing
                }
            }
        }
    }
}
