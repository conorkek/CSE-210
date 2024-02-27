public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private char[] _spinners = 
    {
        '/', '-', '\\', '|'
    };
    
    protected void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}. \n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.Write("Get ready... ");
        Spinner(5);
    }
    protected void EndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");

        Spinner(5);
    }
    
    protected void Spinner(int duration)
    {
        for(int _ = duration; _ > 0; _--)
        {
            foreach (char symbol in _spinners)
            {
                Console.Write(symbol);
                Thread.Sleep(250);
                Console.Write("\b \b");
            } 
        }
    }

    protected void CountdownTimer(int duration)
    {
        for(int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}