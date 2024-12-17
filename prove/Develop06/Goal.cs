public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    protected int Points { get; set; }

    public Goal(string name, string description)
    {
        Name = name;
        Description = description;
        Points = 0;
    }

    // Abstract method to record an event
    public abstract void RecordProgress();

    // Abstract method to display goal status
    public abstract void DisplayGoal();

    // Abstract method to check if the goal is complete
    public abstract bool IsComplete();

    public int GetPoints() => Points;
}

