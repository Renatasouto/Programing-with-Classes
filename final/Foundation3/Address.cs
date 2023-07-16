public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _postalCode;

    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public string PostalCode
    {
        get { return _postalCode; }
        set { _postalCode = value; }
    }

    public string GetFormattedAddress()
    {
        return $"{_street}, {_city}, {_state}, {_postalCode}";
    }
}
