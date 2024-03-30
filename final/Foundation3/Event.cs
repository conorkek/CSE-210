using System.ComponentModel.Design;
using System.Net.Sockets;

public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {

        return $"Event: {_eventTitle} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address.GetAddressString()}";
    }

    public string ShortDescription()
    {
        return $"{GetType()}: \nEvent Title: {_eventTitle} \nDate: {_date}";
    }


}