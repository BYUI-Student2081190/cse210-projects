using System;

class Scripture
{
    
    //Attributes
    private Reference _reference;
    private Word _text;

    //Constructors
    //This constructor is going to be making the list and preparing the
    //object to be able to have it's words sorted through.
    public Scripture(string newReference, string fullText)
    {
        //When object is created we need to create a reference object to display the scripture
        // Call the Getters and Setters

        SetReference(newReference);

        //Split up the string
        
        StringToWords(fullText);

    }

    //Methods inside of Class
    private void SetReference(string reference)
    {
        _reference = new Reference(reference);
    }

    private void StringToWords(string fullText)
    {
        //Make a split list of the text
        List<string> wordList = fullText.Split(" ").ToList();

        //Call the setter for _text
        SetWords(wordList);
    }

    private void SetWords(List<string> words)
    {
        //Set _text to this list
        _text = new Word(words);
    }

    //Get the list for main
    public List<string> GetWords()
    {
        List<string> list = _text.GetList();

        return(list);
    }

    //Set the List inside of Word
    public void SetWordsList()
    {
        _text.ReplaceWord();
    }

    //Display the results
    public void Display()
    {
        //Call Reference's display function
        _reference.Display();

        _text.Display();
    }
}