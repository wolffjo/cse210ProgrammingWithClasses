public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;


    public void Display()
    {
        Console.Write($"{_date} ~|~ {_prompt} ~|~ {_response}\n");
    }
}