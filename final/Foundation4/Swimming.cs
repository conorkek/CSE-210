public class Swimming: Activity
{
    private double _numOfLaps;

    public Swimming(string date, double durationInMinutes, double numOfLaps): base(date, durationInMinutes)
    {
        _numOfLaps = numOfLaps;
    }

    public override double CalculateDistance()
    {
        return _numOfLaps * 50 / 1000;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / _durationInMinutes * 60;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}