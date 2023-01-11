using System;

class Program
{
    static void Main(string[] args)
    {   //Create the List
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        
        //While loop to insert numbers
        while (number != 0){
            Console.WriteLine("Enter a number: ");
            string strNum = Console.ReadLine();
            number = int.Parse(strNum);
            if (number != 0){
                numbers.Add(number);
            }
        }
        int sum = 0;
        float len = 0;
        int largNum = 0;
        int smallNum = 999999999;
        //Add the numbers in the list to obtain the sum and the length of the list.
        //Also have this find the largest number.
        foreach (int num in numbers){
            sum = sum + num;
            len += 1;
            if (largNum < num){
                largNum = num;
            }
        }

        foreach (int num in numbers){
              if (num < smallNum && num > 0){
                smallNum = num;
              }
        }
        // Calculate the Average
        float ave = sum / len;
        //Print the sum, ave, and largNum.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {largNum}");
        Console.WriteLine($"The smallest number is: {smallNum}");

        //sort the list
        numbers.Sort();
        Console.WriteLine($"Here is the sorted list: ");
        foreach (int num in numbers){
            Console.WriteLine(num);
        }
    }
}