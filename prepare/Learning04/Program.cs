using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuell Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Samuell Bennett", "Multiplication", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Console.WriteLine();

        WrittingAssignment assignment3 = new WrittingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWrittingInformation());
    }
}