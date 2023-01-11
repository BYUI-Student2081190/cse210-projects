using System;

class Program
{
    static void Main(string[] args)
    {
        String playAgain = ("yes");
        while (playAgain == "yes"){
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1,100);

            Console.WriteLine("Try to guess the Magic Number!");
            Console.WriteLine(" ");

            String repeat = ("yes");
            int guessCount = 0;

            while (repeat == "yes"){

                guessCount = guessCount + 1;

                Console.WriteLine("What is your guess? ");
                String guessNumString = Console.ReadLine();

                int guessNum = int.Parse(guessNumString);

                if (magicNum > guessNum) {
                    Console.WriteLine("Higher.");
                }

                else if (magicNum < guessNum) {
                    Console.WriteLine("Lower.");
                }

                else if (magicNum == guessNum) {
                    Console.WriteLine("Bingo!");
                    Console.WriteLine(" ");
                    Console.WriteLine($"It took you {guessCount} guesses to get the Magic Number!");
                    repeat = ("no");
                }
            }

            Console.WriteLine("Would you like to play again?(yes / no) ");
            String playAgainAns = Console.ReadLine();

            if (playAgainAns == "yes"){
                playAgain = ("yes");
            }

            else {
                playAgain = ("no");
                Console.WriteLine("Ok, Thanks for Playing! :)");
            }
       }
    }
}