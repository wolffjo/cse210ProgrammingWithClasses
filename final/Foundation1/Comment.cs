public class Comment
{
    public string _name;
    public string _commentText;

    public void Display()
    {
        Console.WriteLine($"{_name}: {_commentText}");
    }

    public Comment(string name, string text)
    {
        _name = name;
        _commentText = text;
    }
}