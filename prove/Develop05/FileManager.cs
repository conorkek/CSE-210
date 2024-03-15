
public class FileManager
{
    public static void Save(List<Goal> goals, int score, string file)
    {
        using(StreamWriter writer = new(file))
        {
            writer.WriteLine(score);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
    }

    public static Tuple<List<Goal>, int> Load(string file)
    {
        List<Goal> goals = new();
        int score = 0;
        using(StreamReader reader = new(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Goal goal = null;
                string[] parts = line.Split("|");
                switch(parts[0])
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), false);
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                        break;
                    default:
                        score = int.Parse(parts[0]);
                        break;
                }
                if (goal != null)
                    goals.Add(goal);
            }
        }

        return new Tuple<List<Goal>, int>(goals, score);
    }      
}