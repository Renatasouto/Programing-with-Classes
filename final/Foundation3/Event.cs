public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string Time
    {
        get { return _time; }
        set { _time = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address.GetFormattedAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {Title}\nDate: {Date}";
    }
}
