public class Cycling : Activity
{
    private double speed;

    public double Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public override double GetDistance()
    {
        return Speed * LengthInMinutes / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}