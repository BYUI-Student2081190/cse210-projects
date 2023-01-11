using System;

class Program
{
    static void Main(string[] args)
    {
        //Functions
        static void DisplayMessage(){
           Console.WriteLine("Welcome to the Program!");
        }

        static String PromptUserName(){
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber(){
            Console.WriteLine("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int favNumber = int.Parse(number);
            return favNumber;

        }

        static int SquareNumber(int number1){
            int square = number1 * number1;
            return square;
        }

        static void DisplayResult(String name, int square){
             Console.WriteLine($"{name}, the square of your number is {square}.");
        }

        //Call functions
        DisplayMessage();
        String userName = PromptUserName();
        int favnumber = PromptUserNumber();
        int numSquare = SquareNumber(favnumber);
        DisplayResult(userName, numSquare);
    }
}