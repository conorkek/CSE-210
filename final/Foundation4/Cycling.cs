public class Cycling: Activity
{
    private double _speed;

    public Cycling(string date, double durationInMinutes, double speed): base(date, durationInMinutes)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * _durationInMinutes / 60;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }
}