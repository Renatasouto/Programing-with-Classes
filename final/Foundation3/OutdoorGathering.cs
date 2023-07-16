public class OutdoorGathering : Event
{
    private string _weather;

    public string Weather
    {
        get { return _weather; }
        set { _weather = value; }
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather: {Weather}";
    }
}
