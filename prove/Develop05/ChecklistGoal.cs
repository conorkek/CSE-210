public class ChecklistGoal : Goal
{
    // _target
    // _bonus
    // _current
    private int _target;
    private int _bonus;
    private int _current;

    // PUBLIC ChecklistGoal( name, description, points, isComplete, target, bonus, current) : BASE(...)
    //      _target -> target
    //      _bonus -> bonus
    //      _current -> current
    // END
    public ChecklistGoal(string name, string description, int points, bool isComplete, int target, int bonus, int current): base (name, description, points, isComplete)
    {
        _target = target;
        _bonus = bonus;
        _current = current;
    }

    // PUBLIC OVERRIDE DisplayGoal()
    //      RETURN BASE.DisplayGoal() + " - [_current/_target]"
    // END
    public override string DisplayGoal()
    {
        return base.DisplayGoal() + $" - [{_current}/{_target}]";
    }
    // PUBLIC OVERRIDE RecordEvent()
    //      PUT "How many times did you complete a session of the Goal?"
    //      _sessionAmount -> GET
    //      _current += _sessionAmount
    //      IF _current >= _target
    //          _isComplete -> TRUE
    //          PUT Message
    //          RETURN (_points * _sessionAmount) + _bonus
    //      ELSE
    //          PUT Message
    //          RETURN _points * _sessionAmount
    public override int RecordEvent()
    {
        Console.WriteLine("How many times did you complete a session of the goal?");
        int _sessionAmount = int.Parse(Console.ReadLine());
        _current += _sessionAmount;
        if (_current >= _target)
        {
            _isComplete = true;
            Console.WriteLine("Congratulations! You completed your goal!");
            return (_points * _sessionAmount) + _bonus;
        }
        else
        {
            Console.WriteLine("Great work! Keeping going, you got this!");
            return _points * _sessionAmount;
        }
    }
    // PUBLIC OVERRIDE GetSaveString()
    //      RETURN BASE.GetSaveString() + "|_isComplete|_target|_bonus|_current"
    // END
    public override string GetSaveString()
    {
        return base.GetSaveString() + $"|{_isComplete}|{_target}|{_bonus}|{_current}";
    }
}