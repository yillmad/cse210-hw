public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this._rsvpEmail = rsvpEmail;
    }

    // Override method to generate full details message
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP Email: {_rsvpEmail}";
    }
}