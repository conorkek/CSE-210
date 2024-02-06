public class PromptGenerator
{
    // ATTRIBUTES
    public List<string> _prompts = new()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the yummiest food you ate today?",
        "Did you exercise today?",
        "What was your greatest accomplishment today?",
        "Did you drink enough water today?",
        "How did your mood change throughout the day, if at all?",
        "What was the highlight of your day?"
    };

    
    public Random rng = new();

    // METHOD
    public string GetRandomPrompt()
    {
        // Gets a random index between 0 - length prompts 
        int index = rng.Next(_prompts.Count);

        // Returns a prompt using the index
        return _prompts[index];
    }
} 

