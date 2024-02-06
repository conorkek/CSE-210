using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new();
        string userInput = "";

        while (true)
        {
            // have welcome menu with options
            Console.WriteLine("Welcome to your personal Journal!");
            Console.WriteLine("Please select one of the following choices");
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
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            // Use a SWITCH and CASE statment to handle the users input

           switch(userInput)
           {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayAllEntries();
                    break;
                case "3":
                    Console.Write("Enter the filename: ");
                    string filename = Console.ReadLine();
                    journal.Save(filename);
                    break;
                case "4":
                    Console.Write("Enter the filename: ");
                    filename = Console.ReadLine();
                    journal.Load(filename);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
           }
        }
    }
} 