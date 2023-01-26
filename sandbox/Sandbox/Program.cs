using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        int number = 1;

        List<int> numbers = new List<int>();

        numbers.Add(number);

        number = 5;

        numbers.Add(number);

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

    }
}