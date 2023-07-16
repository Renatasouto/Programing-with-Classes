public class Swimming : Activity
{
    private int _laps;

    public int Laps
    {
        get { return _laps; }
        set { _laps = value; }
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / LengthInMinutes * 60, 1);
    }

    public override double GetPace()
    {
        double pace = LengthInMinutes / GetDistance();
        double roundedPace = Math.Round(pace, 1);
        return roundedPace;
    }
}
