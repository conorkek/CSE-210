using System;

public class Entry
{
    // ATTRIBUTES
    // date (DATETIME)
    public DateTime _date;

    // prompt (string)
    public string _prompt;

    // response (string)
    public string _response;

    // METHODS

    // Display()
    public void Display()
    {
        //  PUT date
        Console.WriteLine($"Date: {_date.ToShortDateString()}");

        //  PUT prompt
        Console.WriteLine($"Prompt: {_prompt}");

        //  PUT Response
        Console.WriteLine(_response);
    }
}