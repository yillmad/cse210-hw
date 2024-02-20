public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this._weatherForecast = weatherForecast;
    }

    // Override method to generate full details message
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather Forecast: {_weatherForecast}";
    }
}