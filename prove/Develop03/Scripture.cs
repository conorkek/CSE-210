public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private Random _rng;

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _rng = new Random();
        _words = new List<Word>();
        string[] wordArray = text.Split();
        foreach (string wordString in wordArray)
        {
            Word wordObj = new( wordString );
            _words.Add( wordObj );
        }
    }

    public bool WordsHidden()
    {   
        foreach (Word word in _words)
        {
            if (word.GetHidden() == false)
                return false;
        }
        return true;
    }

    public void DisplayScripture()
    {
        Console.Write(_reference.GetReferenceString() + " - ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }

    }        

    public void HideRandomWords( int numberToHide )
    {
        int counter = 0;
        while (counter < numberToHide && !WordsHidden())
        {
            int index;
            do
            {
                index = _rng.Next( _words.Count );
            }
            while (_words[ index ].GetHidden());
            
            _words[ index ].Hide();
            counter++;
        }   
    }
}