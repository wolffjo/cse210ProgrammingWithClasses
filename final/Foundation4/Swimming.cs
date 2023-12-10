class Swimming : Activity
{
    public double _laps;
    public override double GetDistance()
    {
        double _distance = _laps * 50 / 1000;
        return _distance;
    }

    public override double GetSpeed()
    {
        double _speed = 60 / GetPace();
        return _speed;
    }

    public override double GetPace()
    {
        double _pace = _minutes / GetDistance();
        return _pace;
    }

    public Swimming(int minutes, double laps)
    {
        _laps = laps;
        _minutes = minutes;
        _activityName = "Swimming";
    }
}