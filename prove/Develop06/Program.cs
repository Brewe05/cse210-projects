using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create the user
        User user = new User("Brent Welsford");

        // Define goals
        Goal simpleGoal = new SimpleGoal("Read the scriptures", "Read the scriptures daily for 100 points each", 100);
        Goal eternalGoal = new EternalGoal("Get married", "Get married in the temple for 1000 points .", 1000);
        Goal checklistGoal = new ChecklistGoal("Attend the Temple", "Attend the temple 10 times for 50 points each, plus a 500 point bonus for completion.", 50, 10, 500);

        // Add goals to user
        user.AddGoal(simpleGoal);
        user.AddGoal(eternalGoal);
        user.AddGoal(checklistGoal);

        // Main loop to allow user interaction
        while (true)
        {
            // Display goals and prompt user to mark as completed or not
            Console.Clear();
            Console.WriteLine($"Welcome, {user.UserName}!\n");

            user.DisplayGoals();
            Console.WriteLine("\nEnter the number of the goal to mark as completed (or type 'exit' to quit):");

            string input = Console.ReadLine().Trim();

            // Exit the loop if the user types "exit"
            if (input.ToLower() == "exit")
                break;

            // Try to parse the user input
            if (int.TryParse(input, out int goalIndex) && goalIndex >= 0 && goalIndex < user.Goals.Count)
            {
                Goal selectedGoal = user.Goals[goalIndex];

                // Prompt user for completion status
                Console.WriteLine($"Did you complete the goal '{selectedGoal.Name}'? (y/n): ");
                string completionInput = Console.ReadLine().Trim().ToLower();

                // Handle the user input for goal completion
                if (completionInput == "y")
                {
                    // Mark the goal as completed if applicable
                    selectedGoal.RecordProgress();
                    user.TotalPoints += selectedGoal.GetPoints();
                    Console.WriteLine($"You completed the goal '{selectedGoal.Name}'! You've earned {selectedGoal.GetPoints()} points.");
                }
                else if (completionInput == "n")
                {
                    Console.WriteLine($"You did not complete the goal '{selectedGoal.Name}'. No points earned.");
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter 'y' or 'n'.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid goal number.");
            }

            // Display the total score after each action
            user.ShowScore();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
