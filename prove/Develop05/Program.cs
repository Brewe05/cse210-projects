class Program
{
    static void Main()
    {
        // Load user statistics from file
        UserStats userStats = new UserStats();

        // Main menu loop
        while (true)
        {
            // Display the current stats
            userStats.DisplayStats();

            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Stats");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            MindfulnessActivity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity(userStats);
                    break;
                case 2:
                    activity = new ReflectionActivity(userStats);
                    break;
                case 3:
                    activity = new ListingActivity(userStats);
                    break;
                case 4:
                    // Display stats and then wait for user to press Enter before returning to the main menu
                    userStats.DisplayStats();
                    Console.WriteLine("Press Enter to return to the main menu...");
                    Console.ReadLine();  // Wait for the user to press Enter
                    break; // Return to menu after viewing stats
                case 5:
                    // Save user stats before exiting
                    userStats.SaveStats();
                    Console.WriteLine("Goodbye!");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            // If an activity was selected, start it
            if (activity != null)
            {
                activity.StartActivity();
                // Save stats after activity completion
                userStats.SaveStats();

                // Wait for the user to press Enter before showing the main menu again
                Console.WriteLine("Press Enter to return to the main menu...");
                Console.ReadLine();  // Waits for the user to press Enter
            }
        }
    }
}





