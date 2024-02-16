using System;

class Program
{
    static void Main(string[] args)
    {
        // # Add some unique logic that initializes a new Scripture object. This
        // # can be done through many different ways. Some examples are: prompt
        // # the user to input the scripture text and reference information, use
        // # a preset collection of scripture and reference data and select a 
        // # random one to use, or display several available scriptures for the
        // # user to choose from.

        //string scripture_text = "And it came to pass..";
        //Scripture scripture = new Scripture(scripture_text, new Reference("Book", "Chapter", "Verse"));

        List<Scripture> scriptures = ScriptureLoad.Load("Scriptures.txt");
        for(int i = 0; i < scriptures.Count; i++)
        {
            Console.Write($"{i + 1}) ");
            scriptures[i].DisplayScripture();
            Console.WriteLine("\n");
        }
        Console.WriteLine("\n");
        Console.Write("Which scripture would you like to memorize? ");
        int choice = int.Parse(Console.ReadLine());
        Scripture scripture = scriptures[ choice - 1 ];



        // # OR
        // --  "ex Book", "ex Chapter", "ex Verse", "ex EndVerse"))
        // # Remember that a Reference object can be constructed with either three
        // # or four parameters.
        Console.Write("How many words at a time do you want hide? ");
        int hideCount = int.Parse(Console.ReadLine());
        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.Write("\n\nPress enter or type 'quit' to exit: ");
            string input = Console.ReadLine();
            if (input == "quit")
                break;
            if (scripture.WordsHidden())
                break;
            scripture.HideRandomWords( hideCount );
            // # Above we are hard coding the amount of words to hide each time.
            // # It would be better to add some logic before the main loop starts
            // # that will get the amount of words to hide at a time from the
            // # user.
        }
    }
}