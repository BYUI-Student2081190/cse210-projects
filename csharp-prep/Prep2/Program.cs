using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Grade-point Average? ");
        string StrinGrade = Console.ReadLine();
        int grade = int.Parse(StrinGrade);

        string letter = "";

        if (grade >= 90){
             letter = "A";
        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
                else if (grade >= 60){
            letter = "D";
        }
                else if (grade < 60){
            letter = "F";
        }

        Console.WriteLine($"Your grade is a {letter}");

        if (grade > 70){
            Console.WriteLine("Congrats! You are passing the Class!");
        }
        else if (grade < 70){
            Console.WriteLine("Shoot, you are not passing! Keep Trying! You can do it! :)");
        }
    }
}