using System.Security.Cryptography;

public class ReflectingActivity: Activity
{
    private string[] _startingPrompt = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _followUpQuestion = 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

    };

    private List<int> _usedQuestions = new List<int>();

    public Random rng = new();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        StartingMessage();
    }

    public string GetRandomPrompt()
    {
        // Gets a random index between 0 - length prompts 
        int index = rng.Next(_startingPrompt.Length);
        _usedQuestions.Add(index);
        while (_usedQuestions.Contains(index))
        {
            
        }
        
        // Returns a prompt using the index
        return _startingPrompt[index];


    }
    public string GetRandomFollowUpPrompt()
    {
        // Gets a random index between 0 - length prompts 
        int index = rng.Next(_followUpQuestion.Length);

        // Returns a prompt using the index
        return _followUpQuestion[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: \b");
        Console.WriteLine(" --- " + GetRandomPrompt() + " --- " + "\b");
        Console.WriteLine("When you have something in mind, press 'Enter' to continue.");
    }

    public void DisplayFollowUpQuestion()
    {
        Console.WriteLine(GetRandomFollowUpPrompt() + "\b");
        Console.ReadLine();
    }

    public void RunReflectingActivity()
    {
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        DateTime activityLength = startTime.AddSeconds(_duration);
        while (startTime < activityLength)
        {
            DisplayFollowUpQuestion();
            Spinner(_duration);
            startTime = DateTime.Now;
        }
        Console.WriteLine();
        EndingMessage();

    }
}
