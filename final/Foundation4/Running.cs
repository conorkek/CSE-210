public class Running : Activity
{
    private double _distance;

    public Running(string date, double durationInMinutes, double distance): base(date, durationInMinutes)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / _durationInMinutes * 60;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}