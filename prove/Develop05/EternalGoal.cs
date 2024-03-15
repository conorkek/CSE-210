public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, int points, bool isComplete): base (name, description, points, isComplete)
    {}

    // PUBLIC OVERRIDE RecordEvent()
    //      PUT message
    //      RETURN _points
    // END
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have been awarded {_points} for working on your eternal goal!");
        
        return _points;
    }
}