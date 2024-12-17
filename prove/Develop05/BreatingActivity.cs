class BreathingActivity : MindfulnessActivity
{
    private UserStats userStats;

    public BreathingActivity(UserStats stats) : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        userStats = stats;
    }

    protected override void ExecuteActivity()
    {
        int elapsedTime = 0;
        while (elapsedTime < durationInSeconds)
        {
            Console.WriteLine("Breathe in...");
            PauseForSeconds(4);  // Adjust for breathing time
            Console.WriteLine("Breathe out...");
            PauseForSeconds(4);
            elapsedTime += 8; // 4 seconds for inhale + 4 seconds for exhale
        }

        userStats.IncrementBreathing();
    }
}

