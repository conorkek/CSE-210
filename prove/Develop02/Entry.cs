using System;

public class Entry
{
    // ATTRIBUTES
    // date (DATETIME)
    public string _date;

    // quote (string)
    public string _quote;

    // prompt (string)
    public string _prompt;

    // response (string)
    public string _response;

    // METHODS

    // Display()
    public void Display()
    {
        //  PUT date
        Console.WriteLine($"Date: {_date}");

        Console.WriteLine($"Quote of the Day: {_quote}");

        //  PUT prompt
        Console.WriteLine($"Prompt: {_prompt}");

        //  PUT Response
        Console.WriteLine(_response);
    }
}