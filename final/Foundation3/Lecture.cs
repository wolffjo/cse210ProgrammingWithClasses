using System.Diagnostics.Contracts;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public void Run()
    {
        FullDetails1();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        FullDetails2();
    }

    public Lecture(string eventTitle, string description, string date, string time, string speaker, int capacity, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _speaker = speaker;
        _capacity = capacity;
        _address = address;
        _eventType = "Lecture";
    }
}