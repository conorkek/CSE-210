using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new();
        PromptGenerator pgen = new();
        string userInput = "";

        while (userInput != "5")
        {
            // have welcome menu with options
            Console.WriteLine("Welcome to your personal Journal!");
            Console.WriteLine("Please select one of the following choicse");
            // PUT Add Entry
            Console.WriteLine("1. Entry");
            // PUT Display Entries
            Console.WriteLine("2. Display Entries");
            // PUT Save
            Console.WriteLine("3. Save");
            // PUT Load
            Console.WriteLine("4. Load");
            // PUT Quit
            Console.WriteLine("5. Quit");
            // choice = GET
            Console.Write("What would you like to do?" );
            userInput = Console.ReadLine();

            // Use a SWITCH and CASE statment to handle the users input

            if (userInput == "1")
            {
                pgen.GetRandomPrompt();
                journal.AddEntry();
            }

            else if (userInput == "2")
            {
                journal.DisplayAllEntries();
            }

            else if (userInput == "3")
            {
                
            }

            else if (userInput == "4")
            {
                
            }
        
        }
    }
} 