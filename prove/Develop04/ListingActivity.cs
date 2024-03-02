public class ListingActivity: Activity
{
    private List<string> _response = new List<string>();
    public Random rng = new();

    private string[] _prompt = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        StartingMessage();
    }

    public string GetRandomPrompt()
    {
        // Gets a random index between 0 - length prompts 
        int index = rng.Next(_prompt.Length);

        // Returns a prompt using the index
        return _prompt[index];
    }
    public int GetListLength()
    {
        // Gets a random index between 0 - length prompts 
        int length = _response.Count;

        // Returns a prompt using the index
        return length;
    }
    public void GetResponse()
    {   
        Console.Write("> ");
        string response = Console.ReadLine();
        _response.Add(response);
        DateTime startTime = DateTime.Now;
        DateTime activityLength = startTime.AddSeconds(_duration);
        while (startTime < activityLength)
        {
            Console.Write("> ");
            response = Console.ReadLine();
            _response.Add(response);
            startTime = DateTime.Now;
        }
    }

    public void DisplayListLength()
    {
        Console.WriteLine($"You listed {GetListLength()} items!");
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" --- " + GetRandomPrompt() + " --- ");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("You may begin in: ");
        CountdownTimer(5);
        Console.WriteLine();
        Console.WriteLine();
    }

    public void RunListingActivity()
    {
        DisplayPrompt();
        GetResponse();
        Console.WriteLine();
        DisplayListLength();
        Console.WriteLine();
        EndingMessage();
        Console.Clear();
    }
}