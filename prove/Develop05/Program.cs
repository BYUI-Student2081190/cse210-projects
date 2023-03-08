using System;

class Program
{
    static void Main(string[] args)
    {
        //ADDITIONAL FEATURES
        //Allow a type of leveling system that is cal-
        //culated by your total points divided by 1000.
        //Then it gives you a title by how many points you get.

        //Also added a few features to prevent the user from
        //doing the same goal twice, as long as it is not an et-
        //ernal goal.

        //Added a feature to also allow when saving the file,
        //to have the program remember everything about the
        //checklist goal, including how many times it needed
        //to be completed originally.

        //UI for user
        //Create a variable to hold the userAnswers
        string userInput = "0";

        //Create object to call the GoalManager
        GoalManager menu = new GoalManager();

         //Create function to calculate the amount of points
        string LevelCalc()
        {
            //Take the total points and divide them by 1000
            int levelGenerator = (menu.GetPoints()) / 1000;

            //Now test 
            if (levelGenerator <= 1)
            {
                //Create a string to return
                return "Current Level: 1 --- Title: Rookie";
            }

            else if (levelGenerator <= 2 && levelGenerator > 1)
            {
                //Create a string to return
                return "Current Level: 2 --- Title: Fledgling";
            }

            else if (levelGenerator <= 3 && levelGenerator > 2)
            {
                //Create a string to return
                return "Current Level: 3 --- Title: Goal Lover";
            }

            else if (levelGenerator <= 4 && levelGenerator > 3)
            {
                //Create a string to return
                return "Current Level: 4 --- Title: Goal Slayer";
            }

            else if (levelGenerator <= 5 && levelGenerator > 4)
            {
                //Create a string to return
                return "Current Level: 5 --- Title: All-Star";
            }

            else if (levelGenerator <= 6 && levelGenerator > 5)
            {
                //Create a string to return
                return "Current Level: 6 --- Title: Effortless Goal Setter";
            }

            else if (levelGenerator <= 7 && levelGenerator > 6)
            {
                //Create a string to return
                return "Current Level: 7 --- Title: Bringing the Heat";
            }

            else if (levelGenerator <= 8 && levelGenerator > 7)
            {
                //Create a string to return
                return "Current Level: 8 --- Title: Big Shot";
            }

            else if (levelGenerator <= 9 && levelGenerator > 8)
            {
                //Create a string to return
                return "Current Level: 9 --- Title: Master";
            }

            else if (levelGenerator <= 10 && levelGenerator > 9)
            {
                //Create a string to return
                return "Current Level: 10 --- Title: The One and Only";
            }

            else
            {
                return "Current Level: MAX --- Title: Legend";
            }
        }

        while (userInput != "6")
        {
            //Display your points
            Console.WriteLine($"\nYou have {menu.GetPoints()} points.");
            //Make blank line.
            Console.WriteLine();
            //DISPLAY LEVEL
            Console.WriteLine($"{LevelCalc()}");
            //Blank Line Again
            Console.WriteLine();
            //Now make the Menu
            Console.WriteLine("Menu Options: \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
            Console.Write("Select a Choice from the menu: ");
            
            //Obtain the user input
            userInput = Console.ReadLine();

            //Now add checks to allow you to do things from the menu
            if (userInput == "1")
            {
                //Call create a new goal
                menu.CreateGoal();
            }

            else if (userInput == "2")
            {
               //Call list goals
               menu.Display(); 
            }

            else if (userInput == "3")
            {
                //Save Goals
                menu.SaveGoals();
            }

            else if (userInput == "4")
            {
                //Load Goals
                menu.LoadGoals();
            }

            else if (userInput == "5")
            {
                //Record an event
                menu.RecordEvent();
            }

            else if (userInput == "6")
            {
                //Do nothing and quit. This is here so the error does not
                //pop up when selecting 6.
            }

            else
            {
                //Give an error message.
                Console.WriteLine("Not a valid answer please try again.");
            }


        }

    }
}