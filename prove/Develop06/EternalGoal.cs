public class EternalGoal : Goal
{
    private int CompletionCount;

    public EternalGoal(string name, string description, int pointsPerCompletion) : base(name, description)
    {
        Points = pointsPerCompletion;
        CompletionCount = 0;
    }

    public override void RecordProgress()
    {
        CompletionCount++;
        Console.WriteLine($"Goal '{Name}' recorded! You've earned {Points} points.");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name} - {Description} (Completed {CompletionCount} times)");
    }

    public override bool IsComplete() => false; // Eternal goals are never complete
}

