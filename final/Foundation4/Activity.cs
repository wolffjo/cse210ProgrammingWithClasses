abstract class Activity
{
    protected double _minutes;
    public string _activityName;

    public void Display()
    {
        
    }

    public void GetSummary()
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine($"{dt.Day} {dt.ToString("MMM")} {dt.Year} {_activityName} ({_minutes} min)- Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }

    public abstract double GetSpeed();

    public abstract double GetDistance();

    public abstract double GetPace();
}