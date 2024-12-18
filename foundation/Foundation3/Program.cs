using System;
using System.Collections.Generic;
using FitnessApp.Activities;
using FitnessApp.DerivedActivities;

class Program
{
    static void Main()
    {
        // Creating instances of each activity
        var activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 30, 12.0),
            new Swimming("03 Nov 2022", 30, 20)
        };

        // Iterating over the list of activities and printing summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
