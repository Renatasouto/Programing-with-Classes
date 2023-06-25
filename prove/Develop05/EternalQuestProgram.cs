public class EternalQuestProgram
{
    private List<Goal> goals;
    private int score;

    public EternalQuestProgram()
    {
        goals = new List<Goal>();
        score = 0;
    }

public int GetScore()
{
    return score;
}

    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
    }

public void ShowGoals()
{
    Console.WriteLine("List of Goals:");
    for (int i = 0; i < goals.Count; i++)
    {

        Goal goal = goals[i];
        string completionStatus = goal.IsCompleted ? "[X]" : "[ ]";

        Console.Write($"{i + 1}. {completionStatus} {goal.Name} ({goal.Description})");

        if (goal is ChecklistGoal checklistGoal)
        {
            Console.WriteLine($" -- Currently completed: {checklistGoal.ProgressCount}/{checklistGoal.CompletionCount}");
        }
        else
        {
            Console.WriteLine();
        }
    }
}

public void SaveGoals(string filename)
{
    string folderPath = "./goals";
    string filePath = Path.Combine(folderPath, filename);

    if (!Directory.Exists(folderPath))
    {
        Directory.CreateDirectory(folderPath);
    }

    using (StreamWriter writer = new StreamWriter(filePath))
    {
        writer.WriteLine(score);

        foreach (Goal goal in goals)
        {
            string goalType = goal.GetType().Name;
            string goalInfo = $"{goalType}: {goal.Name}, {goal.Points}, {goal.Description}, {goal.IsCompleted}";

            if (goal is ChecklistGoal checklistGoal)
            {
                goalInfo += $", {checklistGoal.ProgressCount}/{checklistGoal.CompletionCount}, {checklistGoal.BonusPoints}";
            }
            else if (goal is EternalGoal)
            {
                
            }

            writer.WriteLine(goalInfo);
        }
    }
}


   public void LoadData(string filename)
{
    string folderPath = "./goals";
    string filePath = Path.Combine(folderPath, filename);

    
    if (File.Exists(filePath))
    {
        goals.Clear();

        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length > 0)
        {
            int.TryParse(lines[0], out score);
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            string[] goalData = line.Split(':');

            if (goalData.Length >= 2)
            {
    
                string goalType = goalData[0].Trim();
                string goalDetails = goalData[1].Trim();

            
                string[] goalFields = goalDetails.Split(',');

                if (goalFields.Length >= 4)
                {
                    
                    string goalName = goalFields[0].Trim();
                    int goalPoints = 0;
                    int.TryParse(goalFields[1].Trim(), out goalPoints);
                    string goalDescription = goalFields[2].Trim();
                    bool goalIsCompleted = bool.Parse(goalFields[3].Trim());

                    
                    if (goalType == "SimpleGoal")
                    {
                        
                        Goal simpleGoal = new SimpleGoal(goalName, goalPoints, goalDescription);
                        simpleGoal.IsCompleted = goalIsCompleted;
                        goals.Add(simpleGoal);
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        
                        if (goalFields.Length >= 6)
                        {
                            string progressData = goalFields[4].Trim();
                            string[] progressInfo = progressData.Split('/');
                            int progressCount = 0;
                            int.TryParse(progressInfo[0].Trim(), out progressCount);
                            int completionCount = 0;
                            int.TryParse(progressInfo[1].Trim(), out completionCount);
                            int bonusPoints = 0;
                            int.TryParse(goalFields[5].Trim(), out bonusPoints);

                            
                            Goal checklistGoal = new ChecklistGoal(goalName, goalPoints, goalDescription, completionCount, bonusPoints);
                            checklistGoal.IsCompleted = goalIsCompleted;
                            ((ChecklistGoal)checklistGoal).ProgressCount = progressCount;
                            goals.Add(checklistGoal);
                        }
                    }
                    
                }
            }
        }

        Console.WriteLine("Goals data loaded successfully.");
    }
    else
    {
        Console.WriteLine("No goals data file found.");
    }
}
    public void RecordEvent(string goalName){
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.UpdateProgress();
            score += goal.Points;
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }
}