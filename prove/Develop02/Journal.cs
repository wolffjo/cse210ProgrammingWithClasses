public class Journal
{
    
    public List<Entry> _entries = new List<Entry>();

    public void SaveEntries(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            foreach(Entry item in _entries)
            {
                sw.WriteLine($"{item._date}~|~{item._prompt}~|~{item._response}");
            }
        }
    }

    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }
}