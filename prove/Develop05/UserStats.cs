using System;
using System.IO;

class UserStats
{
    private string statsFilePath = "userStats.txt";

    public int breathingCount { get; private set; }
    public int reflectionCount { get; private set; }
    public int listingCount { get; private set; }

    public UserStats()
    {
        LoadStats();
    }

    public void IncrementBreathing() => breathingCount++;
    public void IncrementReflection() => reflectionCount++;
    public void IncrementListing() => listingCount++;

    // Save stats to the file in a comma-separated format
    public void SaveStats()
    {
        using (StreamWriter writer = new StreamWriter(statsFilePath))
        {
            // Write the counts in a single line, separated by commas
            writer.WriteLine($"{breathingCount},{reflectionCount},{listingCount}");
        }
    }

    // Load stats from the file, expecting a single line with counts separated by commas
    public void LoadStats()
    {
        if (File.Exists(statsFilePath))
        {
            using (StreamReader reader = new StreamReader(statsFilePath))
            {
                string line = reader.ReadLine();
                if (line != null)
                {
                    var parts = line.Split(',');

                    // Parse each count from the comma-separated values
                    if (parts.Length == 3)
                    {
                        breathingCount = int.Parse(parts[0]);
                        reflectionCount = int.Parse(parts[1]);
                        listingCount = int.Parse(parts[2]);
                    }
                    else
                    {
                        // Handle case where the data doesn't match the expected format
                        Console.WriteLine("Error: Stats file has an invalid format.");
                        breathingCount = 0;
                        reflectionCount = 0;
                        listingCount = 0;
                    }
                }
            }
        }
        else
        {
            // Initialize counts to 0 if no stats file is found
            breathingCount = 0;
            reflectionCount = 0;
            listingCount = 0;
        }
    }

    public void DisplayStats()
    {
        Console.WriteLine("User Activity Stats:");
        Console.WriteLine($"Breathing Activities Completed: {breathingCount}");
        Console.WriteLine($"Reflection Activities Completed: {reflectionCount}");
        Console.WriteLine($"Listing Activities Completed: {listingCount}");
    }
}



