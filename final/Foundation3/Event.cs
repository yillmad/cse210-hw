using System;

// Base class for Event
public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public TimeSpan GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Method to generate standard details message
    public virtual string GetStandardDetails()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address}";
    }

    // Method to generate full details message
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // Method to generate short description message
    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}
