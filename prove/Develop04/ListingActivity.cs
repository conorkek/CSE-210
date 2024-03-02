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

        string response = Console.ReadLine();
        DateTime startTime = DateTime.Now;
        DateTime activityLength = startTime.AddSeconds(_duration);
        while (startTime < activityLength)
        {
            _response.Add(response);

            response = Console.ReadLine();
            startTime = DateTime.Now;
        }
    }

    public void DisplayListLength()
    {
        Console.WriteLine($"You listed {GetListLength()} items!");
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: \b");
        Console.WriteLine(" --- " + GetRandomPrompt() + " --- " + "\b");
        Console.Write("You may begin in: ");
        CountdownTimer(_duration);
    }

    public void RunListingActivity()
    {
        DisplayPrompt();
        GetResponse();
        Console.WriteLine();
        DisplayListLength();
        Console.WriteLine();
        EndingMessage();
    }
}