public class GoalManager
{
    // PRIVATE _goals
    // PRIVATE _score
    private string _goals;
    private int _score;

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
        Console.WriteLine("1) Simple Goal");
        Console.WriteLine("2) Eternal Goal");
        Console.WriteLine("3) Checklist Goal");
        
        Console.Write("Which goal would you like to create? ");
        string input = Console.ReadLine();
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a description for this goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter a point value for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch(input)
        {
            case "1":
                SimpleGoal simple = new SimpleGoal(name, description, points, false);
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(name, description, points, false);
                break;
            case "3":
                Console.Write("How many times would you lie to complete your goal? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("How many points would like to award yourself for completing this goal? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, false, target, bonus, 0);
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;

        }
    }
    // PUBIC DisplayGoals()

    // PUBLIC RecordGoalEvent()

    // PUBLIC SaveGoals()

    // PUBLIC LoadGoals()
}