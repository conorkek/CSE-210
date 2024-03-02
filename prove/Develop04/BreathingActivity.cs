public class BreathingActivity: Activity
{
    private const int _inhaleTime = 4;
    private const int _exhaleTime = 6;

    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        StartingMessage();
    }

    public void RunBreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime activityLength = startTime.AddSeconds(_duration);
        while (startTime < activityLength)
        {
            Console.WriteLine("\n\n");
            Console.Write("Breathe in...");
            CountdownTimer(_inhaleTime);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            CountdownTimer(_exhaleTime);

            
            startTime = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine();
        EndingMessage();
        Console.Clear();
    }
}