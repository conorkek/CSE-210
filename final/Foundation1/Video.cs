using System.Runtime.CompilerServices;
using System.Security.Principal;

public class Video
{
    public string _title;
    public string _author; 
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public int GetCommentCount()
    {   // Count the number of comments in the list

        int count = _comments.Count();

        return count;
    }
    public void AddComment(string name, string text)
    {
        Comment comment = new(name, text);
        _comments.Add(comment);
    }
    public void DisplayComments()
    {
        foreach(Comment comment in _comments)
        {
            comment.Display();
        }
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds");
    }
}