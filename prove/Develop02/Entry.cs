using System;

public class Entry
{

    //Variables used in the Entry Class
    public string date;
    public string prompt;
    public string response;

    public string OwnerName;
    public void GetResponse()
    {
        Console.Write(">");
        response = Console.ReadLine();

        //Also get the owner of the entry's name
        Console.WriteLine("Who wrote this?");
        Console.Write(">");
        OwnerName = Console.ReadLine();
    }

    public void GenerateDate()
    {
        DateTime currDate = DateTime.Now;
        string dateStr = currDate.ToShortDateString();
        date = dateStr;
    }

    public void Prompt()
    {
        Console.WriteLine(prompt);
    }

    public string Display()
    {
        string display = ($"Date: {date} - Prompt: {prompt}\n{response}\n{OwnerName}\n");
        return(display);
    }

}