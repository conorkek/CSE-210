public class ScriptureLoad
{
    public static List<Scripture> Load(string filename)
    {
        List<Scripture> scriptures = new();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if(parts.Length != 0)
            {
                string book = parts[0];
                string chapter = parts[1];
                string verse = parts[2];
                string text = parts[3];

                if (parts.Length == 5)
                {
                    string endVerse = parts[3];
                    string text2 = parts[4];
                    scriptures.Add(new Scripture(text2, new Reference(book, chapter, verse, endVerse)));
                }
                else
                {
                    scriptures.Add(new Scripture(text, new Reference(book, chapter, verse)));
                }
            }
        }

        return scriptures;
    }
}