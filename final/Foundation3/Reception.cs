public class Reception : Event
{
    private string _rsvp;

    public Reception(string eventTitle, string description, string date, string time, Address address, string rsvp): base(eventTitle, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public string FullDetails()
    {
        return $"{GetType()}: \n{StandardDetails()} \nRSVP: {_rsvp}";
    }
}