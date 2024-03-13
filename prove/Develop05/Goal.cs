using System.Diagnostics.Contracts;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;

    }

    // PUBLIC ABSTRACT RecordEvent() END
    public abstract int RecordEvent();

    // PUBLIC VIRTUAL DisplayGoal()
    //      RETURN "[ _isComplete ? 'X' : ' ' ] _name : _description"
    // END
    public virtual string DisplayGoal()
    {
        return $"[{_isComplete} ? 'X' : ' '] {_name} : {_description}";
    }

    // PUBLIC VIRTUAL GetSaveString()
    //      RETURN "THIS.GetType()|_name|_description|_points"
    // END

    public virtual string GetSaveString()
    {
        return $"{this.GetType()}|{_name}|{_description}|{_points}";
    }
}

// TERNARY OPERATOR
// CONDITION ? TRUE_EXPRESSION : FALSE_EXPRESSION

