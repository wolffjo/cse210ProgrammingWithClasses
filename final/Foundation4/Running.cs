class Running : Activity
{
    private double _distance;
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double _speed = 60 / GetPace();
        return _speed;
    }

    public override double GetPace()
    {
        double _pace = _minutes / _distance;
        return _pace;
    }

    public Running(int minutes, double distance)
    {
        _distance = distance;
        _minutes = minutes;
        _activityName = "Running";
    }
}