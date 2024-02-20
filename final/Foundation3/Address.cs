public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateOrProvince = stateOrProvince;
        this._country = country;
    }

    public override string ToString()
    {
        return $"{_streetAddress}, {_city}, {_stateOrProvince}, {_country}";
    }
}