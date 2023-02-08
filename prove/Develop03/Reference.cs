using System;

class Reference
{

    //Attributes
    private string _ref;

    //Constructors
    //Assign the value of _ref, and get it ready to be displayed
    public Reference(string Ref)
    {
        _ref = Ref;

        //Display the starting product
        Display();
    }

    //Methods
    //Display _ref

    public void Display()
    {
        Console.Write($"{_ref} ");
    }
}