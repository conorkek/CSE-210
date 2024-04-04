using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new()
        {
            new Running("4-1-2024", 60, 1),
            new Cycling("4-2-2024", 60, 60),
            new Swimming("4-3-2024", 60, 20)
        };

        foreach (Activity x in activities)
        {
            x.GetSummary();
        }
    }
}