public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points, string description) : base(name, points, description)
    {
    }

    public override void UpdateProgress()
    {
        IsCompleted = true;
    }
}
