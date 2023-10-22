public class Reference
{
    private string _name = "Helaman";
    private int _chapter = 5;
    private int _startVerse = 12;
    private int _endVerse = 12;

    public void Display()
    {
        Console.WriteLine($"{_name} {_chapter}:{_endVerse}");
    }
}