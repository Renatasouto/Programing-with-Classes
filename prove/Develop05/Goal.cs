public abstract class Goal
{
    private string name;
    private int points;
    private string description;

    public string Name { get { return name; } }
    public int Points { get { return points; } }
    public string Description { get { return description; } }
    public bool IsCompleted { get; set; }

    public Goal(string name, int points, string description)
    {
        this.name = name;
        this.points = points;
        this.description = description;
        IsCompleted = false;
    }

  protected void SetPoints(int points)
    {
        this.points = points;
    }
    public abstract void UpdateProgress();

    public override string ToString()
    {
        return $"{Name} ({Description})";
    }
}