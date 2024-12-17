public class ChecklistGoal : Goal
{
    private int CompletionCount;
    private int TargetCompletions;
    private int BonusPoints;

    public ChecklistGoal(string name, string description, int pointsPerCompletion, int targetCompletions, int bonusPoints)
        : base(name, description)
    {
        Points = pointsPerCompletion;
        TargetCompletions = targetCompletions;
        BonusPoints = bonusPoints;
        CompletionCount = 0;
    }

    public override void RecordProgress()
    {
        if (CompletionCount < TargetCompletions)
        {
            CompletionCount++;
            Points += (CompletionCount == TargetCompletions) ? BonusPoints : 0;
            Console.WriteLine($"Goal '{Name}' recorded! You've earned {Points} points. {CompletionCount}/{TargetCompletions} completions.");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' has already been completed.");
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name} - {Description} (Completed {CompletionCount}/{TargetCompletions} times)");
    }

    public override bool IsComplete() => CompletionCount >= TargetCompletions;
}
