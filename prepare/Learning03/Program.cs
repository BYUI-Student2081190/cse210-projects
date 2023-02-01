using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionOne = new Fraction();
        Console.WriteLine(fractionOne.getFractionString());
        Console.WriteLine(fractionOne.getDecimalValue());

        Fraction fractionTwo = new Fraction(6);
        Console.WriteLine(fractionTwo.getFractionString());
        Console.WriteLine(fractionTwo.getDecimalValue());

        Fraction fractionThree = new Fraction(6, 7);
        Console.WriteLine(fractionThree.getFractionString());
        Console.WriteLine(fractionThree.getDecimalValue());
    }
}