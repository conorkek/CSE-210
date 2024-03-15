public class GoalManager
{
    // PRIVATE _goals
    // PRIVATE _score
    private List<Goal> _goals = new();
    private int _score = 0;
    public int Score {get {return _score;}}

    // PUBLIC AddGoal()
    //      PUT "1) Simple
    //          2) Eternal
    //          3) Checklist
    //
    //      input -> GET
    //      PUT "Enter the name: "
    //      name -> GET
    //      PUT "Enter a description: "
    //      description -> GET
    //      PUT "Enter point value: "
    //      points -> GET
    //
    //      SWITCH input
    //          CASE 1
    //              simple -> NEW SimpleGoal( name, description, points)
    public void AddGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        
        Console.Write("Which goal would you like to create? ");
        string input = Console.ReadLine();

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a description for this goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter a point value for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;
        switch(input)
        {
            case "1":
                goal = new SimpleGoal(name, description, points, false);
                break;
            case "2":
                goal = new EternalGoal(name, description, points, false);
                break;
            case "3":
                Console.Write("How many times would you like to complete your goal? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("How many bonus points would like to award yourself for completing this goal? ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, false, target, bonus, 0);
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;

        }
        if (goal != null)
            _goals.Add(goal);
        Console.Clear();
    }
    // PUBIC DisplayGoals()
    //      FOR i FROM 0 TO _goals.COUNT STEP 1
    //          PUT "i+1) " + _goals[i].DisplayGoal()
    // END
    public void DisplayGoals()
    {
        Console.Clear();
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i +1}" + _goals[i].DisplayGoal());
        }

    }
 
    public void RecordGoalEvent()
    {
        Console.Clear();
        List<int> indices = new();

        int counter = 1;
        for(int i = 0; i < _goals.Count; i++)
        {
            if(!_goals[i].IsComplete)
            {
                Console.WriteLine($"{counter}" + _goals[i].DisplayGoal());
                indices.Add(i);
                counter++;
            }
        }

        Console.Write("Select a goal: ");
        int choice = int.Parse(Console.ReadLine());
        int points = _goals[indices[choice - 1]].RecordEvent();
        _score += points;
        Console.Clear();
        Console.WriteLine($"You earned an additional {points} points!");
    }

    public void Save()
    {
        Console.Clear();
        Console.Write("Enter the filename: ");
        string file = Console.ReadLine();
        FileManager.Save(_goals, _score, file);
    }


    public void Load()
    {
        Console.Clear();
        Console.Write("Enter the filename: ");
        string file = Console.ReadLine();
        Tuple<List<Goal>, int> data = FileManager.Load(file);
        _score = data.Item2;
        _goals = data.Item1;
    }
}