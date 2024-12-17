public class User
{
    public string UserName { get; set; }
    public List<Goal> Goals { get; set; }
    public int TotalPoints { get; set; }

    public User(string userName)
    {
        UserName = userName;
        Goals = new List<Goal>();
        TotalPoints = 0;
    }

    // Method to add goals to the user
    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    // Method to display all the goals for the user
    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i}. {Goals[i].Name}: {Goals[i].Description}");
        }
    }

    // Method to show the user's total score
    public void ShowScore()
    {
        Console.WriteLine($"Total Points: {TotalPoints}");
    }
}



