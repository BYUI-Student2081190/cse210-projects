using System;

//Additonal class that holds scriptures and obtains a random one for me to use!

class RandomScript
{
    //Attributes
    private int _number;
    private List<string> _ranRef = new List<string>();
    private List<string> _scriptText = new List<string>();

    //Constructors
    public RandomScript()
    {
        //Add items to the lists

        //references
        //0
        _ranRef.Add("Proverbs 3:5-6");
        //1
        _ranRef.Add("James 1:4-5");
        //2
        _ranRef.Add("Hebrews 11:1");

        //scriptText
        //0
        _scriptText.Add("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        //1
        _scriptText.Add("But let patience have her perfect work, that ye may be perfect and entire, wanting nothing. If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
        //2
        _scriptText.Add("Now faith is the substance of things hoped for, the evidence of things not seen.");
    
        //Call Random Number
        GetRandomNumber();
    }


    //Methods
    //Public
    public string GetReferencePart()
    {
        string refPart = GetScripturePart(_ranRef);

        return(refPart);
    }

    public string GetScriptTextPart()
    {
        string scriptTextPart = GetScripturePart(_scriptText);

        return(scriptTextPart);
    }
    
    //Private
    private void GetRandomNumber()
    {
        Random numGen = new Random();
        _number = numGen.Next(0, 2);
    }

    private string GetScripturePart(List<string> currentList)
    {
        string scriptPart = currentList[_number];

        return(scriptPart);
    }
}