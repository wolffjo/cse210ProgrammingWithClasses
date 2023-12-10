using System.Diagnostics.Contracts;

class Cycling : Activity
{
    private double _speed;

    public override double GetDistance()
    {
        double _distance = _speed * _minutes / 60;
        return _distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double _pace = 60 / GetSpeed();
        return _pace;
    }

    public Cycling(int minutes, double speed)
    {
        _speed = speed;
        _minutes = minutes;
        _activityName = "Cycling";
    }
}