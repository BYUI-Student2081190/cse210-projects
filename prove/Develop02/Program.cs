using System;
using System.IO;

class Program
{
    //Public Variables
    static string FileLocation = "";

    static List<string> _entries = new List<string>();

    //Functions for program
    //Function to LoadFile
    static void LoadFile()
    {
        string[] pastEntries = System.IO.File.ReadAllLines(FileLocation);

        foreach (string entry in pastEntries)
        {
            _entries.Add(entry);
        }
    }

    //SaveFile Function
    static void SaveFile()
    {
        using (StreamWriter saveFile = new StreamWriter(FileLocation))
        {
            foreach (string entry in _entries)
            {
                saveFile.WriteLine(entry);
            }
        }
    }

    //MenuSelect function
    static int MenuSelect()
    {
        Console.WriteLine("Please select one of the following choices,");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        //Read User input
        string stringUserInput = Console.ReadLine();
        //Convert to int
        int UserInput = int.Parse(stringUserInput);
        //Return to Main
        return(UserInput);
    }

    //CreateNewJournal function
    static void CreateNewJournal()
    {
        //In theory, when a new Journal is created
        //the code inside of the Public Journal(){} will 
        //Run regardless if I do anything special to it.
        Journal newJournal = new Journal();
        string newEntry = newJournal.CreateEntry();

        _entries.Add(newEntry);
    }

    static void Main(string[] args)
    {   
        //Write welcome message
        Console.WriteLine("Welcome to the Journal Program!");
        //While Loop to keep you inside the guts of the program
        int UserInput = 0;
        //Test Create a varible that will change name every loop.

        while (UserInput != 5)
        {
            //This is to call the menu
            UserInput = MenuSelect();

            //Use if/if else statements to see which option was selected
            //Write a show the user a prompt and allow them to write a response
            if (UserInput == 1)
            {
                CreateNewJournal();
            }
            //Display the journal - Iterate through all entries in the 
            //journal and display them to the screen
            else if (UserInput == 2)
            {
                foreach (string entry in _entries){
                    Console.WriteLine($"{entry}");
                }
            }
            //Load the journal from a file - Prompt the user 
            //for a filename and then load the journal (a complete
            //list of entries) from that file. This should replace
            //any entries currently stored the journal.
            else if (UserInput == 3)
            {
                //Add a feature that makes it so you do not
                //Need to retype the filename if you are
                //using the same file.
                if (FileLocation != "")
                {
                    Console.WriteLine("Would you like to use the same file? (y/n)");
                    string sameFileAnswer = Console.ReadLine();

                    //Make lower so if they put a capitle Y it still works
                    string lowerSameFile = sameFileAnswer.ToLower();

                    if (lowerSameFile == "y")
                    {
                        LoadFile();
                    }
                    else
                    {
                        Console.WriteLine("What is the filename you want to load? (Exmple.txt)");
                        FileLocation = Console.ReadLine();
                        LoadFile();
                    }
                }
                
                else if (FileLocation == "")
                {
                Console.WriteLine("What is the filename you want to load? (Exmple.txt)");
                FileLocation = Console.ReadLine();
                LoadFile();
                }
            }
            //Save the journal to a file - Prompt the user for a 
            //filename and then save the current journal (the complete 
            //list of entries) to that file location.
            else if (UserInput == 4)
            {
                //Add a feature that makes it so you do not
                //Need to retype the filename if you are
                //using the same file.
                if (FileLocation != "")
                {
                    Console.WriteLine("Would you like to use the same file? (y/n)");
                    string sameFileAnswer = Console.ReadLine();

                    //Make lower so if they put a capitle Y it still works
                    string lowerSameFile = sameFileAnswer.ToLower();

                    if (lowerSameFile == "y")
                    {
                        SaveFile();
                    }
                    else
                    {
                        Console.WriteLine("What is the filename to save to? (Exmple.txt)");
                        FileLocation = Console.ReadLine();
                        SaveFile();
                    }
                }

                else if (FileLocation == "")
                {
                Console.WriteLine("What is the filename to save to? (Exmple.txt)");
                FileLocation = Console.ReadLine();
                SaveFile();
                }
            }

             else if (UserInput == 5)
            {
                Console.WriteLine("Thanks for Using this App today! Have a nice day!");
            }
            //If answer was not valid loop back through.
            else
            {
              Console.WriteLine("That was not a valid answer, Please try again");
            }
        }
        
        //Program Quit code goes here

    }
}