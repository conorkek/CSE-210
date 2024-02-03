using System;
using System.Runtime.CompilerServices;
using System.IO;

public class Journal
{
    // ATTRIBUTES (Class Variable) (Fields) (State)
    // list _entries (Its a List of Entry)
    public List<Entry> _entries = new();
    public PromptGenerator pgen = new();
    
    // METHODS

    // AddEntry()
    public void AddEntry()
    {
        Entry entry = new();
        entry._date = DateTime.Now;
        entry._prompt = pgen.GetRandomPrompt();
        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();
        _entries.Add(entry);
    }

    // DisplayAllEntryies()

    public void DisplayAllEntries()
    {
        // Loop to iterate through _entries
        // Display entries using the display function from entry.
        System.Console.WriteLine("ALL Entries:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    // Save()

    public void Save()
    {
        // Don't forget to put this at the top, so C# knows where to find the StreamWriter class

        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // TODO
            // Iterate(Loop) through _entries and save the Date | Prompt | Response in order you prefer.
            foreach (Entry entry in _entries)
            {
                
            }

            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }

    // Load()

    public void Load()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
} 