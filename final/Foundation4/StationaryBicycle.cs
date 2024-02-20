public class StationaryBicycles : Activity
{
    private double _speedInMilesPerHour;

    public StationaryBicycles(DateTime date, int durationInMinutes, double speedInMilesPerHour)
        : base(date, durationInMinutes)
    {
        this._speedInMilesPerHour = speedInMilesPerHour;
    }

    // Override method to calculate speed
    public override double GetSpeed()
    {
        return _speedInMilesPerHour;
    }

    // Override method to calculate pace
    public override double GetPace()
    {
        return 60.0 / _speedInMilesPerHour;
    }
}