public class ChecklistGoal : Goal
{
    public int CompletionCount { get; }
    public int BonusPoints { get; }

    public int ProgressCount { get; set;}

    public ChecklistGoal(string name, int points, string description, int completionCount, int bonusPoints) : base(name, points, description)
    {
        CompletionCount = completionCount;
        BonusPoints = bonusPoints;
        ProgressCount = 0;
    }

    public override void UpdateProgress()
    {
        ProgressCount++;
        if (ProgressCount >= CompletionCount)
        {
            IsCompleted = true;
            SetPoints(Points + BonusPoints);
        }
    }
}
