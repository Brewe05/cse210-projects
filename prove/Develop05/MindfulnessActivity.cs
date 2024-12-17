using System;
using System.Collections.Generic;
using System.Threading;

abstract class MindfulnessActivity
{
    protected int durationInSeconds;
    protected string activityName;
    protected string activityDescription;

    public MindfulnessActivity(string name, string description)
    {
        activityName = name;
        activityDescription = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName}.");
        Console.WriteLine(activityDescription);
        Console.WriteLine("Please enter the duration of the activity in seconds:");
        durationInSeconds = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        PauseForSeconds(3); // Pause to prepare
        ExecuteActivity();  // Execute specific activity
        EndActivity();
    }

    protected abstract void ExecuteActivity();

    public void PauseForSeconds(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // 1-second delay to simulate pause animation
        }
        Console.WriteLine();
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You spent {durationInSeconds} seconds on this activity.");
        PauseForSeconds(3); // Final pause before exiting
    }
}

