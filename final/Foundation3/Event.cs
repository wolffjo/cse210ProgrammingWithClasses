class Event
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public void StandardDetails()
    {
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_description);
        Console.WriteLine($"{_date}, {_time}");
        string address = _address.HomeAddress();
        Console.WriteLine(address);
    }

    protected void FullDetails1() //I know there might be another solution vs. splitting it up, but this is what I could come up with
    {
        Console.WriteLine(_eventType);
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_description);
    }

    protected void FullDetails2()
    {
        Console.WriteLine($"{_date}, {_time}");
        string address = _address.HomeAddress();
        Console.WriteLine(address);
    }

    public void ShortDetails()
    {
        Console.WriteLine(_eventType);
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_date);
    }
}