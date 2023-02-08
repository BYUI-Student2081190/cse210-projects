using System;
//WHAT MAKES THIS PROGRAM UNIQUE
//Here is what makes this program unique, it has a new class set to get a new
//scripture at random, and it also has a feature to get rid of only 3 words at
//a time. It also will not get rid of words if they have already been gotten rid of.

class Program
{   
    static void Main(string[] args)
    {
        //Local variable to hold the object to be used throughout the program
        Scripture _myScripture;

        //Main functions
        void SetMyScripture(string scriptureReference, string myScriptureText)
        {
            //Create the new Scripture Object and save
            _myScripture = new Scripture(scriptureReference, myScriptureText);

        }

        //Call the scripture class to remove words
        bool RemoveWords()
        {
            //Create a cando that makes sure we can still move
            List<string> currentList = _myScripture.GetWords();
            //Now see if the list meets the parameters
            //To cause us to just quit the program
            int result = testList(currentList);

            if (result != currentList.Count)
            {
                _myScripture.SetWordsList();
                _myScripture.Display();

                return(true);
            }

            else
            {
                return(false);
            }

        }

        int testList(List<string> currentList)
        {
            int canDo = 0;

            foreach (string word in currentList)
            {
                if (word[0] == '_')
                {
                    canDo += 1;
                }

                else
                {
                    canDo += 0;
                }
            }

            return(canDo);
        }

        bool Input(string inMessage)
        {
            //Check an see if inMessage is quit
            //Make string lower
            string lowerMessage = inMessage.ToLower();

            if (lowerMessage == "quit")
            {
                return(false);
            }

            else{
                return(true);
                //Idea: Make it call the nested function in MyScripture up top
            }
        }

        void UILoop()
        {
            //Create loop variable
            bool doAgain = true;

            //Write new Line
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            //Here is the input
            string inMessage = Console.ReadLine();

            //Send input away to Input function
            doAgain = Input(inMessage);

            //If true repeat
            if (doAgain == true)
            {
                //clear and start again
                Console.Clear();

                //Call the scripture function to 
                //Write the scripture again
                bool testResult = RemoveWords();

                //Call the UILoop function too
                //This causes the program to stop if the
                // List gets all the way full of _ characters
                if (testResult == true)
                {
                    UILoop();
                }

                else
                {
                    doAgain = false;
                }
            }
        }

        //Code in main
        //Call new class/library to get the scriptures
        RandomScript randomScript = new RandomScript();

        //Get the info needed
        string scriptureReference = randomScript.GetReferencePart();

        string myScriptureText = randomScript.GetScriptTextPart();

        //Set the object to the variable
        SetMyScripture(scriptureReference, myScriptureText);

        //Start the menu
        UILoop();
    }
}