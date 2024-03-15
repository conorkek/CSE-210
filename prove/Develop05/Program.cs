using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new();
        string userInput = "";
        
        Console.Clear();
        while(true)
        {
            Console.WriteLine($"You have {goalManager.Score} points.\n");
            
            Console.WriteLine("Please select one of the following choices");
            // PUT Add Entry
            Console.WriteLine("  1. Create New Goal");
            // PUT Display Entries
            Console.WriteLine("  2. List Goals");
            // PUT Save
            Console.WriteLine("  3. Save Goals");
            // PUT Load
            Console.WriteLine("  4. Load Goals");
            // PUT Record Event
            Console.WriteLine("  5. Record Event");
            // PUT Quit
            Console.WriteLine("  6. Quit");
            // choice = GET
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();
            
            
            switch(userInput)
            {
                case "1":
                    goalManager.AddGoal();
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    goalManager.Save();
                    break;
                case "4":
                    goalManager.Load();
                    break;
                case "5":
                    goalManager.RecordGoalEvent();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;    
            }
        }
        
    }
}