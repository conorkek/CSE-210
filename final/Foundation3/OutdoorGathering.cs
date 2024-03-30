public class OutdoorGathering : Event
{
    private Weather _goodWeather;

    public OutdoorGathering(string eventTitle, string description, string date, string time, Address address, Weather goodWeather): base(eventTitle, description, date, time, address)
    {
        _goodWeather = goodWeather;
    }

    public string FullDetails()
    {
        return $"{GetType()}: \n{StandardDetails()} \nWeather Conditions: {_goodWeather}";
    }
}

public enum Weather{
    Clear,
    Rain,
    Snow,
    Thunder,
    Overcast
}