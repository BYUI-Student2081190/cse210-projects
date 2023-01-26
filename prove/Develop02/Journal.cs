using System;

public class Journal
{
    //Lists used in the Journal Class
    public List<string> _prompts = new List<string>();

    //Functions used in the Journal Class
    //Send a random prompt back to the user.
    public Journal()
    {
        //All this will get exicuted when we make a new object.
        _prompts.Add("If you could relive a moment today, how would you react differently?");
        _prompts.Add("What made you smile the most today?");
        _prompts.Add("What was the funniest thing that happened today?");
        _prompts.Add("How can you be better tomorrow?");
        _prompts.Add("What was something new you tried today?");
        _prompts.Add("Where was the best place you went to today?");
        _prompts.Add("What moment today left you siging a sigh of relef?");
        _prompts.Add("When did you do something kind for someone today?");
        _prompts.Add("What was something you loved about today?");
        _prompts.Add("What motivated you to do all that you did today?");

    }

    public string SendPrompt()
    {
        Random generator = new Random();
        int number = generator.Next(1, 10);

        string prompt = _prompts.ElementAt(number);

        return(prompt);
    }

    

    public string CreateEntry()
    {
        string prompt = SendPrompt();

        Entry parts = new Entry();
        parts.prompt = prompt;
        parts.Prompt();
        parts.GetResponse();
        parts.GenerateDate();
        string completeEntry = parts.Display();

        return(completeEntry);
    }
}