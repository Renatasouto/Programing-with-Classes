public class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public int LengthInMinutes
    {
        get { return _lengthInMinutes; }
        set { _lengthInMinutes = value; }
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} | {LengthInMinutes} Min -  Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        
    }
}
