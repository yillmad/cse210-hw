public class Running : Activity
{
    private double _distanceInMiles;

    public Running(DateTime date, int durationInMinutes, double distanceInMiles)
        : base(date, durationInMinutes)
    {
        this._distanceInMiles = distanceInMiles;
    }

    // Override method to calculate distance
    public override double GetDistance()
    {
        return _distanceInMiles;
    }

    // Override method to calculate speed
    public override double GetSpeed()
    {
        return _distanceInMiles / (_durationInMinutes / 60.0);
    }

    // Override method to calculate pace
    public override double GetPace()
    {
        return _durationInMinutes / _distanceInMiles;
    }
}