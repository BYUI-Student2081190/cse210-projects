using System;

class Program
{
    //Attributes Member Variables
    static string fileLocation = "activity_log.txt";
    static BreathingActivity bAct = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", new List<string>{""}, 0, fileLocation);
    static ReflectingActivity rAct = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you reconize the power you have and how you can use it in other aspects of your life.", new List<string>{"Think of a time where you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time where you helped someone in need.", "Think of a time when you did something truly selfless."}, 0, fileLocation);
    static ListingActivity lAct = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"}, 0, fileLocation);

    //Constructors none

    //Methods
    static void Main(string[] args)
    { 
        //Call to start the program
        UiLoop();
    }

    static void UiLoop()
    {
        //bool value to test if you still loop
        bool loop = true;

        //Create menu inside loop
        while (loop == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. View History");
            Console.WriteLine("5. Quit");
            //Input
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            //Send input off to be processed to see if we can loop again
            loop = GetInput(input);
        }
    }

    static bool GetInput(string input)
        {
            //Test to see if the input is reconized
            if (input == "1")
            {
                //Clear Console
                Console.Clear();

                //Run Activity
                bAct.Run();

                //Return
                return (true); 
            }

            else if (input == "2")
            {
                //Clear Console
                Console.Clear();

                //Run Activity
                rAct.Run();

                //Return
                return (true);
            }

            else if (input == "3")
            {
                //Clear Console
                Console.Clear();

                //Run Activity
                lAct.Run();

                //Return
                return (true);
            }

            else if (input == "4")
            {
                //Clear Console
                Console.Clear();

                //View the File info
                DisplayFileInfo();

                //Return
                return (true);
            }

            else
            {
                return (false);
            }
        }

        static void DisplayFileInfo()
        {
            string[] history = System.IO.File.ReadAllLines(fileLocation);
            Console.WriteLine("Here are all your past entries:");
            Console.WriteLine();

            foreach (string line in history)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the Menu: ");
            Console.ReadLine();
        }
}