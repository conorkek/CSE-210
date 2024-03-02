using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            
            Console.WriteLine("2. Start Reflecting Activity");
          
            Console.WriteLine("3. Start Listing Activity");
            
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            // Use a SWITCH and CASE statment to handle the users input

           switch(userInput)
           {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.RunReflectingActivity();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
           }
        }
    }
}