public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        this._laps = laps;
    }

    // Override method to calculate distance
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; // Convert meters to miles
    }

    // Override method to calculate speed
    public override double GetSpeed()
    {
        return GetDistance() / (_durationInMinutes / 60.0);
    }

    // Override method to calculate pace
    public override double GetPace()
    {
        return _durationInMinutes / GetDistance();
    }
}