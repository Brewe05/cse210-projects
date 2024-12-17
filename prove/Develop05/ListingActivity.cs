class ListingActivity : MindfulnessActivity
{
    private UserStats userStats;
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(UserStats stats) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        userStats = stats;
    }

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(selectedPrompt);
        PauseForSeconds(3); // Time to prepare for thinking

        List<string> entries = new List<string>();
        int elapsedTime = 0;

        while (elapsedTime < durationInSeconds)
        {
            Console.WriteLine("Enter an item or type 'done' to finish:");
            string entry = Console.ReadLine();
            if (entry.ToLower() == "done") break;
            entries.Add(entry);
            elapsedTime += 1; // Assume each entry takes roughly 1 second
        }

        Console.WriteLine($"You listed {entries.Count} items.");
        userStats.IncrementListing();
    }
}

