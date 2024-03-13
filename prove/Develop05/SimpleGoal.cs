public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete): base (name, description, points, isComplete)
    {}

    // PUBLIC OVERRIDE RecordEvent()
    //      _isCompelte -> TRUE
    //      PUT message
    //      RETURN _points
    // END
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine("Congratulations, you completed your goal!");
        return _points;
    }

    // PUBLIC OVERRIDE GetSaveString()
    //      RETURN BASE.GetSaveString() + "|_isComplete"
    // END
    public override string GetSaveString()
    {
        return base.GetSaveString() + $"|{_isComplete}";
    }
}