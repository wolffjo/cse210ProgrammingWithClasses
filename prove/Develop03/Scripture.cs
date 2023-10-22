using System.ComponentModel.DataAnnotations;

class Scripture
{
    Random random = new Random();
    Reference reference = new Reference();
    private List<Word> _scripture = new List<Word>();

    //private Reference _reference;

    public Scripture(string inputScripture)
    {
        string[] words = inputScripture.Split(" ");
        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _scripture.Add(wordObj);
        }
    }
    public void Display()
    {
        reference.Display();
        foreach(Word word in _scripture)
        {
            word.Display();
        }
    } 
    public void Hide()
    {
        int indexPos = random.Next(0, _scripture.Count);
        Word word = _scripture[indexPos];
        word.Hide();   
    }
    public void DisplayReference()
    {
        reference.Display();
    }
}