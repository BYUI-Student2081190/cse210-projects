using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("");

        Console.WriteLine("What is your First Name? ");
        string FirstName = Console.ReadLine();

        Console.WriteLine("What is your Last Name? ");
        string LastName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }

}