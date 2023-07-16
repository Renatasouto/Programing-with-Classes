public class Running : Activity
{
    private double distance;

    public double Distance
    {
        get { return distance; }
        set { distance = value; }
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / LengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / Distance;
    }
}