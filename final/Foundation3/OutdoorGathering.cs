class OutdoorGathering : Event
{
    private string _weather;

    public void Run()
    {
        FullDetails1();
        Console.WriteLine($"Weather: {_weather}");
        FullDetails2();
    }

    public OutdoorGathering(string eventTitle, string description, string date, string time, string weather, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _weather = weather;
        _address = address;
        _eventType = "Outdoor Gathering";
    }
}