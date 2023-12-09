class Reception : Event
{
    private string _coming;

    public void Run()
    {
        FullDetails1();
        Console.WriteLine($"RSVP: {_coming}");
        FullDetails2();
    }

    public Reception(string eventTitle, string description, string date, string time, string coming, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _coming = coming;
        _address = address;
        _eventType = "Reception";
    }
}