public abstract class Activity
{
    protected string _date;
    protected double _durationInMinutes;

    public Activity(string date, double durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();    

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {GetType()} ({_durationInMinutes} min) - Distance: {CalculateDistance()} kilometers, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per kilometer");
    }
}