using System;
using System.Collections.Generic;

public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to initialize a comment
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; } // Length of the video in seconds
    public List<Comment> Comments { get; set; } // List to store comments

    // Constructor to initialize a video
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to format the video length in hours and minutes
    public string GetFormattedLength()
    {
        int hours = LengthInSeconds / 3600;
        int minutes = (LengthInSeconds % 3600) / 60;
        return $"{hours} hours {minutes} minutes";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("Tech Review: Latest Smartphone", "Brent Welsford", 600);
        Video video2 = new Video("How to Cook Spaghetti", "Michael Jackson", 480);
        Video video3 = new Video("Amazing Nature Documentary", "David Brown", 1200);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great review!"));
        video1.AddComment(new Comment("Bob", "I loved the comparison with other phones."));
        video1.AddComment(new Comment("Charlie", "Very informative video."));

        // Add comments to video 2
        video2.AddComment(new Comment("Sarah", "Yummy recipe!"));
        video2.AddComment(new Comment("Tom", "Can't wait to try this at home!"));
        video2.AddComment(new Comment("Mia", "I love pasta!"));

        // Add comments to video 3
        video3.AddComment(new Comment("Jake", "Such beautiful scenes."));
        video3.AddComment(new Comment("Olivia", "This video made my day."));
        video3.AddComment(new Comment("Lucas", "Incredible shots of nature."));

        // List to hold all videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through videos and display information
        foreach (Video video in videos)
        {
            // Display video details
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.GetFormattedLength()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Display comments
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // Blank line between videos
        }
    }
}
