using System;
using System.Collections.Generic;
public class Activity
{
    private DateTime _date;
    protected int _durationInMinutes; // Change access level to protected

    public Activity(DateTime date, int durationInMinutes)
    {
        this._date = date;
        this._durationInMinutes = durationInMinutes;
    }

    // Method to get distance (virtual method, to be overridden in derived classes)
    public virtual double GetDistance()
    {
        return 0; // Default implementation
    }

    // Method to get speed (virtual method, to be overridden in derived classes)
    public virtual double GetSpeed()
    {
        return 0; // Default implementation
    }

    // Method to get pace (virtual method, to be overridden in derived classes)
    public virtual double GetPace()
    {
        return 0; // Default implementation
    }

    // Method to get summary
    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} - {GetType().Name} ({_durationInMinutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}