using System;
using System.Runtime.CompilerServices;
using System.IO;

public class Journal
{
    // ATTRIBUTES (Class Variable) (Fields) (State)
    // list _entries (Its a List of Entry)
    public List<Entry> _entries = new();
    public PromptGenerator pgen = new();
    public QuoteGenerator qgen = new();
    
    // METHODS

    // AddEntry()
    public void AddEntry()
    {
        Entry entry = new();
        entry._date = DateTime.Now.ToShortDateString();
        entry._quote = qgen.GetRandomQuote();
        entry._prompt = pgen.GetRandomPrompt();
        Console.WriteLine(entry._quote);
        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();
        _entries.Add(entry);
    }

    // DisplayAllEntryies()

    public void DisplayAllEntries()
    {
        // Loop to iterate through _entries
        // Display entries using the display function from entry.
        System.Console.WriteLine("All Entries:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }

    // Save()

    public void Save(string fileName)
    {
        // Don't forget to put this at the top, so C# knows where to find the StreamWriter class

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // TODO
            // Iterate(Loop) through _entries and save the Date | Prompt | Response in order you prefer.
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._quote}|{entry._prompt}|{entry._response}");
            }
        }
    }

    // Load()

    public void Load(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string quote = parts[1];
            string prompt = parts[2];
            string response = parts[3];


            Entry entry = new();
            entry._date = date;
            entry._quote = quote;
            entry._prompt = prompt;
            entry._response = response;
            _entries.Add(entry);
        }
    }
} 