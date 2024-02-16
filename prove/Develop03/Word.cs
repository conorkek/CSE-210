using System.Dynamic;

public class Word
{
    private string _word;
    private bool _hidden;
    private string _hiddenWord;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
        
        foreach (char letter in _word)
        {
            _hiddenWord += "_";
        }
    }

    public string GetWord()
    {
        if (_hidden)
            return _hiddenWord;
        
        else
            return _word;
    }

    public bool GetHidden()
    {
        return _hidden;
    }

    public void Hide()
    {
        _hidden = true;
    }
}