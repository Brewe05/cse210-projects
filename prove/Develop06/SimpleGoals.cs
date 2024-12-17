public class SimpleGoal : Goal
{
    private bool IsCompleted;

    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        Points = points;
        IsCompleted = false;
    }

    public override void RecordProgress()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"Goal '{Name}' completed! You've earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' has already been completed.");
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name} - {Description} (Points: {Points})");
    }

    public override bool IsComplete() => IsCompleted;
}
