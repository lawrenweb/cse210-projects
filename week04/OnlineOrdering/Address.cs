public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string StreetAddress
    {
        get { return _streetAddress; }
        set { _streetAddress = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string StateOrProvince
    {
        get { return _stateOrProvince; }
        set { _stateOrProvince = value; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", System.StringComparison.OrdinalIgnoreCase)
            || _country.Equals("United States", System.StringComparison.OrdinalIgnoreCase);
    }

    public string GetAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}